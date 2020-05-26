using System;

namespace Lesson8
{
    class A
    {
        public string Hello()
        {
            return "Hello from A";
        }

        public string Bye()
        {
            return "Bye from A";
        }
    }
    class B:A
    {
        public string Hello()
        {
            return "Hello from B";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            B b1 = new B();
            Console.WriteLine(b1.Hello()); // Hello from B
            Console.WriteLine(b1.Bye());   // Bye from A

            Console.ReadKey();
        }
    }
}
