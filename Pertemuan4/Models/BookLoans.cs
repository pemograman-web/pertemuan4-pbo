using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pertemuan4.Models
{
    public class BookLoans
    {
        public int IdLoan { get; set; }
        public int npm { get; set; }
        public String nama { get; set; }

        public List<Book_Model> books { get; set; }
    }
}