using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            int name1 = Convert.ToInt32(name);
            int y = 587 + name1;
            Console.WriteLine(y);
        }
    }
}

