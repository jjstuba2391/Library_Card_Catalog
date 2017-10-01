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

    public class CardCatalog
    {
        public static List<Book> booklist = new List<Book>();
        private string _filename;
        //private string _books;
        public CardCatalog(string fileName)
        {
            _filename = fileName;
        }
        public static void AddBook(string title, string author, string genre)
        {

            Book entry = new Book(title, author, genre);
            booklist.Add(entry);

            Console.WriteLine("Book added. Restart application to see changes!\n"); //returns to main menu
        }
        public static void ListBooks()
        {
            Console.WriteLine("\nBooks Listed:");
            //Deserializer
            using (Stream stream = File.Open("MyFile.bin", FileMode.Open))
            {
                BinaryFormatter bin = new BinaryFormatter();
                var booklist = (List<Book>)bin.Deserialize(stream);

                foreach (Book entry in booklist)
                {
                    Console.WriteLine("\n{0}, by {1}. Genre: {2}\n",
                        entry.Title,
                        entry.Author,
                        entry.Genre);
                }

            }
            Console.WriteLine("No More Entries.\nReturning to Menu...");
        }
        public static void SaveAndExit()
        {
            //Serializer
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, booklist);
            stream.Close();
            Console.WriteLine("Book(s) Saved. Good Bye!");
        }
    }
}
