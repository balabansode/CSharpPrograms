using System;

namespace BASIC
{
    class Program
    {
        //non value returning method without parameters
        public void Test1()         //static behaviour
        {
            int x = 5;
            for (int i = 0; i <= 10; i++)
                Console.WriteLine("{0}*{1}={2}",x, i, x * i);
        }

        //Non value Returning method with parameter
        public void Test2(uint x, uint y)
        {
            for (int i = 0; i <= y; i++)
                Console.WriteLine("{0}*{1}={2}", x, i, x * i);
        }

        //value returning method without parametre
        public string Test3()
        {
            string str = "Hello World";
            str = str.ToUpper();
            return str;
        }

        //Value Returning Methid With Parameter
        public string Test4(string str)  //Dynamic in behaviour
        {
            str = str.ToUpper();
            return str;
        }
        static void Main()
        {
            //Create Instance of Class
            Program p = new Program();

            //Call NonValue Returning Method
            p.Test1();
            Console.WriteLine();

            p.Test2(8,12);
            Console.WriteLine();


        //Call NOn Value Returning Method
            string s1=p.Test3();
            Console.WriteLine(s1);

            string s2 = p.Test4("india");
            Console.WriteLine(s2);
            Console.ReadLine();
        }
    }
}
