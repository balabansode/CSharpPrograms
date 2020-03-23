using System;

namespace BASIC
{
    class SDArrayClass
    {
        static void Main()
        {
            int[] arr = { 12, 81, 34, 11, 17, 46, 36, 92, 28, 23, 43, 76 };
            for(int i = 0; i<arr.Length; i++)
            Console.Write(arr[i] + " ");
            Console.WriteLine();

            Array.Sort(arr);
            foreach (int i in arr)
                Console.Write(i + " ");
            Console.WriteLine();

            Array.Reverse(arr);
            foreach (int i in arr)
                Console.Write(i + " ");
            Console.WriteLine();

            int[] brr = new int[10];
            Array.Copy(arr, brr,7);
            foreach (int i in arr)
                Console.Write(i + " ");
            Console.WriteLine();

        }
    }
}
