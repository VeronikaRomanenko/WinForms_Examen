using System;
using System.Collections.Generic;

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
    }
}