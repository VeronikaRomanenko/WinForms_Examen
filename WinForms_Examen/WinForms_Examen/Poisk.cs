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
            cmbPrioritet.Items.Add("Высокий");
            cmbPrioritet.Items.Add("Средний");
            cmbPrioritet.Items.Add("Низкий");
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
            if (txbPoisk.Text == "")
            {
                return;
            }
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
                        else
                        {
                            prior = Prioritet.Nizkij;
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
                        else
                        {
                            prior = Prioritet.Nizkij;
                        }
                        if (item.prioritet == prior)
                        {
                            clbDela.Items.Add(item.Name);
                        }
                    }
                }
            }
        }

        private void lsbProekti_SelectedIndexChanged(object sender, EventArgs e)
        {
            clbDela.Items.Clear();
            foreach (Delo item in (this.MdiParent as Form1).proekti.Find(x => x.Name == lsbProekti.SelectedItem.ToString()).dela)
            {
                clbDela.Items.Add(item.Name);
            }
            lsbSvojstva.Items.Clear();
            Proekt tmp = (this.MdiParent as Form1).proekti.Find(x => x.Name == lsbProekti.SelectedItem.ToString());
            lsbSvojstva.Items.Add("Описание: " + tmp.Opisanie);
            if (tmp.Dedline != null)
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

        private void lsbProekti_DoubleClick(object sender, EventArgs e)
        {
            Redactor form = new Redactor(false);
            if (form.ShowDialog() == DialogResult.OK)
            {
                (this.MdiParent as Form1).proekti[(this.MdiParent as Form1).proekti.FindIndex(x => x.Name == lsbProekti.SelectedItem.ToString())] = form.proek;
                lsbProekti.SelectedItem = form.proek.Name;
            }
        }

        private void clbDela_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsbSvojstva.Items.Clear();
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
            if (tmp.Dedline != null)
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

        private void clbDela_DoubleClick(object sender, EventArgs e)
        {
            Redactor form = new Redactor(true);
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (is_delo)
                {
                    int index = (this.MdiParent as Form1).dela.FindIndex(x => x.Name == clbDela.SelectedItem.ToString());
                    (this.MdiParent as Form1).dela[index] = form.del;
                }
                else
                {
                    int index1 = (this.MdiParent as Form1).proekti.FindIndex(x => x.Name == lsbProekti.SelectedItem.ToString());
                    int index2 = (this.MdiParent as Form1).proekti[index1].dela.FindIndex(x => x.Name == clbDela.SelectedItem.ToString());
                    (this.MdiParent as Form1).proekti[index1].dela[index2] = form.del;
                }
                clbDela.SelectedItem = form.del.Name;
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
                if (is_delo)
                    (this.MdiParent as Form1).proekti[index1].dela[index2].Vipolneno = true;
                else
                    (this.MdiParent as Form1).dela[index1].Vipolneno = true;
            }
            else
            {
                if (is_delo)
                    (this.MdiParent as Form1).proekti[index1].dela[index2].Vipolneno = false;
                else
                    (this.MdiParent as Form1).dela[index1].Vipolneno = false;
            }
        }
    }
}