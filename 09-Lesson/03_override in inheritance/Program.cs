using System;

namespace Lesson09
{
    class A
    {
        public void Try()
        {
            Console.WriteLine("Try A");
        }

        public void Try2()
        {
            Console.WriteLine("Try2 A");
        }
    }

    class B : A
    {
        public void Try()
        {
            base.Try();
            Console.WriteLine("Try B");
        }
    }

    class C : A
    {
        public void Try()
        {
            Console.WriteLine("Try C");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A(); // pointer is type A, points to an object of class A

            A a2 = new B(); // pointer is type A, points to an object of class B

            A a3 = new C(); // pointer is type A, points to an object of class C



            // Call methods:
            a1.Try(); // Try A
            a2.Try(); // Try A
            a3.Try(); // Try A


            B b1 = new B(); // pointer is type B, points to an object of class B

            C c1 = new C(); // pointer is type C, points to an object of class C

            b1.Try(); //  Try B
            c1.Try(); //  Try C


            // b1 can access A and B data. 
            b1.Try2();



            Console.ReadKey();

        }
    }
}
