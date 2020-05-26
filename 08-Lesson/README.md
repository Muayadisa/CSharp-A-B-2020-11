# Lesson 08

### Static constructor:

a static constructor is used to initialize static members, or preform task one time, at the beginning of the class. It called automatically, before the first instance is created.

- A static constructor cannot take any arguments.
- A class can have only one static constructor.

### Static class:

- We cannot create instances from a static class.
- All variables, functions, constructor, etc.. must be **Static**
  - variables - private & public
  - constrcutor
  - functions

> example: Math, Console..

## Inheritance:

is an imoprtant topic in OOP.

```cs
class A
{

}
class B:A
{

}
```

#### Use base class in child class - **base**

```cs
class A{
 public string Hello()
    {
        return "Hello from A";
    }

}
class B:A
{
    public string Hello()
    {
        return base.Hello() + " Hello from B";
    }
}
```

### use **base** in constructor:

- parent class:

```cs
public parentClass(string x)
{
    X = x;
}
```

- child class:

```cs
public childClass(string y, string x): base (x)
{
    Y = y;
}
```
