using System;

namespace BASIC
{
    class OutputParameters
    {
        //--->Before C#7.0
        public void Math1(int a, int b, out int c, out int d)
        {
            c = a + b;
            d = a * b;
        }

        //---->FROM C#7.0
        public (int, int) Math2(int a, int b)
        {
            int c = a + b;
            int d = a * b;
            return (c, d);
        }
        static void Main()
        {
            OutputParameters obj = new OutputParameters();
            //----->Before c#7.0
            int sum1, product1;
            obj.Math1(100, 50, out sum1, out product1);
            Console.WriteLine("sum of given no is :" + sum1);
            Console.WriteLine("product of given no is:" + product1);
            Console.WriteLine("------------------------------------------------");


            //--->FROMC#7.0
            obj.Math1(10, 20, out int sum2, out int product2);
            Console.WriteLine("sum of given no is :" + sum2);
            Console.WriteLine("product of given no is:" + product2);
            Console.WriteLine("------------------------------------------------");


            var (sum3, product3) = obj.Math2(200, 100);
            Console.WriteLine("sum of given no is :" + sum3);
            Console.WriteLine("product of given no is:" + product3);
            Console.WriteLine("------------------------------------------------");


            (int sum4, int product4) = obj.Math2(300, 10);
            Console.WriteLine("sum of given no is :" + sum4);
            Console.WriteLine("product of given no is:" + product4);
            Console.WriteLine("------------------------------------------------");
        }
    }
}
