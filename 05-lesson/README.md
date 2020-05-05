# Encapsulation - כימוס

The meaning of `Encapsulation` is to make sure that "sensitive" data is hidden from users.
To achieve it:

- Declare fields / variables as **private**
- Provide public **Get** and **Set** methods, to access and to update the value of the private variable.

## Access modifiers - הרשאות גישה למשתנים

> **public** - the code is accessible for all classes.

> **private** - the code is accessible only within the same class.

> **protected** - the code is accessible only within the same class, or in inherited classes.

## Why Encapsulation

> Better control of class members. (reduce the possiblity to mess up the code).

> Fields can be made read-only(use of **get** method only), or write-only(use of **set** method only).

> Flexible: the programmer can change one part of the code without affecting other parts.

> Security: increased. Users can't access any data of the code.
