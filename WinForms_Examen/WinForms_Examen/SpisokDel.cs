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
    public partial class SpisokDel : Form
    {
        Form1 form1;
        public SpisokDel(Form1 form)
        {
            InitializeComponent();
            form1 = form;
            foreach (Delo item in form1.dela)
            {
                if (item.Vipolneno)
                {
                    checkedListBox1.Items.Add(item.Name, true);
                }
                else
                {
                    checkedListBox1.Items.Add(item.Name);
                }
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (checkedListBox1.SelectedIndex == -1)
            {
                return;
            }
            Delo tmp = form1.dela[checkedListBox1.SelectedIndex];
            listBox1.Items.Add("Описание: " + tmp.Opisanie);
            if (tmp.Dedline.Year != 0001)
            {
                listBox1.Items.Add("Дедлайн: " + tmp.Dedline.ToLongDateString() + ", " + tmp.Dedline.ToLongTimeString());
            }
            string tegi = "";
            foreach (string item in tmp.tegi)
            {
                tegi += item;
                tegi += ", ";
            }
            listBox1.Items.Add("Теги: " + tegi);
            if (tmp.FileName != null)
            {
                listBox1.Items.Add("Прикрепленный файл: " + tmp.FileName);
            }
            if (tmp.prioritet == Prioritet.Visokij)
            {
                listBox1.Items.Add("Приоритет: Высокий");
            }
            else if (tmp.prioritet == Prioritet.Srednij)
            {
                listBox1.Items.Add("Приоритет: Средний");
            }
            else
            {
                listBox1.Items.Add("Приоритет: Низкий");
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.CurrentValue == CheckState.Checked)
            {
                (this.MdiParent as Form1).dela[e.Index].Vipolneno = true;
            }
            else
            {
                (this.MdiParent as Form1).dela[e.Index].Vipolneno = false;
            }
        }

        private void rdbDen_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDen.Checked)
            {
                checkedListBox1.Items.Clear();
                foreach (Delo item in (this.MdiParent as Form1).dela)
                {
                    if (item.Dedline.Date == DateTime.Now.Date)
                    {
                        if (item.Vipolneno)
                        {
                            checkedListBox1.Items.Add(item.Name, true);
                        }
                        else
                        {
                            checkedListBox1.Items.Add(item.Name);
                        }
                    }
                }
            }
        }

        private void rdbNedela_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNedela.Checked)
            {
                checkedListBox1.Items.Clear();
                foreach (Delo item in (this.MdiParent as Form1).dela)
                {
                    if (item.Dedline.Year == DateTime.Now.Year && (item.Dedline.DayOfYear - DateTime.Now.DayOfYear <= 7) && (item.Dedline.DayOfYear - DateTime.Now.DayOfYear >= 0))
                    {
                        if (item.Vipolneno)
                        {
                            checkedListBox1.Items.Add(item.Name, true);
                        }
                        else
                        {
                            checkedListBox1.Items.Add(item.Name);
                        }
                    }
                }
            }
        }

        private void rdbMesaz_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMesaz.Checked)
            {
                checkedListBox1.Items.Clear();
                foreach (Delo item in (this.MdiParent as Form1).dela)
                {
                    if (item.Dedline.Year == DateTime.Now.Year && item.Dedline.Month == DateTime.Now.Month)
                    {
                        if (item.Vipolneno)
                        {
                            checkedListBox1.Items.Add(item.Name, true);
                        }
                        else
                        {
                            checkedListBox1.Items.Add(item.Name);
                        }
                    }
                }
            }
        }

        private void rdbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAll.Checked)
            {
                checkedListBox1.Items.Clear();
                foreach (Delo item in (this.MdiParent as Form1).dela)
                {
                    if (item.Vipolneno)
                    {
                        checkedListBox1.Items.Add(item.Name, true);
                    }
                    else
                    {
                        checkedListBox1.Items.Add(item.Name);
                    }
                }
            }
        }

        private void redactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedIndex != -1)
            {
                Redactor form = new Redactor((this.MdiParent as Form1).dela[checkedListBox1.SelectedIndex]);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    (this.MdiParent as Form1).dela[checkedListBox1.SelectedIndex] = form.del;
                    checkedListBox1.Items[checkedListBox1.SelectedIndex] = form.del.Name;
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedIndex != -1)
            {
                (this.MdiParent as Form1).dela.RemoveAt(checkedListBox1.SelectedIndex);
                checkedListBox1.Items.RemoveAt(checkedListBox1.SelectedIndex);
            }
        }
    }
}