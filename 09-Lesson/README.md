# Lesson 09

## Readonly

```cs
public readonly int x;
public static readonly int y;
```

readonly - cannot be assigned to.

- static variable: can be assigned only in static constructor or variable initialize
- regular variable: can be assigned only in constructor or variable initialize

## Override

```cs
class A{}
class B:A{}
```

- instance of : `A a1 = new A()` - gets only the data for class A.
- instance of : `B b1 = new B()` - gets all the data for class A and class B.
  > if attributes have the same name in class A and B - b1 will go to the data of class B.
- - instance of : `A a2 = new B()` - gets only the data for class A. (if we check the type of a2 - it is also type B).
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

## Overloading

## Generics
