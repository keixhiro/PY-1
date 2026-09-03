using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "John";
            string lastName = "Doe";
            string name2 = String.Concat(firstName, lastName);
            Console.WriteLine(name2);
        }   


    }
}
