using System;

namespace _9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 123456789;
            int b = a / 100000000; int c = a % 10000000 / 1000000;
            int d = a % 100000 / 10000; int e = a % 1000 / 100; int f = a % 10;
            int g = int.Parse(b.ToString() + c.ToString() + d.ToString() + e.ToString() + f.ToString());
            Console.WriteLine(g);
        }
    }
}
