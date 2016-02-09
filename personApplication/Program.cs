using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // create one student object
            Student student = new Student("Kirsi","Kernel","Piippukatu 2","K8989");
            Console.WriteLine("Student = " + student.ToString());
            student.StudentMethod();
            student.PersonMethod();

            // create one teacher object
            Teacher teacher = new Teacher("Teppo","Terävä","Kielokuja 2","D566");
            Console.WriteLine("Teacher = " + teacher.ToString());
            teacher.TeacherMethod();
            teacher.PersonMethod();

            Console.ReadLine();
        }
    }
}
