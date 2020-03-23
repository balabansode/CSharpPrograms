using System;

namespace BASIC
{
    class JDArray
    {
        static void Main()
        {
            int[][] arr = new int[4][];
            arr[0] = new int[5];
            arr[1] = new int[6];
            arr[2] = new int[8];
            arr[3] = new int[4];

            //Accessing the value of jagged array by using nested foreach loop
            foreach(int[] iarr in arr)
            {
                foreach(int i in iarr)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------------------------");

            //Accessing value of jagged array by using for in foreach loop
            foreach(int[] iarr in arr)
            {
                for (int i = 0; i < iarr.Length; i++)
                    Console.Write(iarr[i]+" ");
                Console.WriteLine();

            }
            //Assigning the value to jagged array by using for in foreach loop
            foreach(int[] iarr in arr)
            {
                for(int i=0;i<iarr.Length;i++)
                {
                    iarr[i] = i + 1;
                }
            }
            Console.WriteLine("-----------------------------------------");
            //Accessing the value of jagged array by using nested for loop
            for(int i=0;i<arr.GetLength(0);i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                    Console.Write(arr[i][j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------------------");

            //Assigning the value of jagged array by using nested for loop
            for(int i=0;i<arr.GetLength(0);i++)
            {
                for(int j=0;j<arr[i].Length;j++)
                {
                    arr[i][j] = i + 1;
                }
            }
            Console.WriteLine("-----------------------------------------------");

            //Accessing the value of jagged arrayby using foreach in for loop
            for (int i= 0;i < arr.GetLength(0);i++)
            {
                foreach (int x in arr[i])
                    Console.Write(x + " ");
                Console.WriteLine();
            }
            Console.WriteLine("------------------------------------------");
        }
    }
}
