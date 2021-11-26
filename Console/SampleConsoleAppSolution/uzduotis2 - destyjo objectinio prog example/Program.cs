using System;
using System.Collections.Generic;

namespace _19gr2
{
    class Program
    {
        static void Main(string[] args)
        {

            Student studentas0 = new Student(30, "Kaunas");

            Student studentas = new Student();
            studentas.Name = "Petras";
            studentas.Surname = "Adomaitis";
            studentas.Age = 19;

            //Console.WriteLine(studentas);

            Student studentas2 = new Student();
            studentas2.Name = "Petras2";
            studentas2.Surname = "Adomaitis2";
            studentas2.Age = 192;

            //Console.WriteLine(studentas2.ToString());

            List<Student> students = new List<Student>() { studentas, studentas0, studentas2 };

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

        }

        public static void sayHi()
        {
            Console.WriteLine("helleu");
        }

        public static string returnHi()
        {
            return "Hi";
        }


        public static void sayHiP(string name)
        {
            Console.WriteLine("helleu " + name);
        }

        public static string returnHiP(string name)
        {
            return "Hi " + name;
        }
    }
}