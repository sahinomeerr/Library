using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Library
    {
        List<Bookshelf> bookshelfList = new List<Bookshelf>();
        public int currentNumberOfBookshelves { get; set; } = 0;
        public void AddBookshelf()
        {
            currentNumberOfBookshelves++;
            Bookshelf bookshelf = new Bookshelf(currentNumberOfBookshelves);
            bookshelf.AddBookshelf();
            bookshelfList.Add(bookshelf);
        }
        public void AddBook(string name,int pageNumber)
        {
            foreach (Bookshelf item in bookshelfList)
            {
                item.AddBook(name,pageNumber);
            }
        }
        public bool FindBook(string bookName)
        {
            foreach(Bookshelf item in bookshelfList)
            {
                if (item.FindBook(bookName))
                {
                    return true;
                }
            }
            return false;
        }
        public void BorrowBook(string nameBook)
        {
            foreach(Bookshelf item in bookshelfList)
            {
                item.BorrowBook(nameBook);
            }
        }
        public string GetBookLocation(string nameBook)
        {
            foreach(Bookshelf item in bookshelfList)
            {
                if(item.GetBookLocation(nameBook) != null)
                {
                    return item.GetBookLocation(nameBook);
                }
            }
            return null;
        }
        public int GetNumberPageOfBook(string nameBook)
        {
            foreach(Bookshelf item in bookshelfList)
            {
                if(item.GetNumberPageOfBook(nameBook) != 0)
                {
                    return item.GetNumberPageOfBook(nameBook);
                }
            }
            return 0;
        }
    }
}
