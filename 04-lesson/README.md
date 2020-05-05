# Lesson 04

### Conditions - תנאים
A condition always returns a boolean value
```cs
if(){

}
```
* In case we put direct boolean value:
```cs
if(true){
    // this will always happen
}
else{
    // This will never happen:
}
```

### Nested condition
```cs
if(){
    if(){

    }
    else{

    }
}
```

### Short condition
```
(condition)? (if condition true):(if condition true)
```
```cs
int num = 7;
int res = (num > 2)? (num *2):(num - 4);
```

### Switch - case
We must add `break` statement to case with data. 
```cs
switch(variable){
    case: data.. break;
    case:
    case: data.. break;
}
```
### Loops 
while will not execute if the statement in the condition is false. 
Do while will run at least one time. 
```cs
while(condition){

}

do{

}while(condition);

for(i = 0;condition ;i++){

}
```

### Function
```cs
static returned_type nameOfFunc(Optional: parameters){
    // code to execute
}

// call function:
nameOfFunc()
```

### Ref 
ref is reserved word. we use it to send the address of a variable to a function. 
That will change directly the value of a variable. 



```cs
static returned_type nameOfFunc(ref parameter){
    // code to execute
}

// call function:
nameOfFunc(ref parameter)
```








