using System;

namespace Oops_samples
{
    class Constructor
    {
        private int num1;
        private int num2;

        // Constructor to initialize values
        public Constructor(int a, int b)
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
            Console.WriteLine("Enter first number:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int b = Convert.ToInt32(Console.ReadLine());

            // Constructor initializes values
            Calculator c = new Calculator(a, b);

            Console.WriteLine("Addition = " + c.Add());
            Console.WriteLine("Subtraction = " + c.Subtract());

            Console.ReadLine();
        }
    }
}
