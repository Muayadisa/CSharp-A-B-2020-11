using System;

namespace Lesson11
{
    interface IActions
    {
        void MoveLeft(int speed);
        void MoveRight(int speed);
    }

    class Car : IActions
    {
        public void MoveLeft(int speed)
        {
            Console.WriteLine($"Car moves left in speed: {speed}");
        }

        public void MoveRight(int speed)
        {
            Console.WriteLine($"Car moves right in speed: {speed}");
        }
    }

    class Person : IActions
    {
        public void MoveLeft(int speed)
        {
            Console.WriteLine($"Person moves left in speed: {speed}");
        }

        public void MoveRight(int speed)
        {
            Console.WriteLine($"Person moves right in speed: {speed}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            IActions[] objectsInTheRoad = new IActions[]
            {
                new Person(),
                new Car()
            };

            foreach (IActions item in objectsInTheRoad)
            {
                item.MoveLeft(5);
            }

            Console.WriteLine(objectsInTheRoad[0]);

            /*
             * objectsInTheRoad: 2 items
             * [Person()], [ Car() ]
             * [0 index ], [1 index]
             
             
              Person moves left in speed: 5
              Car moves left in speed: 5

            */

            Console.ReadKey();
        }
    }
}
