using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksCatalogueMVC.Models
{
    public interface ICategoryRepository
    {
        public IEnumerable<Category> GetAllCategories { get; }
    }
}
