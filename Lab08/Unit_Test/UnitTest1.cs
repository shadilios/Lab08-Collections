using System;
using Xunit;
using ConsoleApp1;

namespace Unit_Test
{
    public class UnitTest1
    {
        //Can add a book
        [Fact]
        public void CanAddABook()
        {
            Library lib = new Library();
            
            //No books so the count should be 0
            Assert.Equal(0, lib.Count);

            lib.Add("Title1", "first", "Last", 500);

            Assert.Equal(1, lib.Count);

        }

        //Borrowing an existing title returns the Book and remove it

        [Fact]
        public void TestBorrow()
        {
            Library lib = new Library();
            lib.Add("title1", "fist", "last", 500);
            lib.Add("title2", "first", "last", 500);
            Book book = lib.Borrow("title2");

            Assert.Equal(1, lib.Count);
        }


        //borrowing a missing title returns null
        [Fact]
        public void TestMissingTitle()
        {
            Library lib = new Library();
            lib.Add("title1", "fist", "last", 500);

            Book book = lib.Borrow("lajkshd");

            Assert.Null(book);
        }


        //returned book is in the library
        [Fact]
        public void TestReturn()
        {
            Library lib = new Library();
            lib.Add("title1", "fist", "last", 500);
            lib.Add("title2", "first", "last", 500);

            Book book = lib.Borrow("title1");

            lib.Borrow("title1");

            lib.Return(book);
            
            Assert.Equal(2, lib.Count);
        }

        [Fact]
        public void TestBackpack()
        {
            Backpack<string> items = new Backpack<string>();

            items.Pack("hi");

            string x = items.Unpack(0);

            Assert.Equal(x, "hi");
        }

    }
}
