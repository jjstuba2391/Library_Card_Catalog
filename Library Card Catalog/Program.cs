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
            Book book1 = new Book("CodingTempleWork", "Adrian/Jake", "Non-Fiction");

            Stream stream = File.Open("BookData.dat", FileMode.Create);

            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(stream, book1);
        }
    }
    [Serializable()] // <---attribute
    class Book : ISerializable // <---interface
    {
        //Contains properties of books
        //  Title, Author, other properties
        public string Title = "";
        public string Author = "";
        public string Genre = "";
        
       
    
        public Book(SerializationInfo info, StreamingContext context)// <----constructor
        {
            Title = (string)info.GetValue("", typeof(string));
            Author = (string)info.GetValue("", typeof(string));
            Genre = (string)info.GetValue("", typeof(string));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("", Title);
            info.AddValue("", Author);
            info.AddValue("", Genre);
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
