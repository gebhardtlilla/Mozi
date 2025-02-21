using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mozi
{
    internal class Napok
    {
        public string napok;
        public int nyitas, zaras;

        public Napok(string sor)
        {
           string[] st = sor.Split('-');
            napok = st[0];
            nyitas = Convert.ToInt32(st[1]);
            zaras = Convert.ToInt32(st[2]);
        }
    }
}
