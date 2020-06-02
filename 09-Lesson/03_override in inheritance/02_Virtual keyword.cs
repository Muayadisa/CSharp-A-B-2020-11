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

            A a1 = new A(); 
            A a2 = new B(); 
            A a3 = new C(); 

            // 'B.Try()': cannot override inherited member 'A.Try()' 
            // because it is not marked virtual, abstract, or override 

            a1.Try(); // Try A
            a2.Try(); // Try B
            a3.Try(); // Try A

        }
    }
}
