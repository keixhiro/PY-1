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



# C# Cheat Sheet — Methods to Exceptions
*(Covers w3schools.com/cs from "C# Methods" through "C# Exceptions")*



1. Methods
static void MyMethod()
{
  Console.WriteLine("I just got executed!");
}

static void Main(string[] args)
{
  MyMethod();   // call the method
}

A method is a block of code that only runs when called.
`static void MethodName() { }` — basic declaration.



2. Method Parameters
Parameters
static void MyMethod(string fname, int age)
{
  Console.WriteLine(fname + " Refsnes, " + age);
}
static void Main(string[] args)
{
  MyMethod("Liam", 5);
  MyMethod("Jenny", 9);
}
Parameters go inside `()`; multiple parameters are comma-separated: `MyMethod(string fname, int age)`.
**Parameter** = the variable listed in the method definition; **Argument** = the value passed in when calling.

Default Parameter Value
static void MyMethod(string country = "Norway")
{
  Console.WriteLine(country);
}
static void Main(string[] args)
{
  MyMethod("Sweden");
  MyMethod();          // uses default "Norway"
}

Return Values

static int MyMethod(int x)
{
  return 5 + x;
}
static void Main(string[] args)
{
  Console.WriteLine(MyMethod(3));   // 8
}
```dddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd
- `void` = no return value. Any other type (e.g. `int`, `string`) requires a `return` statement.

### Named Arguments
```csharp
static void MyMethod(string child1, string child2, string child3)
{
  Console.WriteLine(child1 + " " + child2 + " " + child3);
}
static void Main(string[] args)
{
  MyMethod(child3: "Anne", child1: "John", child2: "Liz");
  // order doesn't matter when arguments are named
}
```

---

## 3. Method Overloading
```csharp
static int PlusMethod(int x, int y) { return x + y; }
static double PlusMethod(double x, double y) { return x + y; }

static void Main(string[] args)
{
  int myNum1 = PlusMethod(8, 5);
  double myNum2 = PlusMethod(4.3, 6.26);
}
```
- Multiple methods can share the same name if their **parameter lists differ** (type/number).

---

## 4. OOP (Object-Oriented Programming)
- Core concepts: **Class**, **Object**, **Encapsulation**, **Inheritance**, **Polymorphism**, **Abstraction**.
- Benefits: faster/easier to code, more maintainable, reusable, and secure.

---

## 5. Classes and Objects

```csharp
class Car
{
  public string color = "red";
}

class Program
{
  static void Main(string[] args)
  {
    Car myObj = new Car();
    Console.WriteLine(myObj.color);   // red
  }
}
```
- A **class** is a template for objects; an **object** is an instance of a class.

### Multiple Objects
```csharp
Car obj1 = new Car();
obj1.color = "red";

Car obj2 = new Car();
obj2.color = "blue";
```
- Each object has its own copy of the class's fields, independent of others.

---

## 6. Class Members
- **Fields** (variables inside a class) and **methods** (functions inside a class) are collectively called **class members**.
```csharp
class Car
{
  public string model = "Mustang";   // field
  public static void Honk()          // method
  {
    Console.WriteLine("Tuut, tuut!");
  }
}
```

---

## 7. Constructors
```csharp
class Car
{
  public string model;
  public Car(string modelName)   // constructor
  {
    model = modelName;
  }
}
static void Main(string[] args)
{
  Car myObj = new Car("Mustang");
  Console.WriteLine(myObj.model);   // Mustang
}
```
- A constructor has the **same name as the class** and no return type.
- Runs automatically when an object is created; commonly used to set initial values for fields.

---

## 8. Access Modifiers
| Modifier | Description |
|---|---|
| `public` | accessible from anywhere |
| `private` | accessible only within the same class (default if unspecified) |
| `protected` | accessible within the class and by derived classes |
| `internal` | accessible only within the same assembly/project |

```csharp
class Car
{
  private string model = "Mustang";  // only accessible inside Car
}
```

---

## 9. Properties
```csharp
class Person
{
  private string name;    // private field ("backing field")

  public string Name      // public property
  {
    get { return name; }
    set { name = value; }
  }
}
static void Main(string[] args)
{
  Person myObj = new Person();
  myObj.Name = "Liam";
  Console.WriteLine(myObj.Name);
}
```
- Properties provide controlled access (get/set) to private fields — a form of **encapsulation**.

### Auto-Implemented Properties (shorthand)
```csharp
class Person
{
  public string Name { get; set; }   // no backing field needed
}
```

---

## 10. Inheritance
```csharp
class Vehicle          // base class (parent)
{
  public string brand = "Ford";
  public void Honk() { Console.WriteLine("Tuut, tuut!"); }
}

class Car : Vehicle    // derived class (child)
{
  public string modelName = "Mustang";
}

static void Main(string[] args)
{
  Car myCar = new Car();
  myCar.Honk();                    // inherited from Vehicle
  Console.WriteLine(myCar.brand + " " + myCar.modelName);
}
```
- `: ` denotes inheritance — `class Child : Parent`.
- Use `sealed` before `class` to prevent a class from being inherited: `sealed class Vehicle { }`

---

## 11. Polymorphism
```csharp
class Animal
{
  public virtual void animalSound() { Console.WriteLine("The animal makes a sound"); }
}
class Pig : Animal
{
  public override void animalSound() { Console.WriteLine("The pig says: wee wee"); }
}
class Dog : Animal
{
  public override void animalSound() { Console.WriteLine("The dog says: bow wow"); }
}

static void Main(string[] args)
{
  Animal myAnimal = new Animal();
  Animal myPig = new Pig();
  Animal myDog = new Dog();

  myAnimal.animalSound();
  myPig.animalSound();
  myDog.animalSound();
}
```
- `virtual` (base class) + `override` (derived class) let a child class provide its own version of an inherited method.

---

## 12. Abstraction
```csharp
abstract class Animal
{
  public abstract void animalSound();   // no body — must be overridden
  public void sleep() { Console.WriteLine("Zzz"); }   // regular method
}

class Pig : Animal
{
  public override void animalSound() { Console.WriteLine("The pig says: wee wee"); }
}
```
- `abstract class` **cannot be instantiated** (`new Animal()` is not allowed).
- `abstract` methods have no body and **must** be overridden in a derived (non-abstract) class.
- Used to hide unnecessary implementation details and only expose essentials.

---

## 13. Interface
```csharp
interface IAnimal        // interface names conventionally start with "I"
{
  void animalSound();    // no body; implicitly public/abstract
}

class Pig : IAnimal
{
  public void animalSound() { Console.WriteLine("The pig says: wee wee"); }
}
```
- All interface members are implicitly `public` and `abstract`; a class **must** implement every method.
- Use `:` for a class to implement an interface (same syntax as inheritance).
- Unlike `abstract class`, an interface can't contain fields, constructors, or method bodies.

### Multiple Interfaces
```csharp
interface IFirstInterface { void myMethod(); }
interface ISecondInterface { void myOtherMethod(); }

class DemoClass : IFirstInterface, ISecondInterface
{
  public void myMethod() { Console.WriteLine("Some text.."); }
  public void myOtherMethod() { Console.WriteLine("Some other text..."); }
}
```
- A class **can** implement multiple interfaces (comma-separated) — unlike single-class inheritance.

---

## 14. Enums
```csharp
enum Level
{
  Low,      // 0
  Medium,   // 1
  High      // 2
}
static void Main(string[] args)
{
  Level myVar = Level.Medium;
  Console.WriteLine(myVar);            // Medium
  Console.WriteLine((int)myVar);       // 1
}
```
- `enum` = a special "class" for a set of named constants; underlying values default to `int`, starting at 0.
- Often used inside a `switch` statement to check corresponding values.

---

## 15. Files
```csharp
using System.IO;

// Write to a file (creates or overwrites)
string writeText = "Hello World!";
File.WriteAllText("filename.txt", writeText);

// Read from a file
string readText = File.ReadAllText("filename.txt");
Console.WriteLine(readText);

// Delete a file
File.Delete("filename.txt");

// Check if a file exists
if (File.Exists("filename.txt")) { /* ... */ }

// Create a file/directory
File.Create("filename.txt");
Directory.CreateDirectory("MyDirectory");
```
- Requires `using System.IO;`.
- Common `File` methods: `WriteAllText()`, `ReadAllText()`, `Delete()`, `Exists()`, `Create()`.

---

## 16. Exceptions (Try...Catch)

```csharp
try
{
  int[] myNumbers = {1, 2, 3};
  Console.WriteLine(myNumbers[10]);   // triggers an error
}
catch (Exception e)
{
  Console.WriteLine(e.Message);       // or your own custom message
}
finally
{
  Console.WriteLine("The 'try catch' is finished.");
}
```
- `try` — code to test for errors.
- `catch (Exception e)` — code that runs if an error occurs; `e.Message` gives the built-in error description.
- `finally` — always runs after try/catch, regardless of outcome.

### The `throw` Keyword
```csharp
static void checkAge(int age)
{
  if (age < 18)
  {
    throw new ArithmeticException("Access denied - You must be at least 18 years old.");
  }
  else
  {
    Console.WriteLine("Access granted - You are old enough!");
  }
}
```
- `throw` raises a custom exception, paired with a built-in exception class (`ArithmeticException`, `FileNotFoundException`, `IndexOutOfRangeException`, `TimeOutException`, etc.).

---

### Quick Reference: Common Gotchas
- `void` methods return nothing; any other return type **must** `return` a value of that type.
- Overloading = same method name, **different parameter signature**.
- Constructor name **must exactly match** the class name, no return type (not even `void`).
- `private` is the default access level if you omit a modifier.
- `abstract class` can mix implemented + abstract methods; `interface` cannot implement any method body.
- A class can inherit from only **one** base class, but implement **multiple** interfaces.
- `virtual`/`override` pair enables polymorphism; without `virtual`, a derived method just hides the base one.
- Always wrap risky code (file access, array bounds, parsing) in `try/catch` to avoid crashing the program.