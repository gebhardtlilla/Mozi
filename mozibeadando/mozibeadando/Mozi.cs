using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mozizas
{
    public class Mozi
    {
        public List<Film> filmek = Filmfajlkezelo.FilmBeolvasas("movies.txt");
        public MusorLista musorlista = new MusorLista();
        public void feladat()
        {
            musorlista.musorlistaGeneral();
            
        }
        public List<Film> katSzures(string kategoria)
        {
            return filmek.Where(f => f.Kategoria == kategoria).ToList();
        }

        public List<Film> vetSzures(DateTime idopont)
        {
            return filmek.Where(f => f.Ev == idopont.Year).ToList();
        }




    }
}
