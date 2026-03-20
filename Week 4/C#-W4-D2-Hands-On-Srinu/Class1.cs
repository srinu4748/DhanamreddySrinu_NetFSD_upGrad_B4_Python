
using System;

namespace Oops_samples
{
    class Class1
    {
        private int num1;
        private int num2;

        public void SetNumbers(int r, int s)
        {
            num1 = r;
            num2 = s;
        }

        public int Add()
        {
            return num1 + num2;
        }

        public int Sub()
        {
            return num1 - num2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();

            Console.WriteLine("Enter first number:");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int s = Convert.ToInt32(Console.ReadLine());

            c.SetNumbers(r, s);

            int addition = c.Add();
            int subtraction = c.Sub();

            Console.WriteLine("Addition = " + addition);
            Console.WriteLine("Subtraction = " + subtraction);


            Console.ReadLine();
        }
    }
}