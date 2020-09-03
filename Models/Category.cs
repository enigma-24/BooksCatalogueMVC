using System.Collections.Generic;

namespace BooksCatalogueMVC.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }

        public List<Book> Books { get; set; }
    }
}