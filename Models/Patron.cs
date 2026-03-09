using System;
using System.Security.Cryptography;

namespace Capstone.Models;

public class Patron
{
    public string FirstName { get; private set; } = string.Empty;
    public string LastName { get; private set; } = string.Empty;
    public string MiddleInitial { get; private set; }
    public DateTime DateOfBirth { get; set; }
    public List<IItem> ActiveLoans { get; set; } = [];

    
    public Patron(string firstName, string lastName, DateTime dob, string middleInitial = "")
    {
        FirstName = firstName;
        MiddleInitial = middleInitial;
        LastName = lastName;
        DateOfBirth = dob;
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
    public int DisplayAge()
    {
        DateTime dateNow = DateTime.Now;
        return dateNow.Year - DateOfBirth.Year;
    }

    public void DisplayPatronName()
    {
        Console.WriteLine($"{Environment.NewLine}Patron Name: {FullName()}");
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
