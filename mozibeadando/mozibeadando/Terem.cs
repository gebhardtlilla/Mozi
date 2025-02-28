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

        /// <summary>
        /// A teremhez hozzárendeli a nevét és azt hogy hány férőhely van benne. (A terem neveit már a musorlista osztályba hoztuk létre.)
        /// </summary>
        /// <param name="nev">A terem neve(terem1, terem2, terem3)</param>
        public Terem(string nev)
        {
            this.Nev = Nev;
            Ferohely = 80;
        }
    }
}
