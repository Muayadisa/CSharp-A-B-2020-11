using System;
using Animal;
// using School.High_School;
using School;


namespace Lesson11
{
    class Program
    {
        static void Main(string[] args)
        {
            // import the namespace by :`using`
            Dog d1 = new Dog();
            Console.WriteLine(d1.age);

            School.High_School.Teacher t1 = new School.High_School.Teacher();
            School.Low_School.Teacher t2 = new School.Low_School.Teacher();

            Console.WriteLine(t1.Address);
            Console.WriteLine(t2.Name);

            /*
             *  5
                Israel
                MyTeachersName
            */

            Console.ReadKey();
        }
    }
}
