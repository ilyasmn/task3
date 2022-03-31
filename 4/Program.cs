using System;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 12345;

            int b = a / 10000;
            int c = a % 10;
            int d = (c + b) * (c + b);
            Console.WriteLine(d);
        }
    }
}
