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
                    this.Books.Add(new Entities.Book() { Name = "Book" + i, Nb_page = 100 * i });
                }

                this.SaveChanges();

                this.Authors.Add(new Entities.Author() { Firstname = "AJulio", Lastname = "AMartinez" });
                this.Authors.Add(new Entities.Author() { Firstname = "ABobby", Lastname = "AMcCain" });

                this.SaveChanges();

                this.Customers.Add(new Entities.Customer() { Firstname = "CFreddy", Lastname = "CMercury" });
                this.Customers.Add(new Entities.Customer() { Firstname = "CBon", Lastname = "CJovy" });

                this.SaveChanges();

                this.BookShops.Add(new Entities.BookShop() { Name = "BLibrary" });
                this.BookShops.Add(new Entities.BookShop() { Name = "BBookyshop" });

                this.SaveChanges();

                this.Editors.Add(new Entities.Editor() { Name = "EPublishor"});

                this.SaveChanges();







            }


        }

        
    }
}
