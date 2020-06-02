using System;

namespace Lesson09
{

    class Person { }

    class Student: Person { }

    class Car { }

    class Program
    {
        // T must be class "Person" or class "Student"
        static void Nums<T>(T x) where T : Person
        {
            Console.WriteLine($"x = {x}");
        }

        static void Main(string[] args)
        {

            // Nums(new Car()); -- error!

            Nums(new Person());

            Nums(new Student());

        }
    }
}
