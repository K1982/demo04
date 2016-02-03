using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personApplication
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

        public Person()
        {
        }
        public Person(string firstname, string lastname, string address)
        {
            FirstName = firstname;
            LastName = lastname;
            Address = address;
        }

        public void PersonMethod()
        {
            Console.WriteLine("Person does something...");
        }

        public override string ToString()
        {
            // Kirsi Kernel Piippukatu 2 
            return FirstName + " " + LastName + " " + Address;
        }
    }
}
