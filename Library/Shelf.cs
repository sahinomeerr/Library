using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Shelf
    {
        List<Book> books = new List<Book>();       
        int shelfLimit = 5;
        int shelfNumber;
        int bookshelfNumber;
        int currentBookNumberInShelf=0;
        public Shelf(int currentBookNumberInShelf,int shelfNumber,int bookshelfNumber)
        {
            this.currentBookNumberInShelf = currentBookNumberInShelf;   
            this.shelfNumber = shelfNumber;
            this.bookshelfNumber = bookshelfNumber;
        }
        public bool AddBook(string name,int pageNumber)
        {
            if(currentBookNumberInShelf < shelfLimit)
            {
                Book book = new Book(name, pageNumber,shelfNumber,bookshelfNumber);
                books.Add(book);
                currentBookNumberInShelf++;
                return true;
            }
            return false;
        }
        public bool FindBook(string bookName)
        {
            foreach(Book item in books)
            {
                if (item.Equals(bookName))
                {                                      
                    return true;
                }
            }
            return false;
        }
        public string GetBookLocation(string bookName)
        {
            foreach (Book item in books)
            {
                if (item.Equals(bookName))
                {
                    return item.bookshelfNumber + ". Bookshelf " + item.shelfNumber + ". Shelf";
                }
            }
            return null;
        }
        public void BorrowBook(string nameBook)
        {
            foreach(Book item in books)
            {
                if (item.Equals(nameBook))
                {
                    books.Remove(item);
                }
            }
        }
        public int GetNumberPageOfBook(string nameBook)
        {
            foreach(Book item in books)
            {
                if (item.Equals(nameBook))
                {
                    return item.pageNumber;
                }
            }
            return 0;
        }
       
    }
}
