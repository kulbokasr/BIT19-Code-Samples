// See https://aka.ms/new-console-template for more information
using ClassApplication;

var studentConsole = new StudentConsole(); //mazoji raide

while (true)
{
    Console.WriteLine("Please choose command: Create, List, Choose, Delete, Update, BestAverage, BestOfBest, BestAverageClass");
    var command = Console.ReadLine();

    switch (command) //pavadinimai su veiksmazodziu ir aiskesni
    {
        case "Create":
            studentConsole.Create();
            break;
        case "List":
            studentConsole.List();
            break;
        case "Choose":
            studentConsole.Choose();
            break;
        case "Delete":
            studentConsole.Delete();
            break;
        case "Update":
            studentConsole.Update();
            break;
        case "BestAverage":
            Console.WriteLine("Please enter class: math or biology");
            string lessonName = Console.ReadLine();
            studentConsole.BestAverage(studentConsole.students, lessonName);
            break;
        case "BestOfBest":
            studentConsole.BestOfBest();
            break;
        case "BestAverageClass":
            Console.WriteLine("Please enter class: math or biology");
            string lessonName1 = Console.ReadLine();
            Console.WriteLine("Please enter class: 1 or 2");
            int classgrade = Convert.ToInt32(Console.ReadLine());
            studentConsole.BestAverageClass(studentConsole.students, lessonName1, classgrade);
            break;

        default:
            Console.WriteLine("Command was not recognised, please try again");
            break;
         
    }

}

