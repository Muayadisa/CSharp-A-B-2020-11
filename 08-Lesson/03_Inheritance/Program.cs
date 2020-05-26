using System;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {

            Meat m1 = new Meat();
            m1.Type = "a";
            m1.IsVeg = false;
            m1.Price = 120m;

            Console.WriteLine($"Meat 1: {m1.Type}, and consts: {m1.Price}");
            Console.WriteLine($"The food is: {(m1.IsVeg? "Veg":"non-veg")}");

            Console.ReadKey();
            /*
                Meat 1: a, and consts: 120
                The food is: non-veg
            */
        }
    }
}
