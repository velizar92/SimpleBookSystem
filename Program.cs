using BookSystem.Data;
using BookSystem.Services;
using System;

namespace BookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            BookController bookHandler = new BookController();
            BookDbContext context = new BookDbContext();
            context.Database.EnsureCreated();
            BookRepository _bookService = new BookRepository(context);

            StartUp startUp = new StartUp();
            startUp.Start(_bookService, bookHandler);

        }
    }
}
