using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            library.Add("someTitle", "Shadi", "Aslan", 200);
            library.Add("title One", "Shadi", "Aslan", 400);
            library.Add("title big", "Shadi", "Aslan", 1000);

            library.ShowMyBooks();

           


        }
    }
}
