using System;

namespace Lesson09
{
    class A
    {
        public virtual void Try()
        {
            Console.WriteLine("Try A");
        }
    }

    class B : A
    {
        public override void Try()
        {
            Console.WriteLine("Try B");
        }
    }

    class C : B
    {
        public override void Try()
        {
            Console.WriteLine("Try C");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            // new - it is recommended to add the `new` keyword to a method that has the same name as parent class. 

            A a1 = new A(); 
            A a2 = new B(); 
            A a3 = new C(); 

           
            a1.Try(); // Try A
            a2.Try(); // Try B
            a3.Try(); // Try C


            B b1 = new B();
            b1.Try(); // Try B

            C c1 = new C();
            c1.Try(); // Try C



            Console.ReadKey();

        }
    }
}
