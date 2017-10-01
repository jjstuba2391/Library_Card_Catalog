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
    [Serializable()]
    public class Book : ISerializable
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }

        public Book(string title, string author, string genre)
        {
            Title = title;
            Author = author;
            Genre = genre;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Title", Title);
            info.AddValue("Author", Author);
            info.AddValue("Genre", Genre);
        }

        public Book(SerializationInfo info, StreamingContext context)
        {
            Title = (string)info.GetValue("Title", typeof(string));
            Author = (string)info.GetValue("Author", typeof(string));
            Genre = (string)info.GetValue("Genre", typeof(string));
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
        public static void Listbooks()
        {

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("MyFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            Book book1 = (Book)formatter.Deserialize(stream);
            stream.Close();

            Console.WriteLine("Title: {0}", book1.Title);
            Console.WriteLine("Author: {0}", book1.Author);
            Console.WriteLine("Genre: {0}", book1.Genre);

        }
        public static void AddBook(string title, string author, string genre)
        {
            Book book1 = new Book(title, author, genre);
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, book1);
            stream.Close();

            Console.WriteLine("Book added"); //returns to main menu
        }
        public static void SaveAndExit()
        {
            //adding to list
            Console.WriteLine("Book Saved. Good Bye!");
        }
    }
}


