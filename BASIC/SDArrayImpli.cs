using System;

namespace BASIC
{
    class SDArrayImpli
    {
        static void Main()
        {
            var iarr = new[] { 10, 20, 30, 40, 50, 60, 70, 80 };
            Console.WriteLine(iarr.GetType());

            foreach (var i in iarr)
                Console.Write(i + " ");
            Console.WriteLine("\n");

            var darr = new[] { 12.34, 34.56, 56.78, 78.90, 01.23, 45.67, 78.90 };
            Console.WriteLine(darr.GetType());
            foreach (var i in darr)
                Console.Write(i + " ");
            Console.WriteLine("\n");

            var sarr = new[] { "red", "blue", "blackk", "white", "yellow" };
            Console.WriteLine(sarr.GetType());
            foreach (var i in sarr)
                Console.Write(i + " ");
            Console.WriteLine("\n");


        }
    }
}
