using System;
using System.Collections.Generic;
using System.Text;

namespace BASIC
{
    class JDArray2
    {
        static void Main()
        {
            //declaration and initialization of array
            int[][] arr = new int[3][] {
                                       new int[] {11,21,31,41,51,61},
                                       new  int[]{10,20,30,40,},
                                       new int[]{11,22,33,}
            };
            for(int i=0;i<arr.Length;i++)
            {
                for(int j=0; j<arr[i].Length;j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
