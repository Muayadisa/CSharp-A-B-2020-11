using System;

namespace Lesson06
{
    class Program
    {
        static void Main(string[] args)
        {
            // create new instance of class `Food`:

            Food f1 = new Food();

            // insert data to f1:
            f1.FoodName = "Pasta";
            f1.LastDate = new ExDate(12, 5, 2020);

            // Print f1 data:
            Console.WriteLine(f1.GetDescription());

            Console.ReadKey();
            /* RES:
             * ------------------------------
             Pasta expiration date: 2020/5/12
             */
        }
    }
}
