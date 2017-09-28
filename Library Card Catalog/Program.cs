using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        } 
    }
    public class Book
    {
        //Contains properties of books
        //  Title, Author, other properties
    }
    public class CardCatalog
    {
        //Logic goes here
        private string _filename;
        private string books;
        public CardCatalog(string fileName)
        {
            _filename = fileName;
        }
        public void Listbooks()
        {// funtion to list all books

        }
        public AddBook(string author, string title, string genre)
        {
            //function to add all books
        }
        public Save()
        {
            //adding to list
        }
    }
}
