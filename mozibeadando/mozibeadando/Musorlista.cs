using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Mozizas
{
    public class MusorLista
    {
        public List<Vetites> vetitesek;
        public List<Terem> termek;

        /// <summary>
        /// A musorlista konstruktor létrehoz két listát. Az első a vetítések listája. A második pedig a termeké, ez adja meg a termek nevét.
        /// </summary>
        public MusorLista()
        {
            vetitesek = new List<Vetites>();
            termek = new List<Terem>(){new Terem("1. Terem"), new Terem("2. Terem"), new Terem("3. Terem")};
        }
        public void musorlistaGeneral()
        {
            
        }
        

    }
}
