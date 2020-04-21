using System;

namespace Lesson_04
{

    class Fruit
    {
        // Properties: 
        public string Name;

        public decimal Price;

        // Methods: 
        public string GetDescrition()
        {
            return $"Fruit {Name}, costs: {Price}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Fruit fruit1 = new Fruit();
            fruit1.Name = "Apple";
            fruit1.Price = 5.6m;
            
            Console.WriteLine(fruit1.GetDescrition()); //--> Fruit Apple, costs: 5.6

            Console.ReadKey();
        }
    }

   
}
