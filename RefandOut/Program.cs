using System;

namespace RefandOut
{
    class Program
    {
        public static void Sum(out int G)
        {
            G = 80;
            G += G;
        }

        static void SetValue(ref string str1)
        {
            if (str1 == "EPAM")
            {
                Console.WriteLine("Hello!!world");
            }
            str1 = "EPAMSystems";
        }
        static void Main(string[] args)
        {
            int G;
            string str = "EPAM";
            Sum(out G);
            Console.WriteLine("The sum of" +" the value is: {0}", G);
            SetValue(ref str);
            Console.WriteLine(str);
        }
    }
}
