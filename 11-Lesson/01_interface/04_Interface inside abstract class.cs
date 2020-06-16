using System;

namespace Lesson11
{
    interface IUse
    {
        string UseItem();
        string DropItem();
    }

    // Two ways to use interface in abstract class:
    // 1. only use the method without data. 
    // 2. add data to the method. 

    abstract class HouseItem : IUse
    {
        public abstract string DropItem();

        public string UseItem()
        {
            return $"Use the house item!";
        }
    }

    class Dish : HouseItem
    {
        public override string DropItem()
        {
            return $"Droped the dish!";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            HouseItem item1 = new Dish();
            Console.WriteLine(item1.UseItem());
            Console.WriteLine(item1.DropItem());

            /*
             * Use the house item!
               Droped the dish!
             */

            Console.ReadKey();
        }
    }
}
