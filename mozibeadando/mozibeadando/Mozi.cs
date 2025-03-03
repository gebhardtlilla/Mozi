using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mozizas
{
    public class Mozi
    {
        public List<Film> filmek = Fajlbeolvasas.FilmBeolvasas("movies.txt");
        public MusorLista musorlista = new MusorLista();
        /// <summary>
        /// Legenerál egy új Musorlista tipusu musorlistat.
        /// </summary>






        
        //public void MusortGeneral() JO LESZ KI KELL SZEDNI A KOMMENTBOL!!
        //{
        //    musorlista.musorlistaGeneralas();

        //}

        /*
        /// <summary>
        /// Megszuri tombfuggveny segitsegevel a parameterben megadott fuggveny (kategoria) alapjan.
        /// </summary>
        /// <param name="kategoria">a film kategoriaja.</param>
        /// <returns>vissza ad egy kategoria szerint megszurt filmek listat.</returns>
        public List<Film> katSzures(string kategoria)
        {
            return filmek.Where(f => f.Kategoria == kategoria).ToList();
        }


        /// <summary>
        /// Megszuri tombfuggveny segitsegevel a parameterben megadott fuggveny (idopont) alapjan.
        /// </summary>
        /// <param name="idopont">a film lejatszasanak idopontja.</param>
        /// <returns>vissza ad egy idopont szerint megszurt filmek listat.</returns>
        public List<Film> vetSzures(DateTime idopont)
        {
            return filmek.Where(f => f.Ev == idopont.Year).ToList();
        }

        */


    }
}
