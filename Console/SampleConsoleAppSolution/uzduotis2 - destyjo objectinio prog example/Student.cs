using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19gr2
{
    class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string address { get; set; }

        public int Grade { get; set; }
        public Student()
        {
        }
        public Student(int age, string address, string surname = "doe", string name = "john")
        {
            Name = name;
            Surname = surname;
            Age = age;
            this.address = address;
            this.Grade = 1;
        }

        public Student(string name, string surname, string address, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
            this.address = address;
        }

        public override string ToString()
        {
            return "Studento vardas yra " + Name + ", pavarde " + Surname + ", amzius " + Age;
        }

        public static void sayBie()
        {
            Console.WriteLine("bubbie");
        }
    }
}