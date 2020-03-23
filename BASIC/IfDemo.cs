using System;

namespace BASIC
{
    class IfDemo
    {
        static void Main()
        {
            Console.Write("Enter 1st Number:");
            double d1 = double.Parse(Console.ReadLine());

            Console.Write("Enter 2nd Number:");
            double d2 = double.Parse(Console.ReadLine());

            if (d1 > d2)
                Console.WriteLine("First number is greater than second");
            else if (d1 < d2)
                Console.WriteLine("second number is greater ");
            else
                Console.WriteLine("Both number are Eqaul");
        }
    }
}
