using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WinForms_Examen
{
    public class Proekt
    {
        public string Name { set; get; }
        public string Opisanie { set; get; }
        public List<Delo> dela;
        public DateTime Dedline { set; get; }
        public List<string> tegi;
        public Prioritet prioritet { set; get; }
        public void SaveToFiles()
        {
            List<string> tmp = new List<string>();
            tmp.Add(Name);
            tmp.Add(Opisanie);
            string str = "";
            foreach (Delo item in dela)
            {
                str += item.Name;
                str += ".txt;";
                item.SaveToFile(item.Name + ".txt");
            }
            tmp.Add(str);
            tmp.Add(Dedline.ToLongDateString() + " " + Dedline.ToLongTimeString());
            str = "";
            foreach (string item in tegi)
            {
                str += item;
                str += ";";
            }
            tmp.Add(str);
            tmp.Add(((int)prioritet).ToString());
            File.WriteAllLines(Name + ".txt", tmp);
        }
        public void DownloadFromFiles(string path)
        {
            List<string> tmp = new List<string>(File.ReadAllLines(path));
            Name = tmp[0];
            Opisanie = tmp[1];
            dela = new List<Delo>();
            foreach (string item in tmp[2].Split(';'))
            {
                if (File.Exists(item))
                {
                    Delo d = new Delo();
                    d.DownloadFromFile(item);
                    dela.Add(d);
                    File.Delete(item);
                }
            }
            Dedline = DateTime.Parse(tmp[3]);
            tegi = new List<string>(tmp[4].Split(';'));
            prioritet = (Prioritet)int.Parse(tmp[5]);
        }
    }
}