using System;

namespace BASIC
{
    class AddNum1
    {
        static void Main()
        {
            Console.Write("Enter 1st Number:");
            string s1 = Console.ReadLine();
            double d1 = double.Parse(s1);

            Console.Write("Enter 2nd Number:");
            string s2 = Console.ReadLine();
            double d2 = double.Parse(s2);

            double d3 = d1 + d2;

            Console.WriteLine("Sum  of {0} And {1} is {2}", d1, d2, d3);
            Console.Read();
        }
    }
}
