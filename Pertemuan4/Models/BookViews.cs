using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pertemuan4.Models
{
    public class BookViews
    {
        public List<Book_Model> books { get; set; }
        public List<User_Model> users { get; set; }
        public List<BookLoans> loans { get; set; }
    }
}