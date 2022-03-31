using System;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 123456789;

            int b = a % 1000000 / 100000;
            int c = a % 100000 / 10000;
            int d = a % 10000 / 1000;
            Console.WriteLine(b + c + d);
        }
    }
}
