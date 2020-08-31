using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LibraryWebApp.Models
{
    public class Book
    {
        [Key]
        public string Isbn { get; set; }
        public string Title { get; set; }
        public string Language { get; set; }
        public int YearPub { get; set; }
        public string Editor { get; set; }
        public string Section { get; set; }
        public int NumberBooshelf { get; set; }
        public int NumberPlace { get; set; }

        public List<AuthorBook> AuthorBooks { get; set; }
        public List<BookLoan> BookLoans { get; set; }
        public List<BookCategory> BookCategories { get; set; }

    }
}
