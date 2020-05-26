# Constructor only in the parent class:

```cs
using System;

namespace Lesson8
{
    class A
    {
        // constructor
        public A()
        {
            Console.WriteLine("I am constructor for A");
        }
    }

    class B: A{ }


    class Program
    {
        static void Main(string[] args)
        {

            B b1 = new B();
            Console.ReadKey();
        }
    }
}

```

res:

```cs
// I am constructor for A
```

## Constructor in the parent + the child class (without parameters):

```cs
using System;

namespace Lesson8
{
    class A
    {
        // constructor
        public A()
        {
            Console.WriteLine("I am constructor for A");
        }
    }

    class B: A
    {
        // constructor
        public B()
        {
            Console.WriteLine("I am constructor for B");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            B b1 = new B();


           Console.ReadKey();
        }
    }
}

```

res:

```cs
// I am constructor for A
// I am constructor for B
```

## Constructor in the parent + the child class (with parameters):

```cs
using System;

namespace Lesson8
{
    class A
    {
        // constructor
        public A(int x, int y)
        {
            Console.WriteLine($"I am constructor for A: x is: {x}, y is: {y}");
        }

    }

    class B: A
    {
        // constructor
        public B(int a,int b, int num2):base(a, b)
        {
            Console.WriteLine($"I am constructor for B, a is: {a}, b is: {b}, num2 is: {num2}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            B b1 = new B(4, 5, 12);


           Console.ReadKey();
        }
    }
}

```

res

```cs
// I am constructor for A: x is: 4, y is: 5
// I am constructor for B, a is: 4, b is: 5, num2 is: 12
```
