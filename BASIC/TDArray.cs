using System;

namespace BASIC
{
    class TDArray
    {
        static void Main()
        {
            /* Assigning the value of two dimentional array At a Time of Declaration
              int[,] arr={
                           {5,10,15,20},
                           {20,25,30,35},
                           {40,45,50,55},
                           {60,65,70,75}
                           }
             */
            int x = 0;
            int[,] arr = new int[4, 5];
            Console.Clear();
            Console.WriteLine("Rows:" + arr.GetLength(0));
            Console.WriteLine("Coloms:" + arr.GetLength(1));
            Console.WriteLine("Cells:" + arr.Length);

            //Accessing the TDArray by using Foreach loop
            foreach (int i in arr)
                Console.Write(i + " ");
            Console.WriteLine();

            //Assigning the value to TDArray by using nested for loop
            for(int i=0; i<arr.GetLength(0); i++)
            {
                for(int j=0; j<arr.GetLength(1); j++)
                {
                    x += 5;
                    arr[i, j] = x;
                }
            }

            //Accesing the value of TDArray by using the nested for loop
            for(int i=0; i<arr.GetLength(0);i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write(arr[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}
