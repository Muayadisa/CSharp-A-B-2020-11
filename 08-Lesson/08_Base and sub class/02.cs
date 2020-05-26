using System;

namespace Lesson8
{
    class A
    {
        public int Num1 { get; set; } = 1;
    }
    class B:A
    {
        public int Num2 { get; set; } = 2;
    }

    // access child properties with parent pointers: 


    class Program
    {
        static void Main(string[] args)
        {
            // a base class can point to sub class: 
            A a1 = new B();

            Console.WriteLine(a1.Num1); // 1

            // Console.WriteLine(a1.Num2); -- error! 


            B b1 = new B();
            Console.WriteLine(b1.Num1); // 1
            Console.WriteLine(b1.Num2); // 2

            Console.ReadKey();
        }
    }
}
