using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //implements ILibrary
    public class Library : ILibrary
    {
        //Since books need to be borrowed by Title, use a private Dictionary<string, Book> for storage.

        private Dictionary<string, Book> bookList = new Dictionary<string, Book>();



        public int Count
        {
            get { return bookList.Count; }
            
        }

       


        public void Add(string title, string firstName, string lastName, int numberOfPages)
        {
            Book newBook = new Book();


            newBook.Title = title;
            newBook.AuthorFirst = firstName;
            newBook.AuthorLast = lastName;
            newBook.NumberOfPages = numberOfPages;
            
            bookList.Add(newBook.Title, newBook);

            Console.WriteLine("~ * ~ * ~");
            Console.WriteLine($"A new book with Title: {newBook.Title} written by author: {newBook.AuthorFirst + newBook.AuthorLast} has beend added to our collection!");
            

        }

        public Book Borrow(string title)
        {
            Book borrowedBook;


            if (bookList.TryGetValue(title, out borrowedBook))
            {
                bookList.Remove(title);
                return borrowedBook;
            }

            //if (bookList.ContainsKey(title))
            //{
            //    bookList.Remove(title);
            //    bookList.TryGetValue(title, out borrowedBook);
            //    Console.WriteLine("~ * ~ * ~");
            //    Console.WriteLine($"{title} has been borrowed");

            //    return borrowedBook;
            //}
            else
            {
                Console.WriteLine("~ * ~ * ~");
                Console.WriteLine("Requested Book doesn't exist in my library");
                
                return null;
            }

        }

        

        public void Return(Book book)
        {
            Console.WriteLine("~ * ~ * ~");

            bookList.Add(book.Title, book);

            Console.WriteLine($"{book.Title} has been returned!");
            
        }




        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
        public IEnumerator<Book> GetEnumerator()
        {
            return (IEnumerator<Book>)GetEnumerator();
        }


        public void ShowMyBooks()
        {
            Dictionary<string, Book>.ValueCollection values = bookList.Values;

            Console.WriteLine("~ * ~ * ~");
            Console.WriteLine("The following books are the books available in our library: ");

            foreach (Book item in values)
            {
                Console.WriteLine(" ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~");

                Console.Write("Book Title: ");
                Console.WriteLine(item.Title);

                Console.Write("Author: ");
                Console.WriteLine(item.AuthorFirst + " " + item.AuthorLast);

                Console.Write("Number of Pages: ");
                Console.WriteLine(item.NumberOfPages);



            }
        }


    }
}
