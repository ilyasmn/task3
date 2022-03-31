using System;

namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 123456789;

            int b = a / 100000000; int c = a % 10000000 / 1000000;
            int d = a % 100000 / 10000; int e = a % 1000 / 100; int f = a % 10;
            int g = int.Parse(b.ToString() + c.ToString() + d.ToString() + e.ToString() + f.ToString());

            int bb = a % 100000000 / 10000000; int cc = a % 1000000 / 100000;
            int dd = a % 10000 / 1000; int ee = a % 100 / 10;
            int gg = int.Parse(bb.ToString() + cc.ToString() + dd.ToString() + ee.ToString());

            Console.WriteLine(g + gg);

        }
    }
}
