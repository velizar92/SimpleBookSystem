using BookSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSystem.Data
{
    public class BookDbContext : DbContext
    {

        public DbSet<Book> Books { get; set; }


        public BookDbContext()
        {

        }

        public BookDbContext(DbContextOptions<BookDbContext> options)
           : base(options)
        {
           
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-JITMAHC;Database=BookDb;Integrated Security=true;");
            }
        }



    }
}
