//using mozibeadando;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mozizas
{
    public class Terem : ITerem
    {
        public string TeremNev { get; set; }
        public int TeremFerohely { get; set; }
        public int TeremHossza { get; set; }
        public int SzekPerSor { get; set; }

        /// <summary>
        /// A teremhez hozzárendeli a nevét, férőhelyét, hosszát és soronkénti székszámát.
        /// </summary>
        /// <param name="TeremNev">A terem neve (pl. terem1, terem2, terem3).</param>
        /// <param name="TeremFerohely"></param>
        /// <param name="TeremHossza"></param>
        /// <param name="SzekPerSor"></param>
        public Terem(string TeremNev, int TeremFerohely, int TeremHossza, int SzekPerSor)
        {
            Random r = new Random();
            this.TeremNev = TeremNev;
            TeremFerohely = r.Next(80, 350);
            TeremHossza = r.Next(15, 30); 
            SzekPerSor = 15;  
        }
    }
}

