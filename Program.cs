using System;
using Capstone.Models;
using Capstone.Services;

namespace Capstone
{
    class Program
    {
        public static void Main()
        {
            Processor run = new Processor();
            run.Start();

            Console.WriteLine("welcome to library management system");

            List<Patron> patronList = new List<Patron>()
            {
                new Patron(firstName : "Jim", lastName : "Halpert", dob : new DateTime(1978, 10, 1)),
                new Patron(firstName : "Pam", lastName : "Beesly", dob : new DateTime(1979, 3, 25)),
                new Patron(firstName : "Dwight", lastName : "Schrute", dob : new DateTime(1970, 1, 20), middleInitial : "K"),
                new Patron(firstName : "Michael", lastName : "Scott", dob : new DateTime(1965, 3, 15), middleInitial : "G"),
                new Patron(firstName : "Stanley", lastName : "Hudson", dob : new DateTime(1951, 7, 14)),
                new Patron(firstName : "Kevin", lastName : "Malone", dob : new DateTime(1968, 6, 1)),
                new Patron(firstName : "Oscar", lastName : "Martinez", dob : new DateTime(1964, 11, 15)),
                new Patron(firstName : "Angela", lastName : "Martin", dob : new DateTime(1974, 11, 11)),
                new Patron(firstName : "Creed", lastName : "Bratton", dob : new DateTime(1925, 11, 1)),
                new Patron(firstName : "Kelly", lastName : "Kapoor", dob : new DateTime(1980, 2, 5)),
                new Patron(firstName : "Andy", lastName : "Bernard", dob : new DateTime(1973, 1, 24)),
                new Patron(firstName : "Toby", lastName : "Flenderson", dob : new DateTime(1963, 2, 22)),
                new Patron(firstName : "Phyllis", lastName: "Lapin", dob : new DateTime(1965, 7, 10)),
                new Patron(firstName : "Meredith", lastName : "Palmer", dob : new DateTime(1959, 11, 12)),
                new Patron(firstName : "Ryan", lastName : "Howard", dob : new DateTime(1979, 5, 5)),
                new Patron(firstName : "Darryl", lastName : "Philbin", dob : new DateTime(1971, 10, 25)),
                new Patron(firstName : "Roy", lastName : "Anderson", dob : new DateTime(1976, 6, 1)),
                new Patron(firstName : "Erin", lastName : "Hannon", dob : new DateTime(1986, 5, 1)),
                new Patron(firstName : "Karen", lastName : "Filippelli", dob : new DateTime(1979, 2, 25)),
                new Patron(firstName : "Gabe", lastName : "Lewis", dob : new DateTime(1982, 3, 23)),
                new Patron(firstName : "Robert", lastName : "California", dob : new DateTime(1971, 4, 17)),
                new Patron(firstName : "Holly", lastName : "Flax", dob : new DateTime(1976, 2, 14)),
                new Patron(firstName : "Jan", lastName : "Levinson", dob : new DateTime(1967, 12, 5))
            };

            List<IItem> itemList = new List<IItem>()
            {
                new Book(title: "The Alchemist", author: "Paulo Coelho", genre: Collection.Fiction, format: Format.Hardcover),
                new Book(title: "The Great Gatsby", author: "F. Scott Fitzgerald", genre: Collection.Fiction, format: Format.Paperback),
                new Book(title: "To Kill a Mockingbird", author: "Harper Lee", genre: Collection.Fiction, format: Format.Audiobook),
                new Book(title: "The Catcher in the Rye", author: "J.D. Salinger", genre: Collection.Fiction, format: Format.LargeType),
                new Book(title: "1984", author: "George Orwell", genre: Collection.ScienceFiction, format: Format.eBook),
                new Book(title: "Fahrenheit 451", author: "Ray Bradbury", genre: Collection.ScienceFiction, format: Format.Paperback)
            };


            Circulation.CheckOutItem(patronList[1], itemList[0]);
            Circulation.CheckOutItem(patronList[3], itemList[0]);

            patronList[1].DisplayActiveLoans();
        }
            /*

            while (run.RunStatus == true)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. List all patrons");
                Console.WriteLine("2. Search patrons by name (WIP)");
                Console.WriteLine("3. Quit program");
                
                string? userChoice = Console.ReadLine();

                if (userChoice != null || userChoice != string.Empty)
                {
                    switch (userChoice)
                    {
                        case "1":
                            ListAllPatrons(patronList);
                            break;
                        case "2":
                            Console.WriteLine("This feature is still in progress");
                            break;
                        case "3":
                            run.End();
                            Console.WriteLine("End program");
                            break;
                        default:
                            break;
                    } 
                } 
            }
        }
        */
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