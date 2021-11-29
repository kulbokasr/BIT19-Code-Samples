// See https://aka.ms/new-console-template for more information


using BookStoreApplication.Models;
using System.Linq;
using BookStoreApplication;


var books = new List<Book>();

void ListFun(List<Book> books)
{

    Console.WriteLine("Books list:");
    foreach (var book in books)
    {
        Console.WriteLine($"Title: {book.Title}, description: {book.Description}, amount: {book.Amount}");
    }
}


while (true)
{
    var erroras = 0;
    Console.WriteLine("Please choose command: Add, List, Update or Delete");

    var command = Console.ReadLine();
    
    if (command.ToLower() == "Add")
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
        ListFun(books);
    }

    //if (command == "Delete")
    //{
    //    // todos = todos.Where(t => t.Completed == true).ToList();
    //    //Use String.Split
    //    Console.WriteLine("Please provide title of the book you want to delete");
    //    string delName = Console.ReadLine();

      
    //    books.RemoveAll(x => x.Title == delName);

    //}

    if (command == "Update")
    {
        Console.WriteLine("Please provide title of the book you want to change");
        string changeName = Console.ReadLine();
        Console.WriteLine("Please provide new title");
        string newName = Console.ReadLine();

        books.Where(x => x.Title == changeName).ToList().ForEach(x => x.Title = newName);
    }


    if (command.Contains("Delete"))
    {
        string bookName = command.Split("Delete ", StringSplitOptions.None).Last();
        Console.WriteLine(bookName);
        try
        {
            var item = books.Single(x => x.Title.Equals(bookName));
            books.Remove(item);
        }
        catch { Console.WriteLine("No title ..."); }

    }




}

