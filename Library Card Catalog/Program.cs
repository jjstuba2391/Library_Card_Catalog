using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace Library_Card_Catalog
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection = 0;
            while (selection != 3)
            {
                Console.WriteLine("Welcome to the our Library!\n");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1 - List all books");
                Console.WriteLine("2 - Add a book");
                Console.WriteLine("3 - Save and Exit");

                selection = Convert.ToInt32(Console.ReadLine());

                switch (selection)
                {
                    case 1:
                        // CardCatalog.ListBooks();
                        break;

                    case 2:
                        Console.WriteLine("Enter Title of New Book");
                        string title = Console.ReadLine();

                        Console.WriteLine("Enter Author of '{0}'", title);
                        string author = Console.ReadLine();

                        Console.WriteLine("Enter Genre of '{0}'", title);
                        string genre = Console.ReadLine();

                        CardCatalog.AddBook(title, author, genre);
                        break;
                    case 3:
                        CardCatalog.SaveAndExit();
                        break;
                    default:
                        Console.WriteLine("Invalid Input. Restarting Program.");
                        Console.WriteLine("************************************\n");
                        break;

                }
            }    
        }
    }
}


