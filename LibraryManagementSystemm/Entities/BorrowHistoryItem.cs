using LibraryManagementSystemm.Data_Acces_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystemm.Entities
{
    public class BorrowHistoryItem
    {
            public int BorrowingId { get; set; }
            public int UserId { get; set; }
            public string Username { get; set; }
            public int BookId { get; set; }
            public string BookTitle { get; set; }
            public DateTime BorrowDate { get; set; }
            public DateTime? ReturnDate { get; set; }

    }
}
