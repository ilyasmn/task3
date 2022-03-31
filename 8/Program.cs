using System;

namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 123456789;
            int b = a % 1000;
            int c = b / 100;
            int d = a % 10;
            int e = c + d;
            Console.WriteLine(e);
        }
    }
}
