using System;

namespace Oops_samples
{
    class Calculator
    {
        private int num1;
        private int num2;

        public void SetNumbers(int a, int b)
        {
            num1 = a;
            num2 = b;
        }

        public int Add()
        {
            return num1 + num2;
        }

        public int Subtract()
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
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int b = Convert.ToInt32(Console.ReadLine());

            c.SetNumbers(a, b);

            int addition = c.Add();
            int subtraction = c.Subtract();

            Console.WriteLine("Addition = " + addition);
            Console.WriteLine("Subtraction = " + subtraction);


            Console.ReadLine();
        }
    }
}