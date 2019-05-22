using System;
using System.Collections.Generic;
using System.IO;

namespace WinForms_Examen
{
    public class Delo
    {
        public string Name { set; get; }
        public string Opisanie { set; get; }
        public DateTime Dedline { set; get; }
        public List<string> tegi;
        public string FileName { set; get; }
        public Prioritet prioritet { set; get; }
        public bool Vipolneno { set; get; }
        public void SaveToFile(string path)
        {
            List<string> tmp = new List<string>();
            tmp.Add(Name);
            tmp.Add(Opisanie);
            tmp.Add(Dedline.ToLongDateString() + " " + Dedline.ToLongTimeString());
            string str = "";
            foreach (string item in tegi)
            {
                str += item;
                str += ";";
            }
            tmp.Add(str);
            tmp.Add(FileName);
            tmp.Add(prioritet.ToString());
            tmp.Add(Vipolneno.ToString());
            File.WriteAllLines(path, tmp);
        }
        public void DownloadFromFile(string path)
        {
            List<string> tmp = new List<string>(File.ReadAllLines(path));
            Name = tmp[0];
            Opisanie = tmp[1];
            Dedline = DateTime.Parse(tmp[2]);

            FileName = tmp[4];
        }
    }
}