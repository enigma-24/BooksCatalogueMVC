using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksCatalogueMVC.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetAllCategories => new List<Category> {
        new Category{ CategoryId = 101, Name = "Computers and Technology"},
        new Category{ CategoryId = 102, Name = "Health and Fitness"},
        new Category{ CategoryId = 103, Name = "Business and Investing"},
        new Category{ CategoryId = 104, Name = "Travel Books"},
        new Category{ CategoryId = 105, Name = "History"},
        new Category{ CategoryId = 106, Name = "Education and Reference"}
        };
    }
}
