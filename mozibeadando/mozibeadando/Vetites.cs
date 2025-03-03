using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mozizas
{
    public class Vetites:IVetites
    {
        public Film FilmCim { get; set; }
        public DateTime Idopont { get; set; }
        public Terem Terem { get; set; }

        /// <summary>
        /// A vetítés konstruktor meghatározza, hogy a filmeket milyen időpontba fogják játszani és hogy melyik terembe.
        /// </summary>
        /// <param name="film">A film címe.</param>
        /// <param name="idopont">Az időpont, hogy mikor játszák az adott filmet.</param>
        /// <param name="terem">A terem, hogy melyik terembe fogják vetíteni a filmet.</param>
        public Vetites(Film FilmCim, DateTime Idopont, Terem Terem)
        {
            this.FilmCim = FilmCim;
            this.Idopont = Idopont;
            this.Terem = Terem;
        }
        
    }
}
