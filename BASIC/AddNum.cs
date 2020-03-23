using System;

namespace BASIC
{
    class AddNum
    {
        static void Main()
        {
            int x, y, z;
            Console.Write("Enter First Number:");
            string s1 = Console.ReadLine();
            x = int.Parse(s1);

            Console.Write("Enter Second Number:");
            string s2 = Console.ReadLine();
            y = int.Parse(s2);

            z = x + y;

            Console.WriteLine("Sum of {0} & {1} is {2}", x, y, z);
        }
    }
}
