//using mozibeadando;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mozizas
{
    public class Terem:ITerem
    {
        public string Nev { get; set; }
        public int Ferohely { get; set; }

        public Terem(string nev)
        {
            this.Nev = Nev;
            Ferohely = 80;
        }
    }
}
