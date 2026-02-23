using System;

namespace Capstone.Models;

public class Book : IItem
{
    public string Title { get; set; } = string.Empty;
    public Patron? CurrentBorrower { get; set; }
    public void DisplayTitle()
    {
        Console.WriteLine($"Title: {Title}");
    }
}
