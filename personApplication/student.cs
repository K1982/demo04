using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personApplication
{
    // Student periytyy Person-luokasta
    // Student on aliluokka, Person on yli/kantaluokka
    // Student saa kaikki luokan Person ominaisuuset ja toiminnot
    // - riippuen suojamääreistä
    class Student : Person
    {
        public string StudentID { get; set; }

        public Student()
        {
        }

        public Student(string firstname, string lastname, string address, string studentID)
            : base(firstname,lastname,address)
        {
            StudentID = studentID;
        }

        public void StudentMethod()
        {
            Console.WriteLine("Learning OOP!");
        }

        // ylikirjoitetaan Person-luokassa oleva ToString()-metodi
        public override string ToString()
        {
            //yliluokasta palautuu alku, liitetään siihen Studentin oma ID
            return base.ToString() + " " + StudentID;
        }
    }
}
