using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication35
{
    public class ZsigaCsiga : versenyzők
    {
        public ZsigaCsiga(int sorszam, int sebesseg, int kor, int lepes) : base(sorszam, sebesseg, kor, lepes)
        {
            this.sorszam = sorszam;
            this.sebesseg = sebesseg;
            this.kor = kor;
            this.lepes = lepes;

            Console.Write("Sorszám: ,Sebesség: ,kor: ,lépés: ", sorszam, sebesseg, kor, lepes);
        }

    }
}