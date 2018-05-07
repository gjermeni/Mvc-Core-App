using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppCollections.Models;

namespace WebAppCollections.Services
{
    public class InMemoryBooks: IBooks
    {
        public InMemoryBooks()
        {
             _books = new List<Books>
             {
            new Books() {Id=1, Title ="Kont of Mount Cristos", Description="About eghteen century", Author="Don Mon", Category=Category.aksion},
            new Books() {Id=2, Title="Introduction in C Sharp", Description="Learning computer programing", Author="Scott Allen", Category= Category.education},
            new Books() {Id=3, Title="The Castle", Description="Learning about history", Author="Ismail Kadare", Category= Category.drama},
            new Books() {Id=4, Title="Madam Bavary", Description="Love story", Author="Gi de Mopasan", Category= Category.romance}

         };   
        }

       public IEnumerable<Books> GetBooks()
        {
           return _books.OrderBy(b=> b.Author);
        }

        public Books Get(int id)
        {
            return _books.FirstOrDefault(b=> b.Id==id);
        }

        public Books Add(Books book)
        {
            book.Id = _books.Max(b => b.Id) + 1;
            _books.Add(book);

            return book;
        }

        List<Books> _books;

        
    }
}
