﻿using System;
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
            Console.WriteLine("Welcome to the our Library!\n");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1 - List all books");
            Console.WriteLine("2 - Add a book");
            Console.WriteLine("3 - Save and Exit");

            int selection = Convert.ToInt32(Console.ReadLine());

            //switch (selection)
            //{
            //    case 1:
            //        CardCatalog.ListBooks();
            //    case 2:
            //        CardCatalog.AddBook();
            //    case 3:
            //        SaveAndExit ??;
            //    default:
            //        Console.WriteLine("Invalid Input");
            //        //Returns to Main Menu
            //}

        }
    }
    public class Book
    {
        //Contains properties of books
        //  Title, Author, other properties
        private string Title = "";
        private string Author = "";
        private string Genre = "";
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
