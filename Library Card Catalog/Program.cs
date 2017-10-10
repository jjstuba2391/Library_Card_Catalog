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

            Console.WriteLine("Enter File Name: ");
            string fileName = Console.ReadLine();
            CardCatalog cc = new CardCatalog(fileName);

            string selection = "0";
            while (selection != "3")
            {
                Console.Clear();
                Console.WriteLine("\n****************************");
                Console.WriteLine("Welcome to the our Library!");
                Console.WriteLine("****************************\n");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("\t1 - List all books");
                Console.WriteLine("\t2 - Add a book");
                Console.WriteLine("\t3 - Save and Exit");

                selection = Console.ReadLine();

                switch (selection)
                {
                    case "1":
                        cc.ListBooks();
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("Enter Title of New Book");
                        string title = Console.ReadLine();

                        Console.WriteLine("Enter Author of '{0}'", title);
                        string author = Console.ReadLine();

                        Console.WriteLine("Enter Genre of '{0}'", title);
                        string genre = Console.ReadLine();

                        cc.AddBook(title, author, genre);
                        Console.Clear();
                        Console.WriteLine("Book Added. Press any key to continue...");
                        break;

                    case "3":
                        cc.SaveAndExit();
                        break;
                    default:
                        Console.WriteLine("Invalid Input. Restarting Program.");
                        Console.WriteLine("**********************************\n");
                        break;

                }
            }
        }
    }
}


