using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mozizas
{
    public class Vetites:IVetites
    {
        public Film Film { get; set; }
        public DateTime Idopont { get; set; }
        public Terem Terem { get; set; }

        /// <summary>
        /// A vetítés konstruktor meghatározza, hogy a filmeket milyen időpontba fogják játszani és hogy melyik terembe.
        /// </summary>
        /// <param name="film">A film címe.</param>
        /// <param name="idopont">Az időpont, hogy mikor játszák az adott filmet.</param>
        /// <param name="terem">A terem, hogy melyik terembe fogják vetíteni a filmet.</param>
        public Vetites(Film film, DateTime idopont, Terem terem)
        {
            this.Film = Film;
            this.Idopont = Idopont;
            this.Terem = Terem;
        }
        
    }
}
