using System;

namespace _11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 12345678;
            int b = a / 1000000;
            int c = a % 1000000 / 10000;
            int d = a % 10000 / 100;
            int e = a % 100;
            int f = b + c + d + e;
            int G = int.Parse(f.ToString() + 99);
            double H = G - (G * 1.0 * 18 / 100);
            Console.WriteLine(H);
        }
    }
}
