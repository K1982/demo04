using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            int valinta = 0;
            Elevator elevator = new Elevator();
            do
            {
                Console.WriteLine("Elevator is now in floor : " + elevator.ToString());
                Console.WriteLine("Give a new floor number (1-5) ");
                valinta = int.Parse(Console.ReadLine());
                elevator.Floor = valinta;
            }
            while (valinta != 999);
        }
    }
}
