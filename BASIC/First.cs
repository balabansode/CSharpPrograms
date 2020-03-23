using System;

namespace BASIC
{
    class First
    {
        public int x = 0;
        static void Main()
        {
            First f;           //f is veriable of class
            f = new First();  // f is instance of class
            Console.WriteLine(f.x);

            First f1 = new First();
            First f2 = new First();
            Console.WriteLine(f1.x + " " + f2.x);

            f1.x = 300;
            Console.WriteLine(f1.x + " " + f2.x);

            f2.x = 200;
            Console.WriteLine(f1.x + " " + f2.x);

            First f3 = new First();
            First f4 = f3;
            Console.WriteLine(f3.x + " " + f4.x);
            f3.x = 100;
            Console.WriteLine(f3.x + " " + f4.x);
            f4.x = 200;
            Console.WriteLine(f3.x + " " + f4.x);
            f3.x =888888888;
           // Console.WriteLine(f3.x + " " + f4.x);
            Console.WriteLine(f4.x);



            Console.ReadLine();
        }
    }
}
