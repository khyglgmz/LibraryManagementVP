using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystemm.Entities
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string Title { get; set; }

        public string Author { get; set; }
        public string bookPage { get; set; }
        public string Genre { get; set; }

        public bool Availability { get; set; }
        public virtual ICollection<BookBorrowing> Borrowings { get; set; }

    }
}
