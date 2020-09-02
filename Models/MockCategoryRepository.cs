using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksCatalogueMVC.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetAllCategories => new List<Category> {
        new Category{ CategoryId = 101, Description = "Computers and Technology"},
        new Category{ CategoryId = 102, Description = "Health and Fitness"},
        new Category{ CategoryId = 103, Description = "Business and Investing"},
        new Category{ CategoryId = 104, Description = "Travel Books"},
        new Category{ CategoryId = 105, Description = "History"},
        new Category{ CategoryId = 106, Description = "Education and Reference"}
        };
    }
}
