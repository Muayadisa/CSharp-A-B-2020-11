using System;

namespace Lesson_05
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Without constructor:
             -----------------------
             Book b0 = new Book();
             b0.BookName = "A";
             b0.NumOfPages = 120;
            */

            Book b1 = new Book("Book1", 100);

            Book b2 = new Book();
            
            Console.ReadKey();
        }

    }
}
