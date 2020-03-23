using System;

namespace BASIC
{
    class TestProgram
    {
        public void CallMethod()
        {
            Program p = new Program();
            p.Test1();
            Console.WriteLine();
            p.Test2(3, 6);
            Console.WriteLine();

            Console.WriteLine(p.Test3());
            Console.WriteLine(p.Test4("america"));
        }
        static void Main()
        {
            //Creating an unnamed instance and Calling the method
           new TestProgram().CallMethod();
            Console.ReadLine();
        }
    }
}
