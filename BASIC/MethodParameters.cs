using System;

namespace BASIC
{
    class MethodParameters
    {
        //Method using params keywaord on an array parameters
        public void AddParams(params double[] args)
        {
            double sum = 0;
            foreach (double d in args)
                sum = sum + d;
            Console.WriteLine("Sum of given {0} nos is :{1}", args.Length, sum);
        }

        //Method with defaualt value parameters
        public void AddNums(int x, int y = 10, int z = 25)
        {
            Console.WriteLine("sum of given 3 number is:" + (x + y + z));
        }
        static void Main()
        {
            MethodParameters obj = new MethodParameters();
            //Calling aMethod which uses array as parameter with params keyword
            obj.AddParams();
            obj.AddParams(56.19);
            obj.AddParams(23.45, 78);
            obj.AddParams(10, 20, 30.23);
            obj.AddParams(23.11, 10, 20, 30);
            Console.WriteLine("---------------------------------------------");

            //Calling method with have default value parameter
            obj.AddNums(100);
            obj.AddNums(100, 100);
            obj.AddNums(100, 2, 100);
            obj.AddNums(100, 100, 100);
        }
    }
}
