// See https://aka.ms/new-console-template for more information
using ClassApplication;

var StudentConsole = new StudentConsole();

while (true)
{
    Console.WriteLine("Please choose command: Create, List, Choose, Delete, Update, BestAverage, BestOfBest, BestAverageClass");
    var command = Console.ReadLine();

    switch (command)
    {
        case "Create":
            StudentConsole.Create();
            break;

        case "List":
            StudentConsole.List();
            break;

        case "Choose":
            StudentConsole.Choose();
            break;

        case "Delete":
            StudentConsole.Delete();
            break;
        case "Update":
            StudentConsole.Update();
            break;
        case "BestAverage":
            Console.WriteLine("Please enter class: math or biology");
            string lessonName = Console.ReadLine();
            StudentConsole.BestAverage(StudentConsole.students, lessonName);
            break;
        case "BestOfBest":
            StudentConsole.BestOfBest();
            break;
        case "BestAverageClass":
            Console.WriteLine("Please enter class: math or biology");
            string lessonName1 = Console.ReadLine();
            Console.WriteLine("Please enter class: 1 or 2");
            int classgrade = Convert.ToInt32(Console.ReadLine());
            StudentConsole.BestAverageClass(StudentConsole.students, lessonName1, classgrade);
            break;

        default:
            Console.WriteLine("Command was not recognised, please try again");
            break;
         
    }

}

