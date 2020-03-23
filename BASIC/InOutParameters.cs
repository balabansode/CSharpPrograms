using System;

namespace BASIC
{
    class InOutParameters
    {
        //defining the with inout parameter
        public void Factorial(ref uint fact)
        {
            if (fact == 0 || fact == 1)
                fact = 1;
            else
            {
                uint result = 1;
                for(uint i=2;i<=fact;i++)
                {
                    result = result * i;
                }
                fact = result;
            }
        }
       static void Main()
        {
            InOutParameters p = new InOutParameters();
            uint num = 8;
            Console.WriteLine("Factorial of {0} is:", num);
            p.Factorial(ref num);
            Console.WriteLine(num);
            Console.WriteLine();
        }
    }
}
