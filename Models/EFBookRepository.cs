using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksCatalogueMVC.Models
{
    public class EFBookRepository : IBookRepository
    {
        private readonly AppDbContext dbContext;

        public EFBookRepository(AppDbContext context)
        {
            dbContext = context;
        }

        public IEnumerable<Book> GetAllBooks 
        { 
            get 
            {
                return dbContext.Books.Include(c => c.Category);    
            } 
        }

        public IEnumerable<Book> FreeBooksOfTheWeek => throw new NotImplementedException();

        public Book GetBookById(int bookId)
        {
            return dbContext.Books.Include(x => x.Category).FirstOrDefault(c => c.BookId == bookId);
        }
    }
}
