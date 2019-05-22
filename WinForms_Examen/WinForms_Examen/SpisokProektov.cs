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
    public partial class SpisokProektov : Form
    {
        public SpisokProektov(Form1 form1)
        {
            InitializeComponent();
            Form1 form = form1;
            foreach (Proekt item in form.proekti)
            {
                lsbProekti.Items.Add(item.Name);
            }
        }

        private void lsbProekti_SelectedIndexChanged(object sender, EventArgs e)
        {
            clbDela.Items.Clear();
            foreach (Delo item in (this.MdiParent as Form1).proekti[lsbProekti.SelectedIndex].dela)
            {
                clbDela.Items.Add(item.Name);
            }
            lsbSvojstva.Items.Clear();
            Proekt tmp = (this.MdiParent as Form1).proekti[lsbProekti.SelectedIndex];
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

        private void clbDela_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.CurrentValue == CheckState.Checked)
            {
                (this.MdiParent as Form1).proekti[lsbProekti.SelectedIndex].dela[e.Index].Vipolneno = true;
            }
            else
            {
                (this.MdiParent as Form1).proekti[lsbProekti.SelectedIndex].dela[e.Index].Vipolneno = false;
            }
        }

        private void clbDela_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsbSvojstva.Items.Clear();
            Delo tmp = (this.MdiParent as Form1).proekti[lsbProekti.SelectedIndex].dela[clbDela.SelectedIndex];
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

        private void lsbProekti_DoubleClick(object sender, EventArgs e)
        {
            Redactor form = new Redactor(false);
            if (form.ShowDialog() == DialogResult.OK)
            {
                lsbProekti.SelectedItem = form.proek.Name;
                (this.MdiParent as Form1).proekti[lsbProekti.SelectedIndex] = form.proek;
            }
        }

        private void clbDela_DoubleClick(object sender, EventArgs e)
        {
            Redactor form = new Redactor(true);
            if (form.ShowDialog() == DialogResult.OK)
            {
                clbDela.SelectedItem = form.del.Name;
                (this.MdiParent as Form1).proekti[lsbProekti.SelectedIndex].dela[clbDela.SelectedIndex] = form.del;
            }
        }

        private void redactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lsbProekti.SelectedIndex != -1)
            {
                Redactor form = new Redactor((this.MdiParent as Form1).proekti[lsbProekti.SelectedIndex]);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    lsbProekti.Items[lsbProekti.SelectedIndex] = form.proek.Name;
                    (this.MdiParent as Form1).proekti[lsbProekti.SelectedIndex] = form.proek;
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}