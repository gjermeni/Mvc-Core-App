using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCollections.Models
{
    public class BookDbContext: DbContext
    {
        public BookDbContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<Books> Books { get; set; }
    }
}
