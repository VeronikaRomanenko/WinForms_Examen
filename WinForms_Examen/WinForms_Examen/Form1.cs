using EO.Pdf;
using EO.Pdf.Acm;
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

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private string deloVString(Delo d)
        {
            string tmp = d.Name;
            tmp += ": ";
            tmp += d.Opisanie;
            if (d.Dedline.Year != 0001)
            {
                tmp += ", ";
                tmp += d.Dedline.ToLongDateString();
                tmp += " ";
                tmp += d.Dedline.ToLongTimeString();
            }
            foreach (string str in d.tegi)
            {
                tmp += ", ";
                tmp += str;
            }
            if (d.FileName != "")
            {
                tmp += ", прикрепленный файл - ";
                tmp += d.FileName;
            }
            tmp += ", приоритет - ";
            if (d.prioritet == Prioritet.Visokij)
                tmp += "высокий";
            else if (d.prioritet == Prioritet.Srednij)
                tmp += "средний";
            else
                tmp += "низкий";
            return tmp;
        }

        private void saveInPdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PdfDocument doc = new PdfDocument();
            
            AcmRender render = new AcmRender(doc);

            foreach (Delo item in dela)
            {               
                AcmText text = new AcmText(deloVString(item));
                render.Render(text);
            }
            foreach (Proekt item in proekti)
            {
                string tmp = item.Name;
                tmp += ": ";
                tmp += item.Opisanie;
                if (item.Dedline.Year != 0001)
                {
                    tmp += ", ";
                    tmp += item.Dedline.ToLongDateString();
                    tmp += " ";
                    tmp += item.Dedline.ToLongTimeString();
                }
                foreach (string str in item.tegi)
                {
                    tmp += ", ";
                    tmp += str;
                }
                tmp += ", приоритет - ";
                if (item.prioritet == Prioritet.Visokij)
                    tmp += "высокий";
                else if (item.prioritet == Prioritet.Srednij)
                    tmp += "средний";
                else
                    tmp += "низкий";
                tmp += ", дела:";
                AcmText text = new AcmText(tmp);
                render.Render(text);

                foreach (Delo d in item.dela)
                {
                    AcmText t = new AcmText(deloVString(d));
                    render.Render(t);
                }
            }
            
            doc.Save("pdfFiles/Список дел.pdf");

        }
    }
}