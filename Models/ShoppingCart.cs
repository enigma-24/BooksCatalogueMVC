using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksCatalogueMVC.Models
{
    public class ShoppingCart
    {
        private readonly AppDbContext dbContext;

        public ShoppingCart(AppDbContext context)
        {
            dbContext = context;
        }

        public string ShoppingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        public static ShoppingCart GetShoppingCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>().HttpContext.Session;

            string shoppingCartId = session.GetString("ShoppingCartId") ?? Guid.NewGuid().ToString();

            session.SetString("ShoppingCartId",shoppingCartId);

            AppDbContext dbContext = services.GetService<AppDbContext>();
            return new ShoppingCart(dbContext) {ShoppingCartId = shoppingCartId };
        }

        public void AddItemToCart(Book book, decimal amount)
        {
            ShoppingCartItem shoppingCartItem = dbContext.ShoppingCartItems.SingleOrDefault(c => c.Book.BookId == book.BookId && c.ShoppingCartId == this.ShoppingCartId);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = this.ShoppingCartId,
                    Book = book,
                    Amount = amount
                };
                dbContext.ShoppingCartItems.Add(shoppingCartItem);
            }
            dbContext.SaveChanges();
        }

        public void RemoveItemFromCart(Book book)
        {

        }
    }
}
