using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksCatalogueMVC.Models
{
    public class MockBookRepository : IBookRepository
    {
        private readonly ICategoryRepository categoryRepository;

        public MockBookRepository(ICategoryRepository repository)
        {
            categoryRepository = repository;
        }
        public IEnumerable<Book> GetAllBooks => new List<Book> { 
        new Book{BookId = 1, Title = "Effective Java",Author = "Joshua Bloch", Price = 38, ImageUrl = "https://tinyurl.com/yyudmsms", InStock = true, Category = categoryRepository.GetAllCategories.ToList()[0] },
        new Book{ BookId = 2, Title = "Little Book of Mindfulness", Author = "Dr. Patrizia Collard", Price = 8, ImageUrl="https://tinyurl.com/y32sgz2b", InStock = true, Category = categoryRepository.GetAllCategories.ToList()[1]},
        new Book{ BookId = 3, Title = "Computers Made Easy", Author = "James Bernstein", Price = 20, ImageUrl = "https://tinyurl.com/yxnfc7ym", InStock = true, Category = categoryRepository.GetAllCategories.ToList()[0]},
        new Book{ BookId = 4, Title = "Stock Investing", Author = "Andrew Dagys", Price = 30, ImageUrl = "https://tinyurl.com/y278bo2q", InStock = true, Category = categoryRepository.GetAllCategories.ToList()[2]},
        new Book{ BookId = 5, Title = "Destinations of a Lifetime", Author = "National Geographic", Price = 40, ImageUrl = "https://tinyurl.com/yxdhgj78", InStock = true, Category = categoryRepository.GetAllCategories.ToList()[3]},
        new Book{ BookId = 6, Title = "Sapiens - A brief History of Humankind", Author = "Yuval Harari", Price = 49, ImageUrl = "https://tinyurl.com/y395x9tp", InStock = true, Category = categoryRepository.GetAllCategories.ToList()[4]},
        new Book{ BookId = 7, Title = "IELTS General Training", Author = "University of Cambridge", Price = 41, ImageUrl = "https://tinyurl.com/y2hzaoav", InStock = true, Category = categoryRepository.GetAllCategories.ToList()[5]},
        };

        public IEnumerable<Book> FreeBooksOfTheWeek { get; }

        public Book GetBookById(int bookId)
        {
            return GetAllBooks.FirstOrDefault(c => c.BookId == bookId);
        }
    }
}
