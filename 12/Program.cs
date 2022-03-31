using System;

namespace _12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 12345, sum = 0, b = 0; int m = a % 10;
            while (a != 0) { b = a % 10; sum = sum + b; a = a / 10; }

            int c = 67891, hasil = 1, d = 0;
            while (c != 0) { d = c % 10; hasil = hasil * d; c = c / 10; }

            int n = sum + hasil; int z = int.Parse(n.ToString() + m.ToString());
            Console.WriteLine(z);
        }
    }
}
