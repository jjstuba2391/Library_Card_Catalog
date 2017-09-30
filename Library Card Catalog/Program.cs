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
            //When user enters filename, presented with options:
            //1. List All Books
            //2. Add a Book
            //3. Save and Exit
            //  Re-display Menu until 'Save and Exit' is chosen.
            Console.WriteLine("Welcome to the our Library!\n");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1 - List all books");
            Console.WriteLine("2 - Add a book");
            Console.WriteLine("3 - Save and Exit");

            int selection = Convert.ToInt32(Console.ReadLine());

            /*
            switch (selection)
            {
                case 1:
                    CardCatalog.ListBooks();
                    break;
                case 2:
                    CardCatalog.AddBook();
                    break;
                case 3:
                    SaveAndExit();
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
                    //Returns to Main Menu
            }
            */

            Book Book1 = new Book();
            Book1.Title = "CodingTempleCatalog";
            Book1.Author = "Adrian/Jake";
            Book1.Genre = "Informative";
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("MyFile.bin",
                                     FileMode.Create,
                                     FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, Book1);
            stream.Close();


            /* This is the process to Derseraialize the information back to the user, but im not sure where this is supposed to go yet. 
             * 
            IFormatter formatter = new BinaryFormatter();  
            Stream stream = new FileStream("MyFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read);  
            Book Book1 = (Book) formatter.Deserialize(stream);  
            stream.Close();  
             
            Console.WriteLine("Title: {0}", Book1.Title);  
            Console.WriteLine("Author: {0}", Book1.Author);  
            Console.WriteLine("Genre: {0}", Book1.Genre);
          
            */

        }
    }
    [Serializable]
    public class Book
    {
        public string Title = null;
        public string Author = null;
        public string Genre = null;
    }

}

public class CardCatalog
{
    //Logic goes here
    private string _filename;
    private string _books;
    public CardCatalog(string fileName)
    {
        _filename = fileName;
    }
    public void Listbooks()
    {
        // funtion to list all books
    }
    public AddBook(string author, string title, string genre)
    {
        //function to add all books
        Console.WriteLine("Book added"); //returns to main menu
    }
    public Save()
    {
        //adding to list
        Console.WriteLine("Book Saved"); //returns to main menu
    }
}

}
