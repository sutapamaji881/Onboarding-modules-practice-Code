using System;

namespace Abstraction
{
    abstract class Animal
    {
        public abstract void sum();
       
        public void multiplication()
        {
            Console.WriteLine("multiplication is a concreate class");
        }
    }

    class Pig : Animal
    {
        public override void sum()
        {
            Console.WriteLine("Definition of sum in the inherited class");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pig myPig = new Pig();  
            myPig.sum();
            myPig.multiplication();
        }
    }
}
