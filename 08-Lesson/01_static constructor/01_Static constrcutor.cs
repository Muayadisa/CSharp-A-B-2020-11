using System;

namespace Lesson8
{
    class Person
    {
        // Regular constructor:
        public Person(string name)
        {
            Console.WriteLine($"Name is : {name}");
        }

        // static constructor:
        static Person()
        {
            Console.WriteLine("This is a static constructor!");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("John");
            Person p2 = new Person("Tom");
            Person p3 = new Person("Alice");

            Console.ReadKey();
            /*
                This is a static constructor!
                Name is : John
                Name is : Tom
                Name is : Alice
                */
        }
    }
}
