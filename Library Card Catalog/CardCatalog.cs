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
        private List<Book> books;
        private string _filename;

        public CardCatalog(string fileName)
        {
            _filename = fileName;
            if (File.Exists(fileName))
            {
                Stream stream = new FileStream(_filename, FileMode.Open, FileAccess.Read, FileShare.Read);
                IFormatter formatter = new BinaryFormatter();
                books = (List<Book>)formatter.Deserialize(stream);
            }
            else
            {
                books = new List<Book>();
            }
        }
        public void AddBook(string title, string author, string genre)
        {
            Book newBook = new Book
            {
                Title = title,
                Author = author,
                Genre = genre
            };
        books.Add(newBook);
        }
        public void ListBooks()
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
                stream.Close();
            }
            Console.WriteLine("No More Entries.\nReturning to Menu...");
        }
        public void SaveAndExit()
        {
            //Serializer
            Stream stream = new FileStream(this._filename, FileMode.Create, FileAccess.Write, FileShare.None);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, this.books);         
            stream.Close();
            stream.Dispose();
            Console.WriteLine("Book(s) Saved. Good Bye!");
            Console.ReadLine();
        }
    }
}
