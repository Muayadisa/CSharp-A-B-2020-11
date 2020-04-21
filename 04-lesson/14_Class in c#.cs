using System;

namespace Lesson_04
{
    /* 
    * car is a class - מחלקה
    Define a template that does not take place in memory
    We can create instances of the class using its parameters
    */

    class Car
    {
        // properties: 
        public int NumOfWheels;

        public decimal Price;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of class `Car`
            // Instance - מופע של המחלקה
            // new Car() - this creates in the heap a new object of the "car" class
            // the address of this object is stored to "myCar1"
            Car myCar1 = new Car();
            myCar1.NumOfWheels = 4;
            myCar1.Price = 30000m;

            Console.WriteLine($"Car 1 costs: {myCar1.Price}, and has { myCar1.NumOfWheels} wheels");


            Car myCar2 = new Car();
            myCar2.Price = 50000m;
            myCar2.NumOfWheels = 2;

            Console.WriteLine($"Car 2 costs: {myCar2.Price}, and has { myCar2.NumOfWheels} wheels");

            /*
             Car 1 costs: 30000, and has 4 wheels
             Car 2 costs: 50000, and has 2 wheels
            */


            Console.ReadKey();
        }
    }

   
}
