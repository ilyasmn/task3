using System;

namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 12345678;

            int b = a / 10;
            int c = b % 1000000;
            Console.WriteLine(c);

        }
    }
}
