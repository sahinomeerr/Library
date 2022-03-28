using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Bookshelf
    {
        List<Shelf> shelfList = new List<Shelf>();
        public int bookshelfNumber { get; set; }
        public Bookshelf(int bookshelfNumber)
        {
            this.bookshelfNumber = bookshelfNumber;
        }
        public void AddBookshelf()
        {
            Shelf shelf1 = new Shelf(0, 1, bookshelfNumber);
            Shelf shelf2 = new Shelf(0, 2, bookshelfNumber);
            Shelf shelf3 = new Shelf(0, 3, bookshelfNumber);
            shelfList.Add(shelf1);
            shelfList.Add(shelf2);
            shelfList.Add(shelf3);
            Console.WriteLine("Bookshelf is successfully added");
        }
        public void AddBook(string name, int pageNumber)
        {
            bool isThereAPlaceLeft = false;
            foreach (Shelf item in shelfList)
            {
                if (item.AddBook(name, pageNumber))
                {
                    Console.WriteLine("The book is added succesfully");
                    isThereAPlaceLeft = true;   
                    break;
                }
            }
            if (!isThereAPlaceLeft)
            {
                Console.WriteLine("There is no empty space"); 
            }
        }
        public bool FindBook(string bookName)
        {
            foreach (Shelf item in shelfList)
            {
                if (item.FindBook(bookName))
                {
                    return true;
                }
            }
            return false;
        }
        public string GetBookLocation(string bookName)
        {
            foreach (Shelf item in shelfList)
            {
                if (item.GetBookLocation(bookName) != null)
                {
                    return item.GetBookLocation(bookName);
                }
            }
            return null;
        }
        public void BorrowBook(string nameBook)
        {
            foreach (Shelf item in shelfList)
            {
                item.BorrowBook(nameBook);
            }
        }
        public int GetNumberPageOfBook(string nameBook)
        {
            foreach (Shelf item in shelfList)
            {
                if (item.GetNumberPageOfBook(nameBook) != 0)
                {
                    return item.GetNumberPageOfBook(nameBook);
                }
            }
            return 0;
        }
    }
}
