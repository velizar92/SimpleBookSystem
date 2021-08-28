using BookSystem.Data;
using BookSystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BookSystem.Services
{
    public class BookRepository
    {
        private BookDbContext _context;

        public BookRepository(BookDbContext context)
        {
            _context = context;
        }

        public ICollection<Book> GetBooks()
        {
            return _context.Books.ToList();
        }

        public Book GetBook(int id)
        {
            Book book = _context.Books.FirstOrDefault(b => b.Id == id);
            if (book != null)
            {
                return book;
            }

            return null;
            
        }

        public void CreateBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void UpdateBook(Book bookToUpdate, int id)
        {  
            _context.Entry(bookToUpdate).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteBook(int id)
        {
            var bookToDelete = _context.Books.Find(id);
            if(bookToDelete != null)
            {
                _context.Books.Remove(bookToDelete);
                _context.SaveChanges();
            }  
        }

    }
}
