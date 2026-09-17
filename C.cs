using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number: ");
            String stringg = (Console.ReadLine());
            lengthh = Convert.ToInt32(stringg);
            int length = lengthh.Length;
            int reverse = "";
            reversee = Convert.ToString(reverse);

            for(int i = length; i >= 1; i--)
            {
                int reverse += lengthh[i];
            }
            if reversee == lengthh
            {
                Console.WriteLine("Palindrome indeed");
            }            
        }
    }
}

