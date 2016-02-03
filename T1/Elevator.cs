using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Elevator
    {
        private readonly int minFloor = 0;
        private readonly int maxFloor = 5;

        private int floor;

        public int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Too small floor!");
                    floor = minFloor;
                }
                else if (value > maxFloor)
                {
                    Console.WriteLine("Too big floor!");
                    floor = maxFloor;
                }
            }
        }

    }
}
