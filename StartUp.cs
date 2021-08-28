using BookSystem.Data;
using BookSystem.Models;
using BookSystem.Services;
using System;

namespace BookSystem
{
    public class StartUp
    {

        private BookService _bookService;
        public void Start() {

            BuildConsoleUi();
        }


        public void BuildConsoleUi()
        {

            BookDbContext context = new BookDbContext();
            _bookService = new BookService(context);

            Console.WriteLine("-------------------Welcome in our book library system-------------------");
            Console.WriteLine("MENU:");
            Console.WriteLine();
            Console.WriteLine("1. Create book");
            Console.WriteLine("2. Get book");
            Console.WriteLine("3. Get all books");
            Console.WriteLine("4. Update book");
            Console.WriteLine("5. Delete book");

            //To do switch statement for calling of particular functions
            
        }


        private void CreateBook()
        {
            Book book = new Book();
            Console.WriteLine("Type book name: ");
            book.Name = Console.ReadLine();
            Console.WriteLine("Type book Description: ");
            book.Description = Console.ReadLine();
            Console.WriteLine("Type book genre: ");
            book.Genre = Console.ReadLine();
            Console.WriteLine("Type book author: ");
            book.Author = Console.ReadLine();
            Console.WriteLine("Type book year: ");
            book.Year = int.Parse(Console.ReadLine());
            Console.WriteLine("Type book name: ");
            book.Price = decimal.Parse(Console.ReadLine());

            _bookService.CreateBook(book);
        }
    }
}
