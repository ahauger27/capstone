using System;

namespace Capstone.Models;

public class Patron
{
    public string FirstName { get; private set; } = string.Empty;
    public string LastName { get; private set; } = string.Empty;
    public string MiddleInitial { get; private set; }
    public List<IItem> ActiveLoans { get; set; } = [];

    
    public Patron(string firstName, string lastName, string middleInitial = "")
    {
        FirstName = firstName;
        MiddleInitial = middleInitial;
        LastName = lastName;
    }

    public string FullName()
    {
        if (string.IsNullOrEmpty(MiddleInitial))
        {
            return $"{FirstName} {LastName}";
        }
        else
        {
            return $"{FirstName} {MiddleInitial} {LastName}";
        }
    }

    public void DisplayPatronName()
    {
        Console.WriteLine($"Patron Name: {FullName()}");
    }

    public void DisplayActiveLoans()
    {
        if (ActiveLoans.Count == 0)
        {
            Console.WriteLine($"{FullName()} has no current loans.");
        }
        else
        {
            Console.WriteLine($"{FullName}'s current loans:");
        }
    }
}
