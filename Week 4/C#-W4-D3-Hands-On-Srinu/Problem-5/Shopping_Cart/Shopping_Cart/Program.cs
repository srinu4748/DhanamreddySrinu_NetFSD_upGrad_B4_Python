//Level - 2 Problem 4: Online Shopping Cart System
//Scenario:
//An e-commerce platform needs a flexible cart system where different product types calculate discounts differently.
//Requirements:
//1.Create a base class Product with properties Name and Price.
//2. Create derived classes Electronics and Clothing.
//3. Implement a virtual method CalculateDiscount().
//4. Electronics get 5% discount, Clothing gets 15% discount.
//5. Use encapsulation to protect price updates.
//Technical Constraints:
//• Use private fields with public properties.
//• Apply inheritance and method overriding.
//• Prevent negative price assignment.
//Expectations:
//• Demonstrate polymorphic behavior in cart processing.
//• Apply data validation inside properties.
//• Calculate and display final price after discount.
//Learning Outcome:
//• Combine encapsulation and polymorphism.
//• Design extensible product hierarchy.
//• Implement business logic in overridden methods.
//Sample Input: Electronics Price = 20000
//Sample Output: Final Price after 5% discount = 19000

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Cart
{
    // Base class for products
    class Product
    {
        private double price;
        // Property for product name
        public string Name { get; set; }

        // Property with validation
        public double Price
        {
            get { return price; }
            set
            {
                if (value >= 0)
                    price = value;
                else
                    Console.WriteLine("Price cannot be negative");
            }
        }

        // Virtual method
        public virtual double CalculateDiscount()
        {
            return Price;
        }
    }

    //Derived class for Electronics 
    class Electronics : Product
    {
        public override double CalculateDiscount()
        {
            return Price - (Price * 0.05);
        }
    }
    //Derived class for Clothing
    class Clothing : Product
    {
        public override double CalculateDiscount()
        {
            return Price - (Price * 0.15);
        }
    }
    //Main program to demonstrate polymorphic behavior
    class Program
    {
        static void Main()
        {
            // User input for product type and price
            Console.WriteLine("Select Product Type");
            Console.WriteLine("1. Electronics");
            Console.WriteLine("2. Clothing");
            // Read user choice
            int choice = Convert.ToInt32(Console.ReadLine());
            // Read product price
            Console.WriteLine("Enter Product Price:");
            double price = Convert.ToDouble(Console.ReadLine());

            // Create product based on user choice
            Product product;
            // Polymorphic behavior based on user choice
            if (choice == 1)
                product = new Electronics();
            else
                product = new Clothing();

            product.Price = price;

            double finalPrice = product.CalculateDiscount();

            Console.WriteLine($"Final Price after discount = {finalPrice}");
        }
    }
}
