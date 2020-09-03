using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksCatalogueMVC.Models
{
    public class EFCategoryRepository:ICategoryRepository
    {
        private readonly AppDbContext dbcontext;

        public EFCategoryRepository(AppDbContext context)
        {
            dbcontext = context;
        }

        public IEnumerable<Category> GetAllCategories => dbcontext.Categories;
    }
}
