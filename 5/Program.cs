using System;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 123456;

            int b = a / 100000;
            int c = a % 100000;
            int d = int.Parse(c.ToString() + b.ToString());

            Console.WriteLine(d);
        }
    }
}
