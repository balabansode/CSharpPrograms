using System;

namespace BASIC
{
    class SDArray
    {
        static void Main()
        {
            int x = 0;
            int[] arr = new int[6];
            //Accessing value of SDArray by using FOR Loop
            for (int i  = 0; i < 6; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();

            //Assinging the value to a SDArray by using FOR Loop
            for (int i = 0; i < 6; i++)
            {
                x += 10;
                arr[i] = x;
                Console.Write(arr[i] + " ");
            }
            //Accesing value of SDArray by using Foreach loop
            foreach (int i in arr)
                Console.Write(i + " ");
            Console.WriteLine();

        }
    }
}
