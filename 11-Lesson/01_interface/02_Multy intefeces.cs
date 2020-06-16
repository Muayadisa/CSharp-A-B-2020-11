using System;

namespace Lesson11
{
   // Multy interface:

    interface IRunnable
    {
        void Start();
        void Stop();
    }

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

    class Person : IActions, IRunnable
    {
        public string Name { get; set; }

        public void MoveLeft(int speed)
        {
            Console.WriteLine($"Person moves left in speed: {speed}");
        }

        public void MoveRight(int speed)
        {
            Console.WriteLine($"Person moves right in speed: {speed}");
        }

        public void Start()
        {
            Console.WriteLine($"Person Starts running");
        }

        public void Stop()
        {
            Console.WriteLine($"Person Stopped running");
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

            IRunnable runnable = new Person();
            Console.WriteLine(runnable); // Lesson11.Person
            runnable.Start();
            // runnable.Name - does not exists!

            /*
                Person moves left in speed: 5
                Car moves left in speed: 5
                Person Starts running
            */


            Console.ReadKey();
        }
    }
}
