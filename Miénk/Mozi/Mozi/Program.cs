using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Mozi
{
    internal class Program
    {
        static List<Filmek> filmek = new List<Filmek>();

        static void Main(string[] args)
        {
            Fajlbeolvasas();
           
            Fajlkiiratas();

            Console.ReadLine();
        }

        static void Fajlkiiratas()
        {
            for (int i = 0; i < filmek.Count; i++)
            {
                Console.WriteLine(filmek[i].ora);
            }
        }

        static void Fajlbeolvasas()
        {
            StreamReader sr = new StreamReader("filmek.txt");
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                Filmek sv = new Filmek(sr.ReadLine());
                filmek.Add(sv);
            }
            sr.Close();

        }

        static void Fajlbeolvasasnap()
        {
            StreamReader sr = new StreamReader("napok.txt");
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                Filmek sv = new Filmek(sr.ReadLine());
                filmek.Add(sv);
            }
            sr.Close();

        }

        
    }
}
