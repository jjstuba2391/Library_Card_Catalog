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
        //Logic goes here
        private string _filename;
        private string _books;
        public CardCatalog(string fileName)
        {
            _filename = fileName;
        }
        public void Listbooks()
        {

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("MyFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            Book book = (Book)formatter.Deserialize(stream);
            stream.Close();

            Console.WriteLine("Title: {0}", book.Title);
            Console.WriteLine("Author: {0}", book.Author);
            Console.WriteLine("Genre: {0}", book.Genre);

        }
        public static void AddBook(string title, string author, string genre)
        {
            Book book = new Book(title, author, genre);
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, book);
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
