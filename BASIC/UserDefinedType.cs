using System;

namespace BASIC
{
    class Emp    //user defined type
    {
        public int eno;
        public string name, job;
        public double sallary;
        public bool status;
    }
    class UserDefinedType
    {
        public Emp GetEmpDetails(int eno)
        {
            Emp e = new Emp();
            e.eno = eno;
            e.name = "Balaji";
            e.job = "Engineer";
            e.sallary = 100000.00;
            e.status = true;
            return e;
        }
        static void Main()
        {
            UserDefinedType udt = new UserDefinedType();
            Emp obj = udt.GetEmpDetails(1008);
            Console.WriteLine(obj.eno + " " + obj.name + " " + obj.job + " " + obj.sallary + " " + obj.status);
            Console.ReadLine();
        }
    }
}
