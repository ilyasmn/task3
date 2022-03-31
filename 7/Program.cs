using System;

namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1234, tersa = 0, b = 0;

            while (a != 0)
            {
                b = a % 10;
                tersa = tersa * 10 + b;
                a = a / 10;
            }
            Console.Write(tersa);
        }
    }
}
