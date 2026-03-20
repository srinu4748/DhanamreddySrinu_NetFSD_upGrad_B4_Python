using System;

public class Program
{
    static void Main()
    {
        string name;
        double salary;
        int experience;
        double bonus;
        double finalSalary;

        Console.Write("Enter Name: ");
        name = Console.ReadLine();

        Console.Write("Enter Salary: ");
        salary = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Experience (years): ");
        experience = Convert.ToInt32(Console.ReadLine());

        // Bonus calculation using if-else
        if (experience < 2)
        {
            bonus = salary * 0.05;
        }
        else if (experience <= 5)
        {
            bonus = salary * 0.10;
        }
        else
        {
            bonus = salary * 0.15;
        }

        // Final salary using ternary operator
        finalSalary = bonus > 0 ? salary + bonus : salary;

        Console.WriteLine("\nEmployee: " + name);
        Console.WriteLine("Bonus: " + bonus.ToString("F2"));
        Console.WriteLine("Final Salary: " + finalSalary.ToString("F2"));

        Console.ReadLine();
    }
}