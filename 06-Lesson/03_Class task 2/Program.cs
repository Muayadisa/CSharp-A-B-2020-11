using System;

namespace Lesson06
{
    class Program
    {
        static void Main(string[] args)
        {
            // father:
            Person p1 = new Person("Gogo", new Date(1970, 5, 8), null, null);
            // mother:
            Person p2 = new Person("Gigi", new Date(1968, 4,30), null, null);
            // child:
            Person p3 = new Person("Momo", new Date(2000, 12, 6), p1, p2);

            Console.WriteLine(p1.ToString()); // info for father only
            Console.WriteLine(p3.ToString()); // info for child + parents
            
            Console.ReadKey();

           
        }
    }
}
