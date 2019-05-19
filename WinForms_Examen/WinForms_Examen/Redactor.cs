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
    public partial class Redactor : Form
    {
        private bool is_delo;
        public Delo del;
        public Proekt proek;
        public Redactor(bool is_delo)
        {
            InitializeComponent();
            this.is_delo = is_delo;
            if (is_delo)
            {
                Size = new Size(Size.Width, Size.Height - 150);
                lblSpisokDel.Visible = false;
                lsbSpisokDel.Visible = false;
                btnAddDelo.Visible = false;
            }
            else
            {
                lblFile.Visible = false;
                chbAddFile.Visible = false;
                txbFile.Visible = false;
            }
            cmbPrioritet.Items.Add("Высокий");
            cmbPrioritet.Items.Add("Средний");
            cmbPrioritet.Items.Add("Низкий");
        }

        private void chbAddDedline_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAddDedline.Checked == true)
            {
                lblDedline.Visible = true;
                dtpDedline.Visible = true;
            }
            else
            {
                lblDedline.Visible = false;
                dtpDedline.Visible = false;
            }
        }

        private void chbAddFile_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAddFile.Checked == true)
            {
                lblFile.Visible = true;
                txbFile.Visible = true;
            }
            else
            {
                lblFile.Visible = false;
                txbFile.Visible = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (is_delo)
            {
                Delo delo = new Delo();
                delo.Vipolneno = false;
                delo.Name = txbName.Text;
                delo.Opisanie = txbOpisanie.Text;
                if (dtpDedline.Visible == true)
                {
                    delo.Dedline = DateTime.Parse(dtpDedline.Text);
                }
                delo.tegi = new List<string>();
                foreach (string item in lsbTegi.Items)
                {
                    delo.tegi.Add(item);
                }
                if (txbFile.Visible == true)
                {
                    delo.FileName = txbFile.Text;
                }
                if (cmbPrioritet.SelectedItem.ToString() == "Высокий")
                {
                    delo.prioritet = Prioritet.Visokij;
                }
                else if (cmbPrioritet.SelectedItem.ToString() == "Средний")
                {
                    delo.prioritet = Prioritet.Srednij;
                }
                else
                {
                    delo.prioritet = Prioritet.Nizkij;
                }
                if (this.MdiParent != null)
                {
                    (this.MdiParent as Form1).dela.Add(delo);
                }
                else
                {
                    del = delo;
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            else
            {
                Proekt proekt = new Proekt();
                proekt.Name = txbName.Text;
                proekt.Opisanie = txbOpisanie.Text;
                proekt.dela = new List<Delo>();
                foreach (Delo item in lsbSpisokDel.Items)
                {
                    proekt.dela.Add(item);
                }
                if (dtpDedline.Visible == true)
                {
                    proekt.Dedline = DateTime.Parse(dtpDedline.Text);
                }
                proekt.tegi = new List<string>();
                foreach (string item in lsbTegi.Items)
                {
                    proekt.tegi.Add(item);
                }
                if (cmbPrioritet.SelectedItem.ToString() == "Высокий")
                {
                    proekt.prioritet = Prioritet.Visokij;
                }
                else if (cmbPrioritet.SelectedItem.ToString() == "Средний")
                {
                    proekt.prioritet = Prioritet.Srednij;
                }
                else
                {
                    proekt.prioritet = Prioritet.Nizkij;
                }
                if (this.MdiParent != null)
                {
                    (this.MdiParent as Form1).proekti.Add(proekt);
                }
                else
                {
                    proek = proekt;
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private void btnAddTeg_Click(object sender, EventArgs e)
        {
            if (txbTeg.Text.Length != 0)
            {
                lsbTegi.Items.Add(txbTeg.Text);
            }
        }

        private void btnAddDelo_Click(object sender, EventArgs e)
        {
            Redactor form = new Redactor(true);
            if (form.ShowDialog() == DialogResult.OK)
            {
                lsbSpisokDel.Items.Add(form.del);
            }
        }
    }
}