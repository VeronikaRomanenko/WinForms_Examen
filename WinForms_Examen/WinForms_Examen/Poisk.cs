using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Examen
{
    public partial class Poisk : Form
    {
        bool is_delo;
        public Poisk(bool is_delo)
        {
            InitializeComponent();
            this.is_delo = is_delo;
            if (is_delo)
            {
                lsbProekti.Visible = false;
                lsbSvojstva.Location = clbDela.Location;
                clbDela.Location = lsbProekti.Location;
                Size = new Size(Size.Width, Size.Height - lsbProekti.Height);
            }
            else
            {
                clbDela.AllowDrop = true;
            }
            cmbPrioritet.Items.Add("Высокий");
            cmbPrioritet.Items.Add("Средний");
            cmbPrioritet.Items.Add("Низкий");
            cmbPrioritet.SelectedIndex = 0;
        }

        private void rdbPoPrioritet_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPoPrioritet.Checked)
            {
                txbPoisk.Visible = false;
                cmbPrioritet.Visible = true;
            }
            else
            {
                txbPoisk.Visible = true;
                cmbPrioritet.Visible = false;
            }
        }

        private void btnPoisk_Click(object sender, EventArgs e)
        {
            lsbProekti.Items.Clear();
            clbDela.Items.Clear();
            lsbSvojstva.Items.Clear();
            if (is_delo)
            {
                foreach (Delo item in (this.MdiParent as Form1).dela)
                {
                    if (rdbPoName.Checked)
                    {
                        if (item.Name == txbPoisk.Text)
                        {
                            clbDela.Items.Add(item.Name);
                        }
                    }
                    else if (rdbPoTeg.Checked)
                    {
                        foreach (string teg in item.tegi)
                        {
                            if (teg == txbPoisk.Text)
                            {
                                clbDela.Items.Add(item.Name);
                            }
                        }
                    }
                    else
                    {
                        Prioritet prior;
                        if (cmbPrioritet.SelectedItem.ToString() == "Высокий")
                        {
                            prior = Prioritet.Visokij;
                        }
                        else if (cmbPrioritet.SelectedItem.ToString() == "Средний")
                        {
                            prior = Prioritet.Srednij;
                        }
                        else if (cmbPrioritet.SelectedItem.ToString() == "Низкий")
                        {
                            prior = Prioritet.Nizkij;
                        }
                        else
                        {
                            return;
                        }
                        if (item.prioritet == prior)
                        {
                            clbDela.Items.Add(item.Name);
                        }
                    }
                }
            }
            else
            {
                foreach (Proekt item in (this.MdiParent as Form1).proekti)
                {
                    if (rdbPoName.Checked)
                    {
                        if (item.Name == txbPoisk.Text)
                        {
                            lsbProekti.Items.Add(item.Name);
                        }
                    }
                    else if (rdbPoTeg.Checked)
                    {
                        foreach (string teg in item.tegi)
                        {
                            if (teg == txbPoisk.Text)
                            {
                                lsbProekti.Items.Add(item.Name);
                            }
                        }
                    }
                    else
                    {
                        Prioritet prior;
                        if (cmbPrioritet.SelectedItem.ToString() == "Высокий")
                        {
                            prior = Prioritet.Visokij;
                        }
                        else if (cmbPrioritet.SelectedItem.ToString() == "Средний")
                        {
                            prior = Prioritet.Srednij;
                        }
                        else if (cmbPrioritet.SelectedItem.ToString() == "Низкий")
                        {
                            prior = Prioritet.Nizkij;
                        }
                        else
                        {
                            return;
                        }
                        if (item.prioritet == prior)
                        {
                            lsbProekti.Items.Add(item.Name);
                        }
                    }
                }
            }
        }

        private void lsbProekti_SelectedIndexChanged(object sender, EventArgs e)
        {
            clbDela.Items.Clear();
            lsbSvojstva.Items.Clear();
            if (lsbProekti.SelectedIndex == -1)
            {
                return;
            }
            foreach (Delo item in (this.MdiParent as Form1).proekti.Find(x => x.Name == lsbProekti.SelectedItem.ToString()).dela)
            {
                clbDela.Items.Add(item.Name);
            }
            Proekt tmp = (this.MdiParent as Form1).proekti.Find(x => x.Name == lsbProekti.SelectedItem.ToString());
            lsbSvojstva.Items.Add("Описание: " + tmp.Opisanie);
            if (tmp.Dedline.Year != 0001)
            {
                lsbSvojstva.Items.Add("Дедлайн: " + tmp.Dedline.ToLongDateString() + ", " + tmp.Dedline.ToLongTimeString());
            }
            string tegi = "";
            foreach (string item in tmp.tegi)
            {
                tegi += item;
                tegi += ", ";
            }
            lsbSvojstva.Items.Add("Теги: " + tegi);
            if (tmp.prioritet == Prioritet.Visokij)
            {
                lsbSvojstva.Items.Add("Приоритет: Высокий");
            }
            else if (tmp.prioritet == Prioritet.Srednij)
            {
                lsbSvojstva.Items.Add("Приоритет: Средний");
            }
            else
            {
                lsbSvojstva.Items.Add("Приоритет: Низкий");
            }
        }

        private void clbDela_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsbSvojstva.Items.Clear();
            if (clbDela.SelectedIndex == -1)
            {
                return;
            }
            Delo tmp = null;
            if (is_delo)
            {
                tmp = (this.MdiParent as Form1).dela.Find(x => x.Name == clbDela.SelectedItem.ToString());
            }
            else
            {
                tmp = (this.MdiParent as Form1).proekti.Find(x => x.Name == lsbProekti.SelectedItem.ToString()).dela.Find(x => x.Name == clbDela.SelectedItem.ToString());
            }
            lsbSvojstva.Items.Add("Описание: " + tmp.Opisanie);
            if (tmp.Dedline.Year != 0001)
            {
                lsbSvojstva.Items.Add("Дедлайн: " + tmp.Dedline.ToLongDateString() + ", " + tmp.Dedline.ToLongTimeString());
            }
            string tegi = "";
            foreach (string item in tmp.tegi)
            {
                tegi += item;
                tegi += ", ";
            }
            lsbSvojstva.Items.Add("Теги: " + tegi);
            if (tmp.FileName != null)
            {
                lsbSvojstva.Items.Add("Прикрепленный файл: " + tmp.FileName);
            }
            if (tmp.prioritet == Prioritet.Visokij)
            {
                lsbSvojstva.Items.Add("Приоритет: Высокий");
            }
            else if (tmp.prioritet == Prioritet.Srednij)
            {
                lsbSvojstva.Items.Add("Приоритет: Средний");
            }
            else
            {
                lsbSvojstva.Items.Add("Приоритет: Низкий");
            }
        }

        private void clbDela_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int index1 = 0, index2 = 0;
            if (is_delo)
            {
                index1 = (this.MdiParent as Form1).dela.FindIndex(x => x.Name == clbDela.Items[e.Index].ToString());
            }
            else
            {
                index1 = (this.MdiParent as Form1).proekti.FindIndex(x => x.Name == lsbProekti.SelectedItem.ToString());
                index2 = (this.MdiParent as Form1).proekti[index1].dela.FindIndex(x => x.Name == clbDela.Items[e.Index].ToString());
            }
            if (e.CurrentValue == CheckState.Checked)
            {
                if (!is_delo)
                    (this.MdiParent as Form1).proekti[index1].dela[index2].Vipolneno = true;
                else
                    (this.MdiParent as Form1).dela[index1].Vipolneno = true;
            }
            else
            {
                if (!is_delo)
                    (this.MdiParent as Form1).proekti[index1].dela[index2].Vipolneno = false;
                else
                    (this.MdiParent as Form1).dela[index1].Vipolneno = false;
            }
        }

        private void redactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (is_delo)
            {
                if (clbDela.SelectedIndex != -1)
                {
                    Redactor form = new Redactor((this.MdiParent as Form1).dela[clbDela.SelectedIndex]);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        (this.MdiParent as Form1).dela[clbDela.SelectedIndex] = form.del;
                        clbDela.Items[clbDela.SelectedIndex] = form.del.Name;
                    }
                }
            }
            else
            {
                if (lsbProekti.SelectedIndex != -1)
                {
                    Redactor form = new Redactor((this.MdiParent as Form1).proekti[lsbProekti.SelectedIndex]);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        (this.MdiParent as Form1).proekti[lsbProekti.SelectedIndex] = form.proek;
                        lsbProekti.Items[lsbProekti.SelectedIndex] = form.proek.Name;
                        lsbProekti.SelectedIndex = -1;
                    }
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (is_delo)
            {
                if (clbDela.SelectedIndex != -1)
                {
                    Form1.names.Remove((this.MdiParent as Form1).dela[clbDela.SelectedIndex].Name);
                    (this.MdiParent as Form1).dela.RemoveAt(clbDela.SelectedIndex);
                    clbDela.Items.RemoveAt(clbDela.SelectedIndex);
                }
            }
            else
            {
                if (lsbProekti.SelectedIndex != -1)
                {
                    (this.MdiParent as Form1).proekti.RemoveAt(lsbProekti.SelectedIndex);
                    lsbProekti.Items.RemoveAt(lsbProekti.SelectedIndex);
                }
            }
        }
    }
}