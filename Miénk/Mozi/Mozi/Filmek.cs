using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mozi
{
    internal class Filmek
    {
        public string magyarcim, angolcim, mufaj, mufaj2, mufaj3;
        public int ido, kiadasev;

        public Filmek(string sor)
        {
            string[] st = sor.Split(';');
            magyarcim = st[0];
            angolcim = st[1];
            mufaj = st[2];
            mufaj2 = st[3];
            mufaj3= st[4];
            ido = Convert.ToInt32(st[5]);
            kiadasev = Convert.ToInt32(st[6]);
        }
    }
}
