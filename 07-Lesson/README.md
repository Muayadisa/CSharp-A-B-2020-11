# Lesson 07 - static

**static** is a keyword in c#, that can be used with:

1. Classes
2. Variables
3. Methods
4. Constructor

### 1. Classes

In a non-static class - we can have both static and non-static properties and methods.
**Note** if a property / method is static - we do not have to declare an instance, and directly use the class name to reach the element. 
- Access non-static: (use this / instance_name)

```cs
instance_name.propName;
instance_name.methodName;
```

- Access static: 

```cs
class_name.propName;
class.methodName;
```

### 2. Static class

##### Examples in .NET
1. Math
2. Console
> note: reach the definition of the class by: F12
