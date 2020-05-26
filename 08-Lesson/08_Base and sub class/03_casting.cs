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

    // casting


    class Program
    {
        static void Main(string[] args)
        {
            A a1 = new B();

            Console.WriteLine(a1); // lesson8.B

            if(a1 is B)
            {
                Console.WriteLine(((B)a1).Num1); // 1
                Console.WriteLine(((B)a1).Num2); // 2
            }

            Console.ReadKey();
        }
    }
}
