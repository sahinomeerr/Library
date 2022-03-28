using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Book
    {
        public int pageNumber { get; set; }
        public string name { get; set; }
        public int shelfNumber { get; set; }
        public int bookshelfNumber { get; set; }
        public Book(string name,int pageNumber,int shelfNumber,int bookshelfNumber)
        {
            this.name = name;
            this.pageNumber = pageNumber;
            this.shelfNumber = shelfNumber;
            this.bookshelfNumber = bookshelfNumber;
        }

    }
}
