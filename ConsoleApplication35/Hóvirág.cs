using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication35
{
    public class Hóvirág : versenyzők
    {
        public Hóvirág(int sorszam, int sebesseg, int kor, int lepes) : base(sorszam, sebesseg, kor, lepes)
        {
            this.sorszam = sorszam;
            this.sebesseg = sebesseg;
            this.kor = kor;
            this.lepes = lepes;
        }
    }
}