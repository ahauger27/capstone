using System;

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

    public string PrintPatronName()
    {
        return $"{FullName()}";
    }

    public void DisplayActiveLoans()
    {
        if (ActiveLoans.Count == 0)
        {
            Console.WriteLine($"{PrintPatronName()} has no current loans.");
        }
        else
        {
            Console.WriteLine($"{PrintPatronName()}'s current loans:");
            foreach (IItem item in ActiveLoans)
            {
                Console.WriteLine($"-{item.Title}");

            }
        }
    }
}
