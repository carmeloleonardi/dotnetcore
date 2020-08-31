using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace LibraryWebApp.Models
{
    public class Author
    {
        public int AuthorID { get; set;}
        public string Name { get; set; }
        public string Surname { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateBirth { get; set; }
        public string CityBirth { get; set; }
        public string Biography { get; set; }

        public List<AuthorBook> AuthorBooks { get; set; }
    }
}
