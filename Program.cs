using System;
using Capstone.Models;

namespace Capstone
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("welcome to library management system");

            List<Patron> patronList = new List<Patron>()
            {
                new Patron(firstName : "Jim", lastName : "Halpert"),
                new Patron(firstName : "Pam", lastName : "Beesly"),
                new Patron(firstName : "Dwight", lastName : "Schrute", middleInitial : "K"),
                new Patron(firstName : "Michael", lastName : "Scott", middleInitial : "G"),
                new Patron(firstName : "Stanley", lastName : "Hudson"),
                new Patron(firstName : "Kevin", lastName : "Malone"),
                new Patron(firstName : "Oscar", lastName : "Martinez"),
                new Patron(firstName : "Angela", lastName : "Martin"),
                new Patron(firstName : "Creed", lastName : "Bratton"),
                new Patron(firstName : "Kelly", lastName : "Kapoor"),
                new Patron(firstName : "Andy", lastName : "Bernard"),
                new Patron(firstName : "Toby", lastName : "Flenderson"),
                new Patron(firstName : "Phyllis", lastName: "Lapin"),
                new Patron(firstName : "Meredith", lastName : "Palmer"),
                new Patron(firstName : "Ryan", lastName : "Howard"),
                new Patron(firstName : "Darryl", lastName : "Philbin"),
                new Patron(firstName : "Roy", lastName : "Anderson"),
                new Patron(firstName : "Erin", lastName : "Hannon"),
                new Patron(firstName : "Karen", lastName : "Filippelli"),
                new Patron(firstName : "Gabe", lastName : "Lewis"),
                new Patron(firstName : "Robert", lastName : "California"),
                new Patron(firstName : "Holly", lastName : "Flax"),
                new Patron(firstName : "Jan", lastName : "Levinson")
            };

            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. List all patrons");
            Console.WriteLine("2. Search patrons by name (WIP)");
            
            string? userChoice = Console.ReadLine();

            if (userChoice != null || userChoice != string.Empty)
            {
                switch (userChoice)
                {
                    case "1":
                        ListAllPatrons(patronList);
                        // foreach (var patron in patronList)
                        // {
                        //     patron.DisplayPatronName();
                        // }
                        break;
                    case "2":
                        Console.WriteLine("This feature is still in progress");
                        break;
                    default:
                        break;
                } 
            } 


        }

    public static void ListAllPatrons(List<Patron> patronList)
        {
            Console.WriteLine($"{Environment.NewLine}Patrons:");
            Console.WriteLine("\tNAME");
            
            int i = 0;
            foreach (var patron in patronList)
            {
                Console.WriteLine($"{++i:D3} \t{patron.LastName}, {patron.FirstName}");
            }
        }
    }
}