# Lesson 10

## Enum

**Enum** - Enumeration type. Is a collection of constant values.
index starts from 0, as long as we do not define another number.
* **Why use enum?** - very comfortable to define constants in a list.
* **Enum examples:** - Seasons, DaysOfWeek, Colors, Months. 

```cs
enum x
{
    A,
    B,
    C
}
```

* Access -

```cs
x x1 = x.A;
// or
x x2 = (x)0;
```

## Sealed class:

Sealed class is a regular class that cannot be derived from.

**Regular class**

- Can be inherited.
- We can create static and non-static properties, methods and constructors.

```cs
class A { }
class B : A { }
```

**Static class**

- Cannot be inherited.
- Cannot have instances.
- We can create only static properties, methods and constructors.

```cs
static class A { }
class B : A { } // error!
```

**Sealed class:**

- cannot be derived from.
- We can create static and non-static properties, methods and constructors.

```cs
sealed class A { }
class B : A { } // error!
```

**Abstract class:** - מחלקה מופשטת
Abstract class is used to define the main idea of the program. the parent class cannot have instances.

- Can be inherited.
- We can create static and non-static properties, methods and constructors.
- Cannot create instance of that class.

```cs
abstract class A { }
class B : A { }

A a1 = new A(); // error!
```
