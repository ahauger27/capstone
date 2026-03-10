using System;
using Capstone.Models;

namespace Capstone.Services;

public static class Circulation
{
    public static void CheckOutItem(Patron patron, IItem item)
    {
        if (item.CircStatus != CircStatus.In)
        {
            Console.WriteLine($"{item.Title} cannot be checked out at this time.");
        }
        else
        {
            item.CircStatus = CircStatus.Out;
            item.CurrentBorrower = patron;
            patron.ActiveLoans.Add(item);
            item.SetDueDate();
            Console.WriteLine($"{item.Title} has been succesfully checked out to {patron.PrintPatronName()}.");
        }
    }
}