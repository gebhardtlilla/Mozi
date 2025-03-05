using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mozizas
{
    public class Fajlbeolvasas
    {

        /// <summary>
        /// Beolassa a filmek filet, majd elemei a konstruktor alapjan feltolti a Film tipusu filmek listaba.
        /// </summary>
        /// <param name="path">A megadott utvonala a beolvasando filenak.</param>
        /// <returns>Visszaadja a filmek listat a feltoltott elemekkel.</returns>
        public static List<Film> FilmBeolvasas(string path)
        {
            List<Film> filmek = new List<Film>();
            StreamReader f = new StreamReader(path);
            while (!f.EndOfStream)
            {
                string[] st = f.ReadLine().Split(';');
                string sv = st[3].Replace(" ", "");
                string[] szereplok = sv.Split(',');
                filmek.Add(new Film(st[0], st[6], st[2], st[5], Convert.ToInt32(st[1]), szereplok, Convert.ToInt32(st[4]), st[7]));
            }
            return filmek;
        }
    }
}
