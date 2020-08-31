using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryWebApp.Models
{
    public class BookLoan
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public string Isbn { get; set; }
        public Book Book { get; set; }
    }
}
