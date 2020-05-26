using System;

namespace Lesson8
{
    class A
    {
    }
    class B:A
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A();

            // a base class can point to sub class: 
            A a2 = new B(); 

            B b1 = new B();

            // B b2 = new A(); -- error! sub class cannot point to base class. 



            Console.ReadKey();
        }
    }
}
