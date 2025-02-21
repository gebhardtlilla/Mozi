using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mozi
{
    internal class Filmek
    {
        public string magyarcim, angolcim; //mufaj, mufaj2, mufaj3;
        public int ido, kiadasev;
        List<string> mufajok = new List<string>();

        public Filmek(string sor)
        {
            //Tenet; Tenet; Akció, Sci-Fi, Thriller; 150; 2020
            string[] st = sor.Split(';');
            magyarcim = st[0];
            angolcim = st[1];
            mufajok = st[2].Split(',').ToList();
            ido = Convert.ToInt32(st[5]);
            kiadasev = Convert.ToInt32(st[6]);
        }
    }
}
