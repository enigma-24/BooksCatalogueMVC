using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BooksCatalogueMVC.Models;
using BooksCatalogueMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BooksCatalogueMVC.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository bookRepository;
        private readonly ICategoryRepository categoryRepository;

        public BookController(IBookRepository bookrepo,ICategoryRepository categoryrepo)
        {
            bookRepository = bookrepo;
            categoryRepository = categoryrepo;
        }

        public IActionResult BookList()
        {
            BookListVM bookListVM = new BookListVM
            {
                Books = bookRepository.GetAllBooks,
                BookCategoryName = categoryRepository.GetAllCategories.ToList()[0].Name
            };

            return View(bookListVM);
        }

        public IActionResult BookDetails(int id)
        {
            Book book = bookRepository.GetBookById(id);
            return View(book);
        }
    }
}
