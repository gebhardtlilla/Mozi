using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mozizas
{
    public class Film:IFilm
    {
        public string Nev { get; set; }
        public string Kategoria { get; set; }
        public string Rendezo { get; set; }
        public string Leiras { get; set; }
        public int Ido { get; set; }
        public string[] Szereplok { get; set; }
        public int Ev { get; set; }

        /// <summary>
        /// A filmeket tartalmazó file-ból beolvasandó paraméterek definiálása, getter, settereik
        /// beállításával. 
        /// </summary>
        /// <param name="nev">A film teljes neve</param>
        /// <param name="kategoria">A film kategóriája</param>
        /// <param name="rendezo">A film rendezője</param>
        /// <param name="leiras">A film leírása</param>
        /// <param name="ido">A film hossza (percben)</param>
        /// <param name="szereplok">A film szereploi</param> 
        /// <param name="ev">A film megjelenesi eve</param>
        public Film(string nev, string kategoria, string rendezo, string leiras, int ido, string[] szereplok, int ev)
        {
            Nev = nev;
            Kategoria = kategoria;
            Rendezo = rendezo;
            Leiras = leiras;
            Ido = ido;
            Szereplok = szereplok;
            Ev = ev;
        }

        /// <summary>
        /// Egy erteket stringkent atkonvertalva adja vissza.
        /// </summary>
        /// <returns>A film neve, ideje, megjelenesenek evet visszaadja stringkent</returns>
        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}", Nev, Ido, Ev);
        }


    }
}
