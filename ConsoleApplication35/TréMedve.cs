using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication35
{
    public class TréMedve : versenyzők
    {   public int orditas;

        /*public int sorszam;
        public int sebesseg;
        public int kor;
        public int lepes;*/

        public TréMedve(int sorszam, int sebesseg, int kor, int lepes) : base(sorszam, sebesseg, kor, lepes)
        {
            this.sorszam = sorszam;
            this.sebesseg = sebesseg;
            this.kor = kor;
            this.lepes = lepes;
        }

        public void Ordítás()
        {
          
        }

    }
}