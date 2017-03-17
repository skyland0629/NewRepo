using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication35
{
    public class Barna_a_medve : versenyzők
    {
        public Barna_a_medve
            (
            int Sorszam,
            int sebesseg,
            int kor,
            int lepes
            ):base
            (Sorszam,
                sebesseg,
                kor,
                lepes
                )
        {
            this.sorszam = Sorszam;
            this.sebesseg = sebesseg;
            this.kor = kor;
            this.lepes = lepes;

        }

        public void lep()
        {
            lepes = kor;
        }
    }
}