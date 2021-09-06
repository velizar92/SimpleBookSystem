using BookSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSystem
{
    public class ConsoleBookHandler
    {

        public Book GetAllBookInfo()
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
            Console.WriteLine("Type book price: ");
            book.Price = decimal.Parse(Console.ReadLine());

            return book;
        }

        public void ShowBookInfo(Book book)
        {
            Console.WriteLine("=========================");
            Console.WriteLine("Id =====> " + book.Id);         
            Console.WriteLine("Name =====> " + book.Name);
            Console.WriteLine("Description =====> " + book.Description);
            Console.WriteLine("Genre =====> " + book.Genre);
            Console.WriteLine("Author =====> " + book.Author);
            Console.WriteLine("Year =====> " + book.Year);
            Console.WriteLine("Price =====> " + book.Price);
            Console.WriteLine("=========================");
        }

        public Book UpdateBookInfo(Book book)
        {
            ShowBookInfo(book);
            Console.WriteLine("Which property do you want to change: ");
            string property = Console.ReadLine();
            switch (property)
            {
                case "Name":
                    Console.WriteLine("Type the new Name:");
                    book.Name = Console.ReadLine();
                    break;
                case "Description":
                    Console.WriteLine("Type the new Description:");
                    book.Description = Console.ReadLine();
                    break;
                case "Genre":
                    Console.WriteLine("Type the new Genre:");
                    book.Genre = Console.ReadLine();
                    break;
                case "Author":
                    Console.WriteLine("Type the new Author:");
                    book.Author = Console.ReadLine();
                    break;
                case "Year":
                    Console.WriteLine("Type the new Year:");
                    book.Year = int.Parse(Console.ReadLine());
                    break;
                case "Price":
                    Console.WriteLine("Type the new Price:");
                    book.Price = decimal.Parse(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("There is no such property for book!");
                    break;
            }

            return book;

        }



    }
}
