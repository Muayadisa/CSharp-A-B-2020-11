using System;

namespace Lesson07
{

    class Fruit
    {
        public static int numOfFruits = 100;
        // properties
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // method:
        public override string ToString()
        {
            return $"fruit: {name}";
        }

    }


    class A
    {
        // static method - we can call it without creating an instance of A.
        public static void SayHello(string name)
        {
            Console.WriteLine($"Hello from {name}");
        }

        public void SayHi(string name)
        {
            Console.WriteLine($"Hi from {name}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A.SayHello("Bob"); // Hello from Bob
            // A.SayHi("Bob"); -> error. 
            //we cannot access a method without the instance, when it's not static

            Console.WriteLine(Fruit.numOfFruits); //--> 100

            Console.ReadKey();
        }
        
    }
}
