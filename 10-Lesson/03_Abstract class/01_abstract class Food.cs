using System;

namespace Lesson10
{
    // abstract class: 
    // cannot have instance of abstract class
    // can inherit from abstract class

    // food - the main idea. 
     abstract class Food
    {
        public decimal Price = 12m;
    }

    class Fruit : Food
    {
        public string Name = "Apple";
    }

    class Vegtable : Food
    {
        public string Country ="Israel";
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Food f1 = new Food(); -> error!

            Food[] ShoppingList = new Food[]
            {
                new Fruit(),
                new Vegtable()
            };


            foreach(Food item in ShoppingList)
            {
                Console.WriteLine($"Item costs: {item.Price}");

                if(item is Fruit)
                {
                    Console.WriteLine($"This fruit name: {((Fruit)item).Name}");
                }
                if (item is Vegtable)
                {
                    Console.WriteLine($"The vegtable is from country: {((Vegtable)item).Country} ");
                }

            }

            /*
            Item costs: 12
            This fruit name: Apple
            Item costs: 12
            The vegtable is from country: Israel
            */


            Console.ReadKey();
        }
    }
}
