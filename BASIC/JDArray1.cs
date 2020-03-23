using System;

namespace BASIC
{
    class JDArray1
    {
        static void Main()
        {
            int[][] arr = new int[2][];  //declaration of jagged array

            arr[0] = new int[] { 11, 21, 31, 41 };     //initialization of array
            arr[1] = new int[] { 10, 20, 30, 40, 50, 60, 70 };

            for(int i=0;i<arr.Length;i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                   System.Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
            

        }
    }
}
