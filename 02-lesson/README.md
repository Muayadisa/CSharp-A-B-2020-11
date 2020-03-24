# Lesson 02

### Convert types:

1. get the variables types in c#:
```cs
VarName.GetType()
```

2. Convert to int:
```cs
Convert.ToInt32(varName)
```
3. Convert to string:
```cs
varName.ToString()
```
---
## Casting:

<div dir=rtl>
    
#### 1. Implicit casting: המרה מרומזת
המרה מרומזת : תתבצע כאשר נשים משתנה מטיפוס אחד למשתנה מטיפוס אחר
כל עוד אין חשש שנאבד במהלך ההמרה שום מידע

</div>

example: byte is 1 byte in memory, and can be converted implicitly to any type that is bigger that it. 
```cs
byte to int/long/double/float 

int to long/double

float to double
```

<div dir=rtl>
    
#### 2. Explicit casting: המרה מפורשת
המרה מפורשת : תתבצע כאשר נשים משתנה מטיפוס אחד למשתנה מטיפוס אחר
יש חשש שנאבד במהלך ההמרה מידע
</div>

example: float to int: the data after the `.` will be lost. 
```cs
float to int

long/double/float/int to byte. 
```

---
## String interpolation
interpolation - שרבוב או קריאת ביניים. 
```cs
string msg = "Hello";
string newMsg = $"msg is : {msg}";
```

---
## Arrays in c#
There are 3 ways to define an array. 
* `new` is a saved word, that creates an object of array. 
* As long as we don't initialize the elements in the array, the value in each cell will be junk value. 
<div dir=rtl>
    כל עוד לא הכנסנו ערכים לתוך התאים במערך, 
    תוכנם יהיה ערך זבל. 
</div>

