using System;
using System.Collections.Generic;

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
    }
}