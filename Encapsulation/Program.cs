using System;

namespace Encapsulation
{
    public class Department
    {
        public string departname;
        public string Departname
        {
            get
            {
                return departname;
            }
            set
            {
                departname = value;
            }
        }
    }
    public class Departmentmain
    {
        public static int Main(string[] args)
        {
            Department d = new Department();
            d.departname = "Communication";
            Console.WriteLine("The Department is :{0}", d.Departname);
            return 0;
        }
    }
}
