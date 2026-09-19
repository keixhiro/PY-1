using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number: ");
            String str = (Console.ReadLine());
            int length = str.Length;
            string rev = "";

            for(int i = length - 1; i >= 0; i--)
            {
                rev += str[i];
            }
            if (rev == str)
            {
                Console.WriteLine("Palindrome indeed");
            } else
            {
                Console.WriteLine("Ehh.");
            }
        }
    }
}