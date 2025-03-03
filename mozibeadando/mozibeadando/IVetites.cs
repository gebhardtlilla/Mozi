using Mozizas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mozizas
{
    public interface IVetites
    {
        Film FilmCim { get; set; }
        DateTime Idopont { get; set; }
        Terem Terem { get; set; }
    }
}
