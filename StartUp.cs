using BookSystem.Data;
using BookSystem.Models;
using BookSystem.Services;
using System;
using System.Collections.Generic;

namespace BookSystem
{
    public class StartUp
    {

        public void Start(BookRepository _bookService, ConsoleBookHandler _bookHandler)
        {
            Book book = null;

            Console.WriteLine("-------------------Welcome in our book library system-------------------");
            Console.WriteLine("---------------------------------MENU:----------------------------------");
            Console.WriteLine();
            Console.WriteLine("-----------------------------1. Create book-----------------------------");
            Console.WriteLine("-----------------------------2. Get book--------------------------------");
            Console.WriteLine("-----------------------------3. Get all books---------------------------");
            Console.WriteLine("-----------------------------4. Update book-----------------------------");
            Console.WriteLine("-----------------------------5. Delete book-----------------------------");


            Console.WriteLine("Please choose your option: ");
            int optionNumber = int.Parse(Console.ReadLine());

            while (true)
            {
                switch (optionNumber)
                {
                    case 1:
                        book = _bookHandler.GetAllBookInfo();
                        _bookService.CreateBook(book);
                        Console.WriteLine("Book is created! ");
                        break;
                    case 2:
                        Console.WriteLine("Please type book id that you want: ");
                        int id = int.Parse(Console.ReadLine());
                        book = _bookService.GetBook(id);
                        if(book == null)
                        {
                            Console.WriteLine("There is no book with such id!");
                            break;
                        }
                        _bookHandler.ShowBookInfo(book);
                        break;
                    case 3:
                        ICollection<Book> books = _bookService.GetBooks();
                        if (books.Count == 0)
                        {
                            Console.WriteLine("There are no any books in the database! ");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("----------------All books:----------------");
                            foreach (var bookItem in books)
                            {
                                _bookHandler.ShowBookInfo(bookItem);
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("Please type the book id of book that you want to update: ");
                        int bookId = int.Parse(Console.ReadLine());
                        book = _bookService.GetBook(bookId);
                        book = _bookHandler.UpdateBookInfo(book);
                        _bookService.UpdateBook(book, bookId);
                        Console.WriteLine("Book is updated! ");
                        break;
                    case 5:
                        Console.WriteLine("Please type the book id of book that you want to delete: ");
                        int delBookId = int.Parse(Console.ReadLine());
                        _bookService.DeleteBook(delBookId);
                        Console.WriteLine("Book is deleted! ");
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Please choose your next option: ");
                optionNumber = int.Parse(Console.ReadLine());
            }
        }

    }
}
