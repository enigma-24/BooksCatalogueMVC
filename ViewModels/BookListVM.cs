using BooksCatalogueMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksCatalogueMVC.ViewModels
{
    public class BookListVM
    {
        public IEnumerable<Book> Books { get; set; }
        public string BookCategoryName { get; set; }
    }
}
