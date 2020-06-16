# Namespace

- Namespace is used to declare a scope, that contains related objects.
- in a namespace we can declare 0 or more of:
  - class
  - interface
  - enum
  - delegate
  - struct
  - Another namespace

* We can use another namespace in our project using : `using` keyword.
  for example: `using System;`

* Code of the `Console` class. (belog to namespace `System`)

```cs
namespace System
{
    //
    // Summary:
    //     Represents the standard input, output, and error streams for console applications.
    //     This class cannot be inherited.
    public static class Console
```

- If we did not import `use System;` - we can still use the class `Console` by writing the full path.

```cs
using System;
Console.WriteLine();
```

or:

```cs
System.Console.WriteLine();
```
