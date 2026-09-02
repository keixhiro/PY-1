C# Cheat Sheet — Intro to Arrays
*(Covers w3schools.com/cs from "C# Intro" through "C# Arrays")*



1. Introduction
C# ("C-Sharp") is an **object-oriented** language created by Microsoft, runs on the **.NET Framework**.
Related to C, C++, and Java.
Used for: mobile apps, desktop apps, web apps/services, games, VR, databases, etc.



2. Getting Started
Typical tools: **Visual Studio**, **Visual Studio Code**, or an online compiler.
Minimal program (top-level statements, modern C#):
Console.WriteLine("Hello World!");
Traditional structure:
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}



3. Syntax
`Main` is the entry point of every C# program.
Every statement ends with a **semicolon `;`**.
C# is **case-sensitive** (`MyClass` ≠ `myclass`).
Class names conventionally start with an uppercase letter (**PascalCase**); methods too.
Curly braces `{}` define blocks of code (classes, methods, loops, conditionals).



4. Output
Console.WriteLine("Text");  // prints text and moves to a new line
Console.Write("Text");      // prints text, no new line
You can chain multiple `Write`/`WriteLine` calls; use `\n` for manual new lines inside a string.



5. Comments
// Single-line comment
/* Multi-line
   comment */



6. Variables
Declaring
int myNum = 5;
string myText = "Hello";

Declare then assign later:
int myNum;
myNum = 5;
```

Constants
Use `const` — value **cannot** be changed once set, and must be assigned when declared.
const int myNum = 15;

Display Variables
int x = 5;
Console.WriteLine(x);
Console.WriteLine("x = " + x);  // concatenation with +

Multiple Variables
int x = 5, y = 6, z = 50;
Console.WriteLine(x + y + z);

int x = 5, y = 6, z = 50; // same type, one line

// Assign the same value to multiple variables:
int x, y, z;
x = y = z = 50;

Identifiers (naming rules)
Can contain: letters, digits, underscores `_`.
Must **start** with a letter or underscore (not a digit).
Case-sensitive.
Cannot be a **reserved keyword** (e.g., `int`, `class`).



7. Data Types
| Type      | Size                             | Example  |
|-----------|----------------------------------|----------|
| `int`     | integer                          | `5`      |
| `double`  | floating point                   | `5.99d`  |
| `float`   | floating point                   | `5.99f`  |
| `char`    | single character (single quotes) | `'A'`    |
| `string`  | text (double quotes)             | `"Hello"`|
| `bool`    | true/false                       | `true`   |

Numeric types also include `long`, `short`, `byte`, `decimal`, etc.
`decimal` needs `m`/`M` suffix; `float` needs `f`/`F`; `double` can use `d`/`D` (optional, it's the default).



8. Type Casting
**Implicit** (automatic) — safe, no data loss (small → large type):
int myInt = 9;
double myDouble = myInt; // int -> double automatically

**Explicit** (manual) — needed when data may be lost (large → small type):
double myDouble = 9.78;
int myInt = (int) myDouble; // double -> int

**Conversion methods** (convert between types, incl. to/from string):
Convert.ToString(25);
Convert.ToDouble("25");
Convert.ToInt32("25");
Convert.ToInt64("25");



9. User Input
Console.WriteLine("Enter your name:");
string name = Console.ReadLine();
Console.WriteLine("Hello " + name);
`Console.ReadLine()` always returns a **string** — use `Convert.ToInt32()` etc. to read numbers.



10. Operators

Arithmetic
`+`  `-`  `*`  `/`  `%` (modulus)

Assignment
`=`  `+=`  `-=`  `*=`  `/=`  `%=`  `&=`  `|=`  `^=`  `>>=`  `<<=`

Comparison
`==`  `!=`  `>`  `<`  `>=`  `<=`

Logical
`&&` (and) `||` (or) `!` (not)



11. Math
Math.Max(x, y);
Math.Min(x, y);
Math.Sqrt(64);
Math.Abs(-4.7);
Math.PI;
Math.Round(9.99);



12. Strings
Basics
string greeting = "Hello";

Concatenation
string firstName = "John";
string lastName = "Doe";
string name = firstName + " " + lastName;
// or
string name2 = String.Concat(firstName, lastName);

Interpolation (`$`)
string name = "John";
string greeting = $"Hello, my name is {name}!";

Access / Special Methods
string myString = "Hello";
Console.WriteLine(myString.Length);       // length
Console.WriteLine(myString.ToUpper());
Console.WriteLine(myString.ToLower());
Console.WriteLine(" Hello World! ".Trim()); // removes whitespace ends
Console.WriteLine(myString[0]);           // access a character by index
string txt = "Please locate where 'locate' occurs!";
Console.WriteLine(txt.IndexOf("locate"));
string a = "Hello";
string b = "World";
Console.WriteLine(String.Concat(a, b));
```

### Special Characters (escape sequences)
| Code | Result |
|------|--------|
| `\'` | Single quote |
| `\"` | Double quote |
| `\\` | Backslash |
| `\n` | New line |
| `\t` | Tab |

---

## 13. Booleans
```csharp
bool isCSharpFun = true;
bool isFishTasty = false;
Console.WriteLine(10 > 9);  // returns true
```
- Any expression returning `true`/`false` is boolean; used heavily in conditions.

---

## 14. If...Else

```csharp
if (20 > 18)
{
    Console.WriteLine("20 is greater than 18");
}
else if (20 == 18)
{
    Console.WriteLine("20 equals 18");
}
else
{
    Console.WriteLine("20 is less than 18");
}
```

### Short Hand If (ternary operator)
```csharp
string result = (5 > 3) ? "Yes" : "No";
```
### Short Hand If-Else-If (nested ternary)
```csharp
string result = (a > b) ? "A" : (a == b) ? "Equal" : "B";
```

---

## 15. Switch
```csharp
int day = 4;
switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    default:
        Console.WriteLine("Not a listed day");
        break;
}
```

---

## 16. While Loop
```csharp
int i = 0;
while (i < 5)
{
    Console.WriteLine(i);
    i++;
}
```
### Do-While (runs at least once)
```csharp
int i = 0;
do
{
    Console.WriteLine(i);
    i++;
} while (i < 5);
```

---

## 17. For Loop

### Standard For Loop
```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}
```
- Three parts: **initialization**; **condition**; **increment/decrement**.

### Foreach Loop (iterate over a collection/array)
```csharp
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
foreach (string car in cars)
{
    Console.WriteLine(car);
}
```

---

## 18. Break / Continue
```csharp
for (int i = 0; i < 10; i++)
{
    if (i == 4) { break; }     // exits the loop entirely
    Console.WriteLine(i);
}

for (int i = 0; i < 10; i++)
{
    if (i == 4) { continue; }  // skips this iteration only
    Console.WriteLine(i);
}
```
- Both `break` and `continue` also work inside `while` loops.

---

## 19. Arrays
```csharp
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
```
- Declare without values (fixed size, set with `new`):
```csharp
int[] myNum = new int[4];
myNum[0] = 10;
myNum[1] = 20;
```
- Access elements by **index** (starts at 0):
```csharp
Console.WriteLine(cars[0]); // Volvo
```
- Change a value:
```csharp
cars[0] = "Opel";
```
- Get array length:
```csharp
Console.WriteLine(cars.Length);
```

---

### Quick Reference: Common Gotchas
- `ReadLine()` → always a `string`; cast/convert for math.
- `==` compares values; `=` assigns.
- Arrays are **zero-indexed** and (in this basic form) **fixed size**.
- `const` values must be set at declaration and never change.
- Use `$"{ }"` interpolation instead of `+` concatenation for cleaner code.