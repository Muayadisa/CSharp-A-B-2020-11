using System;

namespace Lesson06
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Bob", new Address("Israel", "Jerusalem", "abc", 45));

            Console.WriteLine(p1.GetInfo());

            Console.ReadKey();

            /*
            Person: Bob lives in:
            Address: Israel: Jerusalem, abc, 4
            */
         
        }
    }
}
