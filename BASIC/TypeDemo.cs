using System;
using System.Collections.Generic;
using System.Text;

namespace BASIC
{
    class TypeDemo
    {
        static int x;
        static void Main()
        {
            Console.WriteLine(x);
            Console.WriteLine(x.GetType());

            int y = 100;
            Console.WriteLine(y);
            Console.WriteLine(y.GetType());

            float f = 3.14f;
            Console.WriteLine(f);
            Console.WriteLine(f.GetType());

            double d = 45.67;
            Console.WriteLine(d);
            Console.WriteLine(d.GetType());

            decimal de = 123.456m;
            Console.WriteLine(de);
            Console.WriteLine(de.GetType());

            Console.ReadLine();
        }
    }
}
