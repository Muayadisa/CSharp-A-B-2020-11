using System;

namespace Lesson07
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie m1 = new Movie("Avatar", 120);
            Movie m2 = new Movie("Alice in wonderland", 180);

            Hall h1 = new Hall(m1);
            Hall h2 = new Hall(m2);

            Cinema c = new Cinema();
            c.Halls[0] = h1;
            c.Halls[1] = h2;

            // buy tickets:
            c.BuyTickets("Avatar", 4);
            c.BuyTickets("Alice in wonderland", 6);

            // Print cinema data:
            Console.WriteLine(c.ToString());

            Console.ReadKey();
        }
    }
}
