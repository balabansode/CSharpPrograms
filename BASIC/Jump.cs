using System;

namespace BASIC
{
    class Jump
    {
        //Break statment
        static void Main()
        {
            int i;
            for (i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
                if (i == 5)
                    break;
            }
            Console.WriteLine("End of the loop break");

            //Continue statment
            for (i = 1; i <= 10; i++)
            {
                if (i == 7 || i == 5)
                    continue;
                Console.WriteLine(i);
            }
            Console.WriteLine("End od the loop continue");

        }
    }
}
