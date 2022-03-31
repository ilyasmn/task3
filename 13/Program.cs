using System;

namespace _13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 12345; int d = a / 10000; int e = a %10;
            //int w = int.Parse(d.ToString() + e.ToString()); 

            //int b = 23456; int f = b / 10000; int g = b % 10;
            //int x = int.Parse(f.ToString() + g.ToString());

            //int c = 34567; int h = c / 10000; int i = c % 10;
            //int y = int.Parse(h.ToString() + i.ToString());

            //int z = w + x + y;   double m = z * 1.5;
            //Console.WriteLine(m);   

            int[] eded = { 12345, 23456, 34567 }; int uzunluq = eded.Length; int sum = 0;
            for (int i = 0; i < uzunluq; i++)
            {
                int d = eded[i] / 10000; int e = eded[i] % 10;
                int w = int.Parse(d.ToString() + e.ToString()); sum = sum + w;
            }
            double x = sum * 1.5; Console.WriteLine(x);


        }
    }
}
