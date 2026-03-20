//Scenario:
//A vehicle rental company wants a system where different vehicle types calculate rental charges differently.
//Requirements:
//1.Create a base class Vehicle with properties Brand and RentalRatePerDay.
//2. Create derived classes Car and Bike.
//3. Override CalculateRental(int days) method.
//4. Car adds insurance charge of 500 per rental.
//5. Bike offers 5% discount on total rental.
//Technical Constraints:
//• Use encapsulation with proper access modifiers.
//• Apply runtime polymorphism.
//• Validate number of rental days.
//Expectations:
//• Use base class reference to call overridden methods.
//• Implement clean class hierarchy.
//• Display final rental cost.
//Learning Outcome:
//• Master inheritance and polymorphism.
//• Implement real-world OOP scenarios.
//• Improve object-oriented design skills.
//Sample Input: 
//Car RentalRatePerDay = 2000, Days = 3
//Sample Output: 
//Total Rental = 6500


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_rental
{
    // Base Class
    class Vehicle
    {
        // Properties
        public string Brand { get; set; }
        public double RentalRatePerDay { get; set; }

        // Virtual Method
        public virtual double CalculateRental(int days)
        {
            return RentalRatePerDay * days;
        }
    }
    // Derived Class - Car
    class Car : Vehicle
    {
        // Override Method
        public override double CalculateRental(int days)
        {
            double total = RentalRatePerDay * days;
            return total + 500; // Insurance charge
        }
    }

    // Derived Class - Bike
    class Bike : Vehicle
    {
        public override double CalculateRental(int days)
        {
            double total = RentalRatePerDay * days;
            return total - (total * 0.05); // 5% discount
        }
    }
    // Main Program
    class Program
    {
        static void Main()
        {
            // User Input
            Console.WriteLine("Select Vehicle Type");
            Console.WriteLine("1. Car");
            Console.WriteLine("2. Bike");
            // Validate User Input
            int choice = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Enter Rental Rate Per Day:");
            double rate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Number of Days:");
            int days = Convert.ToInt32(Console.ReadLine());
            //if the user enters a negative number of days, display an error message and exit the program
            if (days <= 0)
            {
                Console.WriteLine("Invalid number of days");
                return;
            }
            // Polymorphism
            Vehicle vehicle;
            // Validate User Choice
            if (choice == 1)
                vehicle = new Car();
            else
                vehicle = new Bike();

            vehicle.RentalRatePerDay = rate;
            // Calculate Rental
            double totalRental = vehicle.CalculateRental(days);

            Console.WriteLine($"Total Rental = {totalRental}");
        }
    }
}
