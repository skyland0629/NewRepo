using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication35
{
    public class versenyzők
    {
        public int sorszam;
        public int sebesseg;
        public int kor;
        public int lepes; //1 lépés = 1 kör
        

        public versenyzők
            (
            int sorszam,
            int sebesseg,
            int kor,
            int lepes
            )
        {
            this.sorszam = sorszam;
            this.sebesseg = sebesseg;
            this.kor = kor;
            this.lepes = lepes;
        }
    }
}