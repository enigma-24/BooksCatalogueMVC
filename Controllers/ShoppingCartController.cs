using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BooksCatalogueMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BooksCatalogueMVC.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IBookRepository bookRepository;
        private readonly ShoppingCart shoppingCart;

        public ShoppingCartController(IBookRepository bookRepo, ShoppingCart cart)
        {
            bookRepository = bookRepo;
            shoppingCart = cart;
        }
        public IActionResult Index()
        {
            shoppingCart.ShoppingCartItems = shoppingCart.GetShoppingCartItems();
            return View(shoppingCart);
        }

        public IActionResult AddToShoppingCart(int bookId)
        {
            Book book = bookRepository.GetBookById(bookId);
            shoppingCart.AddItemToCart(book,book.Price);
            return RedirectToAction("Index");
        }

        public IActionResult RemoveFromShoppingCart(int bookId)
        {
            Book book = bookRepository.GetBookById(bookId);
            shoppingCart.RemoveItemFromCart(book);
            return RedirectToAction("Index");
        }
    }
}
