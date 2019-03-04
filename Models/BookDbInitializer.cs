using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MetanitASP_NET_MVC5.Models
{
    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Name = "Spartak", Author = "R. Jovaniolli", Price = 1000, InStock = 5 });
            db.Books.Add(new Book { Name = "White Fang", Author = "J. London", Price = 800, InStock = 3 });
            db.Books.Add(new Book { Name = "the Hobbit", Author = "Tolkien", Price = 1500, InStock = 10 });

            base.Seed(db);
        }
    }
}