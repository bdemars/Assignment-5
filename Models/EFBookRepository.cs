using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_5.Models
{
    public class EFBookRepository : iBookRepository
    {
        private BookDbContext _context;

        //Constructor
        public EFBookRepository (BookDbContext context)
        {
            _context = context;
        }
        public IQueryable<Book> Books => _context.Books;
    }
}
