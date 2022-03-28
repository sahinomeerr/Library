using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Staff
    {
        Library library = new Library();

        public void AddBookshelf()
        {
            library.AddBookshelf();
        }
        public void AddBook(string nameBook)
        {
            bool isNumberOfPagesInt = false;
            Console.Write("Please enter the number of pages: ");
            string numberPages = Console.ReadLine();   
            isNumberOfPagesInt = int.TryParse(numberPages, out int numberPagesBook);

            if (isNumberOfPagesInt)
            {
                if (isNumberOfPagesInt && !FindBook(nameBook))
                {
                    library.AddBook(nameBook, numberPagesBook);
                    Console.WriteLine(GetBookLocation(nameBook));
                    GoStartUp();
                }
                else if(isNumberOfPagesInt && FindBook(nameBook))
                {
                    Console.Clear();
                    Console.WriteLine("That book already exists");
                    GoStartUp();
                    AddBook(nameBook);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You must enter a valid number");
                    GoStartUp();
                }
            }

        }
        public bool FindBook(string bookName)
        {
            if (library.FindBook(bookName))
            {
                return true;
            }
            return false;

        }

        public string GetBookLocation(string nameBook)
        {
            if (library.GetBookLocation(nameBook) != null)
            {
                return library.GetBookLocation(nameBook);
            }
            return null;
        }
        public void BorrowBook(string nameBook)
        {
            Console.Write("Buyer's name: ");
            string buyerName = Console.ReadLine();
            User user = new User( buyerName);
            user.BorrowedBook(nameBook, GetNumberPageOfBook(nameBook));
            library.BorrowBook(nameBook);
            Console.WriteLine("The book is successfully borrowed!");
            GoStartUp();
        }
        public int GetNumberPageOfBook(string nameBook)
        {
            return library.GetNumberPageOfBook(nameBook);
        }
        public void StartUp()
        {
            Console.WriteLine("1) Get location of a book");
            Console.WriteLine("2) Check if a book exist");
            Console.WriteLine("3) Borrow a book");
            Console.WriteLine("4) Add a new book");
            Console.WriteLine("5) Add a new bookshelf");
            Console.Write("Please enter your choice: ");
            string input = Console.ReadLine();
            bool isInputAnInt = int.TryParse(input, out int inputInt);
            
            if (isInputAnInt)
            {
                
                switch (inputInt)
                {
                    case 1:
                        Console.Write("Please enter the name of book: ");
                        string nameBook = Console.ReadLine();
                        Console.WriteLine(GetBookLocation(nameBook));
                        GoStartUp();
                        break;
                    case 2:
                        Console.Write("Please enter the name of book: ");
                        string nameBook1 = Console.ReadLine();
                        if (FindBook(nameBook1)) Console.WriteLine("The book " + nameBook1 + " exists");
                        else Console.WriteLine("The book " + nameBook1 + " does not exist");
                        GoStartUp();
                        break;
                    case 3:
                        Console.Write("Please enter the name of book: ");
                        string nameBook2 = Console.ReadLine();
                        BorrowBook(nameBook2);
                        break;
                    case 4:
                        Console.Write("Please enter the name of book: ");
                        string nameBook3 = Console.ReadLine();
                        AddBook(nameBook3);
                        break;
                    case 5:
                        AddBookshelf();
                        GoStartUp();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("You've entered a invalid number");
                        GoStartUp();
                        break;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You've entered a invalid number");
                GoStartUp();
            }
        }
        public void GoStartUp()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("Press enter to go back");
            Console.ReadLine();
            Console.Clear();
            StartUp();
        }
    }
}
