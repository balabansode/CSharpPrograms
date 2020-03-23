using System;

namespace BASIC
{
    class TableReturn
    {
        static void Main()
        {
            Console.Clear();
            Console.Write("Enter An Integer Value:");
            int x = int.Parse(Console.ReadLine());

            if (x == 0)
                return;
            for (int i = 1; i <= 10; i++)
                Console.WriteLine("{0}*{1}={2}",x,i,x*i);
        }
    }
}
