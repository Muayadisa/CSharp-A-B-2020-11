# Lesson 03

### 1. Matrix - מטריצה
מטריצה היא מערך בתוך מערך. במבנה של טבלה
matrix is an array inside array. (like a table)

### 2. foreach vs for
For - uses the index of every item in array / matrix to get to its value. 
example: arr[0], matrix[0][1]
```cs
for (int i = 0; i < arr1.Length; i++)
    {
        Console.Write($"[ {arr1[i]} ]");
    }
```

Foreach - uses the value of every item in array / matrix. 
example: 
```cs
foreach (int arrItem in arr1)
    {
        Console.WriteLine($"arr1 foreach: {arrItem}");
    }
```

### Jagged array - מערך מקונן
Jagged array can put diffrent amount of elements in a row in a matrix. 
מערך מקונן יכול להכיל מספר איברים שונה בכל שורה במטריצה


