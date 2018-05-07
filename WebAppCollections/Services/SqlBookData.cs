using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppCollections.Models;

namespace WebAppCollections.Services
{
    public class SqlBookData : IBooks
    {
        private BookDbContext _context;

        public SqlBookData(BookDbContext context)
        {
            _context = context;
        }
        public Books Add(Books books)
        {
            _context.Books.Add(books);
            _context.SaveChanges();

            return books;
        }

        public Books Get(int id)
        {
            return _context.Books.FirstOrDefault(r => r.Id ==id);
        }

        public IEnumerable<Books> GetBooks()
        {
            return _context.Books.OrderBy(b => b.Author);
        }
    }
}
