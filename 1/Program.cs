using System;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 1234; int sum = 0;
            while (a != 0)
            {
                sum += a % 10;
                a /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
