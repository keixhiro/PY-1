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

3. Output
Console.WriteLine("Text");  // prints text and moves to a new line
Console.Write("Text");      // prints text, no new line
You can chain multiple `Write`/`WriteLine` calls; use `\n` for manual new lines inside a string.



4. Comments
// Single-line comment
/* Multi-line
   comment */



5. Variables
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



6. Data Types
| Type      | Size                             | Example  |
|-----------|----------------------------------|----------|
| `int`     | integer                          | `5`      |
| `double`  | floating point                   | `5.99d ` |
| `float`   | floating point                   | `5.99f`  |
| `char`    | single character (single quotes) | `'A'`    |
| `string`  | text (double quotes)             | `"Hello"`|
| `bool`    | true/false                       | `true`   |

Numeric types also include `long`, `short`, `byte`, `decimal`, etc.
`decimal` needs `m`/`M` suffix; `float` needs `f`/`F`; `double` can use `d`/`D` (optional, it's the default).



7. Type Casting
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



8. User Input
Console.WriteLine("Enter your name:");
string name = Console.ReadLine();
Console.WriteLine("Hello " + name);
`Console.ReadLine()` always returns a **string** — use `Convert.ToInt32()` etc. to read numbers.



9. Operators

Arithmetic
`+`  `-`  `*`  `/`  `%` (modulus)

Assignment
`=`  `+=`  `-=`  `*=`  `/=`  `%=`  `&=`  `|=`  `^=`  `>>=`  `<<=`

Comparison
`==`  `!=`  `>`  `<`  `>=`  `<=`

Logical
`&&` (and) `||` (or) `!` (not)



10. Math
Math.Max(x, y);
Math.Min(x, y);
Math.Sqrt(64);
Math.Abs(-4.7);
Math.PI;
Math.Round(9.99);



11. Strings
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

// Full name
string name = "John Doe";
// Location of the letter D
int charPos = name.IndexOf("D");
// Get last name
string lastName = name.Substring(charPos);
// Print the result
Console.WriteLine(lastName);



Special Characters (escape sequences)
| Code | Result       |
|------|--------------|
| `\'` | Single quote |
| `\"` | Double quote |
| `\\` | Backslash    |
| `\n` | New line     |
| `\t` | Tab          |
| `\b` | Backspace    |



12. Booleans
bool isCSharpFun = true;
bool isFishTasty = false;
Console.WriteLine(10 > 9);  // returns true
Any expression returning `true`/`false` is boolean; used heavily in conditions.



13. If...Else
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

Short Hand If (ternary operator)
string result = (5 > 3) ? "Yes" : "No";

Short Hand If-Else-If (nested ternary)
string result = (a > b) ? "A" : (a == b) ? "Equal" : "B";



14. Switch
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



15. While Loop
int i = 0;
while (i < 5)
{
    Console.WriteLine(i);
    i++;
}

Do-While (runs at least once)
int i = 0;
do
{
    Console.WriteLine(i);
    i++;
} while (i < 5);



16. For Loop
Standard For Loop
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}

Three parts: **initialization**; **condition**; **increment/decrement**.

Foreach Loop (iterate over a collection/array)
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
foreach (string car in cars)
{
    Console.WriteLine(car);
}



17. Break / Continue
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

Both `break` and `continue` also work inside `while` loops.



18. Arrays
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};

Declare without values (fixed size, set with `new`):
int[] myNum = new int[4];
myNum[0] = 10;
myNum[1] = 20;

Access elements by **index** (starts at 0):
Console.WriteLine(cars[0]); // Volvo

Change a value:
cars[0] = "Opel";

Get array length:
Console.WriteLine(cars.Length);



19. Loop Through an Array
`for` loop + `Length`
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
for (int i = 0; i < cars.Length; i++)
{
  Console.WriteLine(cars[i]);
}

`foreach` loop
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
foreach (string i in cars)
{
  Console.WriteLine(i);
}



20. Sort Arrays
`Array.Sort()`
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
Array.Sort(cars);
foreach (string i in cars) { Console.WriteLine(i); }
// Alphabetical order

int[] myNumbers = {5, 1, 8, 9};
Array.Sort(myNumbers);
foreach (int i in myNumbers) { Console.WriteLine(i); }
// Ascending order: 1, 5, 8, 9


`System.Linq` Namespace — `Min`, `Max`, `Sum`
```csharp
using System;
using System.Linq;

int[] myNumbers = {5, 1, 8, 9};
Console.WriteLine(myNumbers.Max());  // 9 - largest value
Console.WriteLine(myNumbers.Min());  // 1 - smallest value
Console.WriteLine(myNumbers.Sum());  // 23 - sum of all elements

- Requires `using System.Linq;` at the top of the file.



21. Multidimensional Arrays
A multidimensional array is essentially an **array of arrays**.
Used to store tabular data — rows and columns.
Most common: **two-dimensional (2D)** arrays.

Create a 2D Array
int[,] numbers = { {1, 4, 2}, {3, 6, 8} };
`[,]` — one comma = 2D array. `[,,]` (two commas) = 3D array.

Loop Through a 2D Array
**`foreach`** (simplest — visits every element):
int[,] numbers = { {1, 4, 2}, {3, 6, 8} };
foreach (int i in numbers)
{
  Console.WriteLine(i);
}

**Nested `for`** (needed when you care about row/column position):
int[,] numbers = { {1, 4, 2}, {3, 6, 8} };

for (int i = 0; i < numbers.GetLength(0); i++)      // rows
{
  for (int j = 0; j < numbers.GetLength(1); j++)    // columns
  {
    Console.WriteLine(numbers[i, j]);
  }
}
