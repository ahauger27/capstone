using System;

namespace Capstone.Models;

public class Book : IItem
{
    public string Title { get; set; } = string.Empty;
    public string AuthorName { get; set; } = string.Empty;
    public Collection Genre { get ; set;}
    public BookFormat Format { get; set; }
    public Patron? CurrentBorrower { get; set; }
    public CircStatus CircStatus { get; set; } = CircStatus.In;
    public DateTime LastCirculation { get; set; }
    public DateTime DueDate { get; set; }

    public Book(string title, string author, Collection genre, BookFormat format)
    {
        Title = title;
        AuthorName = author;
        Genre = genre;
        Format = format;
    }

    public void DisplayTitle()
    {
        Console.WriteLine($"Title: {Title}");
    }
}
