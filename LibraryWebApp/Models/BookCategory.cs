using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryWebApp.Models
{
    public class BookCategory
    {
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public string Isbn { get; set; }
        public Book Book { get; set; }
    }
}
