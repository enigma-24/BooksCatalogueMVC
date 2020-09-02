using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksCatalogueMVC.Models
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAllBooks { get; }
        IEnumerable<Book> FreeBooksOfTheWeek { get; }
        Book GetBookById(int bookId);
    }
}
