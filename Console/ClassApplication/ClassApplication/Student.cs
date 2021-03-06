using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassApplication
{
    public class Student
    {
        public static int IdCounter { get; set; } = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Grade grade { get; set; }
        public int ClassGrade { get; set; }

        public Student(string name, string surname, Grade grade)
        {
            Random rand = new Random();
            Name = name;
            this.grade = grade;
            Surname = surname;
            Id = ++IdCounter; 
            ClassGrade = rand.Next(1,3);
         }
    }
}
