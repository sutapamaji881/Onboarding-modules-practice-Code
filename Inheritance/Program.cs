using System;

namespace Inheritance
{

    public class Base
    {
        public void calculator()
        {
            int a = 10, b = 20;
            int sum = a + b;
            int mul = a * b;
            Console.WriteLine("sum of two numbers: " + sum);
            Console.WriteLine("Multiplication of two numbers: " + mul);
        }
    }
    public class child : Base
    {
        public void advanceCalculator()
        {
            Console.WriteLine("sum of two numbers in advance calculator in the child class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            child obj = new child();
            obj.advanceCalculator();
            obj.calculator();

        }
    }
}
