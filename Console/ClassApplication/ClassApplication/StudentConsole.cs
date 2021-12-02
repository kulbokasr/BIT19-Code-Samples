using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassApplication
{
    public class StudentConsole
    {
        public List<Student> students = new List<Student>();
        public void Create()
        {
            Random rand = new Random();
            Console.WriteLine("Please enter student name");
            var name = Console.ReadLine();
            Console.WriteLine("Please enter student surname");
            var surname = Console.ReadLine();
            var grades1 = new List<int>();
            for (int i = 0; i < 7; i++)
            {
                grades1.Add(rand.Next(1, 11));
            }
            var grades2 = new List<int>();
            for (int i = 0; i < 7; i++)
            {
                grades2.Add(rand.Next(1, 11));
            }
            var grades = new Grade();
            grades.math = grades1;
            grades.biology = grades2;
            var student = new Student(name, surname, grades);
            students.Add(student);

        }
        public void List()
        {
            foreach (var student in students)
                Console.WriteLine(student.Name + " " + student.Surname + " " + student.Id);
        }

        public void Choose()
        {
            Console.WriteLine("Please enter id of the student to see grades");
            var stId = Convert.ToInt32(Console.ReadLine());
            foreach (var student in students)
                if (student.Id == stId)
                {
                    Console.WriteLine("Biologija");
                    student.grade.biology.ForEach(i => Console.WriteLine(i));
                    Console.WriteLine("Vidurkis: " + student.grade.biology.Average());
                    Console.WriteLine("Matematika");
                    student.grade.math.ForEach(i => Console.WriteLine(i));
                    Console.WriteLine("Vidurkis: " + student.grade.math.Average());
                }

        }
        public void Delete()
        {
            Console.WriteLine("Please enter id of the student you want to delete");
            var delId = Convert.ToInt32(Console.ReadLine());
            var delStudent = students.Single(x => x.Id == delId);
            students.Remove(delStudent);
        }

        public void Update()
        {
            Console.WriteLine("Please enter id of the student you want to update");
            var upId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter what you want to update: name or surname");
            var command = Console.ReadLine();
            switch (command)
            {
                case "name":
                    Console.WriteLine("Please enter new name");
                    var newName = Console.ReadLine();
                    foreach (var student in students)
                        if (student.Id == upId)
                        {
                            student.Name = newName;
                        }
                    break;
                case "surname":
                    Console.WriteLine("Please enter new surname");
                    var newSurname = Console.ReadLine();
                    foreach (var student in students)
                        if (student.Id == upId)
                        {
                            student.Surname = newSurname;
                        }
                    break;
            }

        }
        public void BestAverage(List<Student> students, string lessonName)
        {
            List<double> averages = new List<double>();
            if (lessonName == "math")
            {
                for (int i = 0; i < students.Count; i++)
                {
                    averages.Add(students[i].grade.math.Average());
                }
            }
            else
            {
                for (int i = 0; i < students.Count; i++)
                {
                    averages.Add(students[i].grade.biology.Average());
                }
            }
            Console.WriteLine($"Best student in {lessonName} is {students[averages.IndexOf(averages.Max())].Name}");

        }
        public void BestOfBest()
        {
            List<double> averages = new List<double>();
            for (int i = 0;i < students.Count;i++)
            {
                averages.Add(students[i].grade.math.Average() + students[i].grade.biology.Average());
            }
            Console.WriteLine($"Student which has best sum avarega is {students[averages.IndexOf(averages.Max())].Name}");
        }

    }
}
