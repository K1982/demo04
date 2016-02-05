using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Kirjat : Tavarat
    {
        public string Kirjoittaja { get; set; }
        public string Kustantaja { get; set; }

        public Kirjat()
        {
        }

        public override string ToString()
        {
            return base.ToString() + " Kirjoittaja : " + Kirjoittaja + "Kustantaja" + Kustantaja;
        }

    }
}
