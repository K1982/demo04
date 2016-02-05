using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Tavarat
    {
        public string Nimi { get; set; }
        public string Väri { get; set; }

        public Tavarat()
        {
        }

        public Tavarat(string nimi, string väri)
        {
            nimi = Nimi;
            väri = Väri;
        }

        public override string ToString()
        {
            return "Nimi : " + Nimi + "Väri : " + Väri;
        }

    }
}
