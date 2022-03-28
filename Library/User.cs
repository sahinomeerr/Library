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

        public User(string nameBook,int pageNumber,string nameBuyer)
        {
            this.nameBook = nameBook;
            this.pageNumber = pageNumber;
            this.nameBuyer = nameBuyer;
        }
        public void BorrowedBook()
        {
            Book book = new Book(nameBook, pageNumber,0, 0);
            booksOwnedByUser.Add(book);
        }
    }
}
