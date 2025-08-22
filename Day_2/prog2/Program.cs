using System;

class Book
{
    // Properties
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    // Constructor
    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Input from user
        Console.WriteLine("Enter book's title:");
        string title = Console.ReadLine();

        Console.WriteLine("Enter book's author:");
        string author = Console.ReadLine();

        Console.WriteLine("Enter book's year:");
        int year = Convert.ToInt32(Console.ReadLine());

        // Create instance of Book class
        Book book = new Book(title, author, year);

        // Display book information
        Console.WriteLine("Book Title: " + book.Title);
        Console.WriteLine("Book Author: " + book.Author);
        Console.WriteLine("Book Year: " + book.Year);
    }
}
