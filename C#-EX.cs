using System;

namespace HelloWorld
{
    class Program
    {
        static void MyMethod(string fname, int age)
        {
            Console.WriteLine(fname + " Refsnes, " + age);
        }
        static void Main(string[] args)
        {
            MyMethod("Liam", 5);
            MyMethod("Jenny", 10);
        }
    }
}
