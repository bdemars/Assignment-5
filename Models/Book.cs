using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Assignment_5.Models
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }
        public string Title { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public string Publisher { get; set; }

        [RegularExpression(@"^[0-9]{3}[-][0-9]{10}$", ErrorMessage = "This is not a valid ISBN number (###-##########)")]
        public string ISBN { get; set; }
        public string Category { get; set; }
        public string Classification { get; set; }
        public decimal Price { get; set; }
        public int Pages { get; set; }

    }
}
