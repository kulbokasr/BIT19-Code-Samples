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

            var gradesMath = new List<int>();
            for (int i = 0; i < 7; i++)
            {
                gradesMath.Add(rand.Next(1, 11));
            }
            var gradesBiology = new List<int>();
            for (int i = 0; i < 7; i++)
            {
                gradesBiology.Add(rand.Next(1, 11));
            }
            var grades = new Grade();
            grades.Math = gradesMath;
            grades.Biology = gradesBiology;
            var student = new Student(name, surname, grades);
            students.Add(student);

        }
        public void List()
        {
            foreach (var student in students)
                Console.WriteLine($"Id: {student.Id}, vardas: {student.Name}, pavarde: {student.Surname}, klase: {student.ClassGrade}");
        }

        public void Choose()
        {
            Console.WriteLine("Please enter id of the student to see grades");
            try
            {
                var stId = Convert.ToInt32(Console.ReadLine());
                var student = students.FirstOrDefault(x => x.Id == stId);
                {
                    Console.WriteLine("Biologija");
                    student.grade.Biology.ForEach(i => Console.WriteLine(i));
                    Console.WriteLine("Vidurkis: " + student.grade.Biology.Average());
                    Console.WriteLine("Matematika");
                    student.grade.Math.ForEach(i => Console.WriteLine(i));
                    Console.WriteLine("Vidurkis: " + student.grade.Math.Average());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Wrong input");
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
                    var studentN = students.FirstOrDefault(x => x.Id == upId);
                    {
                        studentN.Name = newName;
                    }
                    break;
                case "surname":
                    Console.WriteLine("Please enter new surname");
                    var newSurname = Console.ReadLine();
                    var studentS = students.FirstOrDefault(x => x.Id == upId);

                    {
                        studentS.Surname = newSurname;
                    }
                    break;
            }

        }
        public void BestAverage(List<Student> students, string lessonName)
        {
            Student studentBest;

            if (lessonName == "math")
            {
                studentBest = students.OrderByDescending(x => x.grade.Math.Average()).First();
            }
            else
            {
                studentBest = students.OrderByDescending(x => x.grade.Biology.Average()).First();
            }
            Console.WriteLine($"Best student in {lessonName} is {studentBest.Name}");

        }
        public void BestOfBest()
        {
            Student bestStudent = students.OrderByDescending(s => s.grade.Math.Average() + s.grade.Biology.Average()).First();
            Console.WriteLine($"Student which has best sum average is {bestStudent.Name}");
        }
        public void BestAverageClass(List<Student> students, string lessonName, int classgrade)
        {
            List<Student> bestStudents = new List<Student>();

            bestStudents.AddRange(students.Where(students => students.ClassGrade == classgrade));

            Student studentBest;

            if (lessonName == "math")
            {
                studentBest = bestStudents.OrderByDescending(x => x.grade.Math.Average()).First();
            }
            else
            {
                studentBest = bestStudents.OrderByDescending(x => x.grade.Biology.Average()).First();
            }
            Console.WriteLine($"Best student in {lessonName} is {studentBest.Name}");

        }

    }
}
