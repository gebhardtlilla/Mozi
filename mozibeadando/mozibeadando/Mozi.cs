using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mozizas
{
    public class Mozi
    {
        List<Film> filmek = Filmfajlkezelo.FilmBeolvasas("movies.txt");
        MusorLista musorlista = new MusorLista();
        public void feladat()
        {
            musorlista.musorlistaGeneral();
            
        }
        public List<Film> katSzures(string sv)
        {
            List<Film> svfilmek = new List<Film>();
            return svfilmek;
        }
        public List<Film> vetSzures(DateTime sv)
        {
            List<Film> svfilmek = new List<Film>();
            return svfilmek;
        }
        
        
    }
}
