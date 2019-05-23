using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Examen
{
    public enum Prioritet { Visokij, Srednij, Nizkij }
    public partial class Form1 : Form
    {
        public List<Delo> dela;
        public List<Proekt> proekti;
        static public List<string> names;
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dela = new List<Delo>();
            proekti = new List<Proekt>();
            names = new List<string>();
            IsMdiContainer = true;
            if (File.Exists("Dela.txt"))
            {
                try
                {
                    foreach (string item in File.ReadAllLines("Dela.txt"))
                    {
                        Delo d = new Delo();
                        d.DownloadFromFile(item);
                        dela.Add(d);
                        names.Add(d.Name);
                        File.Delete(item);
                    }
                }
                catch { }
            }
            File.Delete("Dela.txt");
            if (File.Exists("Proekti.txt"))
            {
                try
                {
                    foreach (string item in File.ReadAllLines("Proekti.txt"))
                    {
                        Proekt p = new Proekt();
                        p.DownloadFromFiles(item);
                        proekti.Add(p);
                        names.Add(p.Name);
                        foreach (Delo delo in p.dela)
                        {
                            names.Add(delo.Name);
                        }
                        File.Delete(item);
                    }
                }
                catch { }
            }
            File.Delete("Proekti.txt");
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            List<string> tmp = new List<string>();
            foreach (Delo item in dela)
            {
                tmp.Add(item.Name + ".txt");
                item.SaveToFile(item.Name + ".txt");
            }
            File.WriteAllLines("Dela.txt", tmp);
            tmp = new List<string>();
            foreach (Proekt item in proekti)
            {
                tmp.Add(item.Name + ".txt");
                item.SaveToFiles();
            }
            File.WriteAllLines("Proekti.txt", tmp);
        }
    }
}