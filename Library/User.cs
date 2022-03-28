using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class User
    {
        public string nameBuyer { get; set; }
        public int pageNumber { get; set; }
        public string nameBook { get; set; }
        List<Book> booksOwnedByUser = new List<Book>();

        public User(string nameBuyer)
        {
            this.nameBuyer = nameBuyer;
        }
        public void BorrowedBook(string nameBook,int pageNumber)
        {
            Book book = new Book(nameBook, pageNumber,0, 0);
            booksOwnedByUser.Add(book);
        }
    }
}
