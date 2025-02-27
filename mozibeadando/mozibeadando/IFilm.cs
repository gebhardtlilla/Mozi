using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mozizas
{
    public interface IFilm
    {
        string Nev { get; set; }
        string Kategoria { get; set; }
        string Rendezo { get; set; }
        string Leiras { get; set; }
        int Ido { get; set; }
        string[] Szereplok { get; set; }
        int Ev { get; set; }
    }
}
