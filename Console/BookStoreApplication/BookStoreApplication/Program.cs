// See https://aka.ms/new-console-template for more information


using BookStoreApplication.Models;

var books = new List<Book>();

while (true)
{
    var erroras = 0;
    Console.WriteLine("Please choose command: Add, List or Delete");

    var command = Console.ReadLine();
    
    if (command == "Add")
    {
        Console.WriteLine("Please provide title");
        string title = Console.ReadLine();

        foreach (var book1 in books)
        {
            if (book1.Title == title)
                  erroras = 1;
        }

        if (erroras == 1)
        {
            Console.WriteLine("This book already exists in the list");
        }

        else
        { 
        Console.WriteLine("Please provide description");
        string description = Console.ReadLine();
        Console.WriteLine("Please provide amount");
        int amount = Convert.ToInt32(Console.ReadLine());

        var book = new Book(title, description, amount);
        books.Add(book);
        }
    }

    if (command == "List")
    {
        Console.WriteLine("Books list:");
        foreach (var book in books)
        {
            Console.WriteLine($"Title: {book.Title}, description: {book.Description}, amount: {book.Amount}");
        }
    }

    if (command == "Delete")
    {
        // todos = todos.Where(t => t.Completed == true).ToList();
        //Use String.Split
        Console.WriteLine("Please provide title of the book you want to delete");
        string delName = Console.ReadLine();

      
        books.RemoveAll(x => x.Title == delName);

    }

}




