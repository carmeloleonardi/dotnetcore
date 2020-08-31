using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryWebApp.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Description { get; set; }

        public List<BookCategory> BookCategories { get; set; }
    }
}
