using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo04
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a one car object
            Car car = new Car();
            car.Speed = 10000000;
            Console.WriteLine("Speed is {0}", car.Speed);
            car.Height = 5.0;
            Console.WriteLine("Height is {0}", car.Height);


        }
    }
}
