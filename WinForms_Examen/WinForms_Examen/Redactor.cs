﻿using System;
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
        public List<Delo> dels;
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
                menuStrip1.Items[0].Visible = false;
            }
            else
            {
                lblFile.Visible = false;
                chbAddFile.Visible = false;
                txbFile.Visible = false;
                dels = new List<Delo>();
            }
            cmbPrioritet.Items.Add("Высокий");
            cmbPrioritet.Items.Add("Средний");
            cmbPrioritet.Items.Add("Низкий");
            cmbPrioritet.SelectedIndex = 0;
        }

        public Redactor(Delo delo) : this(true)
        {
            txbName.Text = delo.Name;
            txbOpisanie.Text = delo.Opisanie;
            if (delo.prioritet == Prioritet.Visokij)
            {
                cmbPrioritet.SelectedIndex = 0;
            }
            else if (delo.prioritet == Prioritet.Srednij)
            {
                cmbPrioritet.SelectedIndex = 1;
            }
            else
            {
                cmbPrioritet.SelectedIndex = 2;
            }
            foreach (string item in delo.tegi)
            {
                lsbTegi.Items.Add(item);
            }
            if (delo.Dedline.Year != 0001)
            {
                chbAddDedline.Checked = true;
                dtpDedline.Value = delo.Dedline;
            }
            if (delo.FileName != null)
            {
                chbAddFile.Checked = true;
                txbFile.Text = delo.FileName;
            }
        }

        public Redactor(Proekt proekt) : this(false)
        {
            txbName.Text = del.Name;
            txbOpisanie.Text = del.Opisanie;
            if (del.prioritet == Prioritet.Visokij)
            {
                cmbPrioritet.SelectedIndex = 0;
            }
            else if (del.prioritet == Prioritet.Srednij)
            {
                cmbPrioritet.SelectedIndex = 1;
            }
            else
            {
                cmbPrioritet.SelectedIndex = 2;
            }
            foreach (string item in del.tegi)
            {
                lsbTegi.Items.Add(item);
            }
            if (del.Dedline.Year != 0001)
            {
                chbAddDedline.Checked = true;
                dtpDedline.Value = del.Dedline;
            }
            foreach (Delo item in proekt.dela)
            {
                dels.Add(item);
                lsbSpisokDel.Items.Add(item.Name);
            }
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
                else if (cmbPrioritet.SelectedItem.ToString() == "Низкий")
                {
                    delo.prioritet = Prioritet.Nizkij;
                }
                else
                {
                    return;
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
                foreach (Delo item in dels)
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
                else if (cmbPrioritet.SelectedItem.ToString() == "Низкий")
                {
                    proekt.prioritet = Prioritet.Nizkij;
                }
                else
                {
                    return;
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
            Close();
        }

        private void btnAddTeg_Click(object sender, EventArgs e)
        {
            if (txbTeg.Text.Length != 0)
            {
                lsbTegi.Items.Add(txbTeg.Text);
                txbTeg.Text = "";
            }
        }

        private void btnAddDelo_Click(object sender, EventArgs e)
        {
            Redactor form = new Redactor(true);
            if (form.ShowDialog() == DialogResult.OK)
            {
                lsbSpisokDel.Items.Add(form.del.Name);
                dels.Add(form.del);
            }
        }

        private void lsbTegi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbTegi.SelectedIndex != -1)
            {
                lsbSpisokDel.SelectedIndex = -1;
            }
        }

        private void lsbSpisokDel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbSpisokDel.SelectedIndex != -1)
            {
                lsbTegi.SelectedIndex = -1;
            }
        }

        private void redactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lsbSpisokDel.SelectedIndex != -1)
            {
                Redactor form = new Redactor(dels[lsbSpisokDel.SelectedIndex]);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    dels[lsbSpisokDel.SelectedIndex] = form.del;
                    lsbSpisokDel.Items[lsbSpisokDel.SelectedIndex] = form.del.Name;
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lsbSpisokDel.SelectedIndex != -1)
            {
                dels.RemoveAt(lsbSpisokDel.SelectedIndex);
                lsbSpisokDel.Items.RemoveAt(lsbSpisokDel.SelectedIndex);
            }
            else if (lsbTegi.SelectedIndex != -1)
            {
                lsbTegi.Items.RemoveAt(lsbTegi.SelectedIndex);
            }
        }
    }
}