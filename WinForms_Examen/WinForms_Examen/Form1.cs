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
    public enum Prioritet { Visokij, Srednij, Nizkij}
    public partial class Form1 : Form
    {
        public List<Delo> dela;
        public List<Proekt> proekti;
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dela = new List<Delo>();
            proekti = new List<Proekt>();
            IsMdiContainer = true;
        }

        private void newDeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Redactor form = new Redactor(true);
            form.MdiParent = this;
            form.Show();
        }

        private void newProektToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Redactor form = new Redactor(false);
            form.MdiParent = this;
            form.Show();
        }

        private void spisokDelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpisokDel form = new SpisokDel(this);
            form.MdiParent = this;
            form.Show();
        }

        private void spisokProektovToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpisokProektov form = new SpisokProektov(this);
            form.MdiParent = this;
            form.Show();
        }

        private void poiskDelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Poisk form = new Poisk(true);
            form.MdiParent = this;
            form.Show();
        }

        private void poiskProektovToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Poisk form = new Poisk(false);
            form.MdiParent = this;
            form.Show();
        }

        private void saveInPdfToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}