using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppCollections.Models;

namespace WebAppCollections.Services
{
   public interface IBooks
    {
        IEnumerable<Books> GetBooks();
        Books Get(int id);
        Books Add(Books books);
    }
}
