using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Elektroniikka : Tavarat
    {
        public string Merkki { get; set; }

        public Elektroniikka()
        {
        }

        public Elektroniikka(string merkki)
        {
            merkki = Merkki;
        }

        public override string ToString()
        {
            return base.ToString() + " " + Merkki;
        }
    }
}
