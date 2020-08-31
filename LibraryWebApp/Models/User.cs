using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryWebApp.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        [DataType(DataType.Date)]
        public string DateBirth { get; set; }
        public string Address { get; set; }
        [DataType(DataType.Date)]
        public string DateEnrollment { get; set; }

        public List<BookLoan> BookLoans { get; set; }
    }
}
