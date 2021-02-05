using ConsoleTP1.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace ConsoleTP1.Database
{
    public class MyDbContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookShop> BookShops { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Editor> Editors { get; set; }

        public MyDbContext()
        {
            if (this.Database.CreateIfNotExists())
            {
                for (int i = 0; i < 10; i++)
                {
                    this.Books.Add(new Entities.Book() { Name = "F" + i, Nb_page = 100 * i });
                }

                this.SaveChanges();
      
            }


        }

        
    }
}
