using System;
using Capstone.Models;

namespace Capstone
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("welcome to library management system");

            Patron patron1 = new Patron(firstName : "Jim", lastName : "Halpert");
            patron1.DisplayPatronName();

            patron1.DisplayActiveLoans();

            // Book book = new Book();
        }
    }
}