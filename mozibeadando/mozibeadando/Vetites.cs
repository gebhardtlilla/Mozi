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

        public Vetites(Film film, DateTime idopont, Terem terem)
        {
            Film = this.Film;
            Idopont = this.Idopont;
            Terem = this.Terem;
        }
        
    }
}
