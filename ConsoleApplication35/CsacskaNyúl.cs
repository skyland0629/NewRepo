using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication35
{
    public class CsacskaNyúl : versenyzők
    {
        public CsacskaNyúl(int sorszam, int sebesseg, int kor, int lepes) : base(sorszam, sebesseg, kor, lepes)
        {
            this.sorszam = sorszam;
            this.sebesseg = sebesseg;//1.5x ordításnál
            this.kor = kor;
            this.lepes = lepes;
        }
    }
}