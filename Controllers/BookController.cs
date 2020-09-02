using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BooksCatalogueMVC.Models;
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
            return View(bookRepository.GetAllBooks);
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
