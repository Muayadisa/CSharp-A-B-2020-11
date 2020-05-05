using System;

namespace Lesson_05
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---------- p1 ------------");

            // Person() - call the constructor
            Person p1 = new Person();

            p1.Name = "Bob";
            p1.Age = 60;

            Console.WriteLine(p1.GetDescription());

            Console.WriteLine("---------- p2 ------------");

            // Person() - call the constructor
            Person p2 = new Person();

            Console.WriteLine("---------- p3 ------------");

            // Person() - call the constructor
            Person p3 = new Person();

            Console.ReadKey();
        }

    }
}