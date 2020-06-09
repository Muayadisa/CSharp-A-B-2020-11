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

##### override to properties:

```cs
class A
{
    public virtual int num { get; set; }
}
class B:A
{
    public override int num { get; set; }
}
```

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
    // casting:
    B b1 = (B)a2;
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

Overloading allows us to create more than 1 function with the same name, but each function will have diffrent parameters.

The program will know which function to call according to:

1. Number of properties
2. Type of properties

> Overloading is known in constructors: we can create many constructors, as long as they get diffrent variables.

```cs
static bool isEqual(int x, int y)
{
    return x == y;
}

static bool isEqual(string x, string y)
{
    return x == y;
}

static bool isEqual(bool x, bool y)
{
    return x == y;
}
```

## Generic - כללי

The use of generic is to avoid code repetition.

- Here - a generic function. `x` can be from any type.

```cs
static void func<T>(T x)
{
    Console.WriteLine($"x = {x}");
}
```

- Here - we use two diffrent types. (it can be also the same type)

```cs
static void func<T, S>(T x, S y)
{
    Console.WriteLine($"x = {x}, y = {y}");
}
```

#### Implicit - בצורה מרומזת

Call a function in implicit way:

```cs
func(3, 7);
func(4, "hello");
```

#### Explicit - בצורה מפורשת

Call a function in Explicit way (define the types in the function call):

```cs
func<int, int>(3, 7);
func<int, string>(4, "hello");
```

> Note: we use `Implicit` and `Explicit` in casting.

## Where

Where is a keyword that represts the type that the function can take.

- In this example: **x** can be only from type **Person** class, or subclasses of **Person** class

```cs
static void Func<T>(T x) where T : Person
{
    Console.WriteLine($"x = {x}");
}
```
