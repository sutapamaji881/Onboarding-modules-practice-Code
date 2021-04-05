using System;

namespace ConsoleApp1
{
    public  class Demo
    {
        public static int mulDisplay(int one, int two)
        {
            return one * two;
        }
        public static int mulDisplay(int one, int two, int three)
        {
            return one * two * three;
        }
        public static int mulDisplay(int one, int two, int three, int four)
        {
            return one * two * three * four;
        }
        public class MethodOverLoading
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Multiplication of two numbers: " + Demo.mulDisplay(10, 19));
                Console.WriteLine("Multiplication of three numbers: " + Demo.mulDisplay(8, 13, 20));
                Console.WriteLine("Multiplication of four numbers: " + Demo.mulDisplay(3, 7, 10, 7));

                BaseClass baseClassObj = new BaseClass();
                Console.WriteLine("Base class method Add :" + baseClassObj.Add(-3, 8));
                baseClassObj = new ChildClass();
                Console.WriteLine("Child class method Add :" + baseClassObj.Add(-2, 2));
                Console.ReadLine();
            }
        }
    }
}
