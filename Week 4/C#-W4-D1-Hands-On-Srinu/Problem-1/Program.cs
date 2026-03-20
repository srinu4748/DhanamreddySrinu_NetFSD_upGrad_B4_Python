using System;

class Program
{
    static void Main()
    {

        string name;
        int marks;

        Console.Write("Enter Student Name: ");
        name = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Invalid Name!");
            return;
        }

        Console.Write("Enter Marks: ");
        marks = Convert.ToInt32(Console.ReadLine());

        if (marks < 0 || marks > 100)
        {
            Console.WriteLine("Invalid Marks");
        }
        else if (marks >= 90)
        {
            Console.WriteLine("Student: " + name);
            Console.WriteLine("Grade: A");
        }
        else if (marks >= 75)
        {
            Console.WriteLine("Student: " + name);
            Console.WriteLine("Grade: B");
        }
        else if (marks >= 60)
        {
            Console.WriteLine("Student: " + name);
            Console.WriteLine("Grade: C");
        }
        else if (marks >= 50)
        {
            Console.WriteLine("Student: " + name);
            Console.WriteLine("Grade: D");
        }
        else
        {
            Console.WriteLine("Student: " + name);
            Console.WriteLine("Grade: Fail");
        }

        Console.ReadLine();
        Calculator.Run();
 
    }
}