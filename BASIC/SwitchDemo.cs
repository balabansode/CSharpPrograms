using System;

namespace BASIC
{
    class SwitchDemo
    {
        static void Main()
        {
            Console.WriteLine("Enter student Number(1-3):");
            int sno = int.Parse(Console.ReadLine());

            switch (sno)
            {
                case 1:
                    Console.WriteLine("Student1");
                    break;

                case 2:
                    Console.WriteLine("Student2");
                    break;

                case 3:
                    Console.WriteLine("Student3");
                    break;

                default:
                    Console.WriteLine("No student exist with given number");
                    break;
            }
        }
    }
}
