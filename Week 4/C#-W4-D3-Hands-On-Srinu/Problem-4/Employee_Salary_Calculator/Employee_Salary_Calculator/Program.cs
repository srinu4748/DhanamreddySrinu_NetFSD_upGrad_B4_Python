//Level - 2 Problem 3: Employee Salary Calculator
//Scenario:
//A company wants to calculate employee salaries using inheritance.All employees have a base salary, but different roles calculate bonuses differently.
//Requirements:
//1.Create a base class Employee with Name and BaseSalary properties.
//2. Create derived classes Manager and Developer.
//3. Override a virtual method CalculateSalary().
//4. Manager gets 20% bonus, Developer gets 10% bonus.
//Technical Constraints:
//• Use inheritance and method overriding.
//• Apply polymorphism using base class reference.
//• Use properties for salary details.
//Expectations:
//• Demonstrate runtime polymorphism.
//• Avoid code duplication.
//• Display final calculated salary.
//Learning Outcome:
//• Understand inheritance hierarchy.
//• Implement polymorphism using virtual and override.
//• Write reusable and extensible code.
//Sample Input: 
//BaseSalary = 50000
//Sample Output: 
//Manager Salary = 60000, Developer Salary = 55000
using Employee_Salary_Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Salary_Calculator
{
  class Employee
  {
        // Properties
        public string Name { get; set; }
        public double BaseSalary { get; set; }

        // Virtual method
        public virtual double CalculateSalary()
        {
            return BaseSalary;
        }
    }
    
    // Derived class Manager
    class Manager : Employee
    {
        // Override method
        public override double CalculateSalary()
        {
            return BaseSalary + (BaseSalary * 0.20);
        }
    }

    class Developer : Employee
    {
        // Override method
        public override double CalculateSalary()
        {
            return BaseSalary + (BaseSalary * 0.10);
        }
    }

    class Program
    {
        static void Main()
        {
            //demonstrating runtime polymorphism
            double baseSalary = 50000;
            // Create instances of Manager and Developer using base class reference
            Employee objManager = new Manager();
            objManager.BaseSalary = baseSalary;
            // Create instance of Developer using base class reference
            Employee objDeveloper = new Developer();
            objDeveloper.BaseSalary = baseSalary;
            // Display final calculated salary
            Console.WriteLine($"Manager Salary = {objManager.CalculateSalary()}");
            Console.WriteLine($"Developer Salary = {objDeveloper.CalculateSalary()}");
        }
    }


}
