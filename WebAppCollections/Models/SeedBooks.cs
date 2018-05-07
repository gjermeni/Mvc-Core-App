using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCollections.Models
{
    public static class SeedBooks
    {
        public static void Initialize(BookDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Books.Any())
            {
                return;
            }

            var books = new Books[]
             {
            new Books{ Title ="Kont of Mount Cristos", Description="About eghteen century", Author="Don Mon", Category=Category.aksion},
            new Books{ Title="Introduction in C Sharp", Description="Learning computer programing", Author="Scott Allen", Category= Category.education},
            new Books{ Title="The Castle", Description="Learning about history", Author="Ismail Kadare", Category= Category.drama},
            new Books{ Title="Madam Bavary", Description="Love story", Author="Gi de Mopasan", Category= Category.romance}

             };

            foreach (Books b in books)
            {
                context.Books.Add(b);
            }
                context.SaveChanges();
          
        }
    }
}
