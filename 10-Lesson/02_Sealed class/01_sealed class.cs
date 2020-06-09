using System;

namespace Lesson10
{
    // inheritance: 
    // we can create instance of type A and type B. 
    // we can declare static and non-static members in both classes. 
    // B class inherits from A class. 
    class A { }
    class B : A { }



    // static:
    // class C can have only static members. 
    // static class C cannot have instances. 
    // static class cannot be derived from. 
    static class C { }
    class D : C { } // error!



    // Sealed class:
    // cannot be derived from. 
    // we can declare static and non-static members in both classes. 
    class E { }
    sealed class F : E
    {
        public int MyProperty { get; set; } = 4;
    }
    class G : F { } // error 

    

    class Program
    {
        static void Main(string[] args)
        {
            F f1 = new F();
            Console.WriteLine(f1.MyProperty); // 4

            Console.ReadKey();
        }
    }
}
