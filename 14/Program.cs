using System;

namespace _14
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] eded = { 242424, 242424, 242424, 8886666 };
            int uz = eded.Length; int sumi = 0; int sumu = 0;
            for (int i = 0; i < uz; i++)

            {
                if (eded[i] < 1000000)
                {
                    int a = eded[i] / 1000; sumi = sumi + a;
                    Console.WriteLine(sumi);
                }

                else
                {
                    int b = eded[i] % 10000; sumu = sumu + b; Console.WriteLine(sumu);

                    Console.WriteLine(sumu + sumi);

                    int c = eded[i] / 1000000;
                    int d = eded[i] % 1000000 / 100000;
                    int e = eded[i] % 100000 / 10000;
                    int f = c * d * e;
                    int g = sumi + sumu - f;
                    Console.WriteLine(g);
                    double tt = 0.6 * g; Console.WriteLine(tt);
                    double dd = double.Parse(tt.ToString() + 60);
                    Console.WriteLine(dd);
                    double zz = dd * 0.82;
                    Console.WriteLine(zz);
                }
            }
        }
    }
}
