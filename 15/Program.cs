using System;

namespace _15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 122; int b = 101; int c = 122211; int d = 222111; int e = 2226444;

            int be = e / 1000000; int ce = e % 100000 / 10000;
            int de = e % 1000 / 100; int fe = e % 10;
            int ge = int.Parse(be.ToString() + ce.ToString() + de.ToString() + fe.ToString());
            Console.WriteLine(ge);

            int f = a + b; int g = f % 100; int h = g * g; Console.WriteLine(h);

            int i = int.Parse(a.ToString() + b.ToString()); int j = i + h; Console.WriteLine(j);


            int k = e % 100000; int l = j - k; Console.WriteLine(l);

            int m = c + d; int n = m % 1000; Console.WriteLine(n);

            int xs = n + l;

            Console.WriteLine(xs);

            int sum = 0;
            while (e != 0)
            { sum = sum + e % 10; e = e / 10; }


            int terssum = 0; int bb = 0;
            while (sum != 0)
            {
                bb = sum % 10;
                terssum = terssum * 10 + bb;
                sum = sum / 10;
            }


            int op = xs + terssum; Console.WriteLine(op);


            int hh = int.Parse(op.ToString() + 11); Console.WriteLine(hh);

            int ot = hh - ge; Console.WriteLine(ot);

            int ta = ot / 10;
            int tta = ot % 10;


            //cavab

            int last = int.Parse(ta.ToString() + 88 + tta.ToString());
            Console.WriteLine(last);



        }
    }
}
