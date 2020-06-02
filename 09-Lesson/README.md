# Lesson 09

## base

The `base` keyword can access the data in the parent(base) class:

1. Properties
2. Methods
3. Constructor

- Example with constructor:

```cs
class A{
    public int X { get; set; } // property

    public A(int x) // constructor
    {
        X = x;
    }

}
class B:A{
    // constructor with the data for ctor A
    public B(int x) :base(x)
    {
    }
}
```

## Readonly

```cs
public readonly int x;
public static readonly int y;
```

readonly - cannot be assigned to.

- static variable: can be assigned only in static constructor or variable initialize
- regular variable: can be assigned only in constructor or variable initialize

## Override - דריסה

```cs
class A{}
class B:A{}
```

- instance of : `A a1 = new A()` - gets only the data for class A.
- instance of : `B b1 = new B()` - gets all the data for class A and class B.

> if attributes have the same name in class A and B - b1 will go to the data of class B.

- instance of : `A a2 = new B()` - gets only the data for class A. (if we check the type of a2 - it is also type B).

> to access attributes from the sub-class `B` - we must convert the type of that instance.

## Casting:

Check the type of an instance:

```cs
if(instance is class){
    // code to execute
}

if(a2 is B){
    // code to execute
}
```

Convert type of an instance to a diffrent class:

```cs
A a1 = new B();
if(a1 is B){
    a1 = (B)a1;
}
```

## Multilevel inheritance

## Virtual and override

**Virtual** and **override** are keywords that go together.

- **Virtual** - is used in the base class. Virtual alows to override in the subclass the method.
- **override** - is used in the subclasses.

```cs
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

```

When we access `A a1 = new B()` - we get the method of class B.

## Sealed method - חתימת מתודה

- Sealed method can be used to block an override of the subclasses.

```cs
class A
    {
        public virtual void Try(){}
    }

    class B : A
    {
        public sealed override void Try(){}
    }

    class C : B
    {
        public void Try(){} /// cannot be override to B.
    }

```

## Overloading - העמסה

## Generic - כללי
