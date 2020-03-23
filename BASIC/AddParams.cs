using System;

namespace BASIC
{
    class AddParams
    {
        static void Main(string[] args)
        {
            double sum = 0;
            foreach (string str in args)
                Console.WriteLine("sum of given {0} no is:{1}", args.Length, sum);

        }
    }
}
