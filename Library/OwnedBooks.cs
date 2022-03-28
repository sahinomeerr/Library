using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class OwnedBooks
    {
        public string buyerName { get; set; }
        public string nameBook { get; set; }
        public OwnedBooks(string buyerName, string nameBook)
        {
            this.buyerName = buyerName;
            this.nameBook = nameBook;
        }
        public void AddBorrowedBook(string nameBook,string buyerName)
        {
            Book book = new Book(nameBook)
        }
    }
}
