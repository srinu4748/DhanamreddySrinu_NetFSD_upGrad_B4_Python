//Level - 1 Problem 1: Student Grade Calculator
//Scenario:
//A school wants to calculate the average marks of a student using a class-based approach.
//Requirements:
//1.Create a class Student.
//2.Create method CalculateAverage(int m1, int m2, int m3).
//3.Return the average marks.
//4. Display grade based on average.
//Technical Constraints:
//1.Use return type double for average.
//2. Avoid hard-coded values.
//Expectations:
//Clear separation of logic inside methods.
//Learning Outcome:
//Learn method creation, return values, and basic OOP concepts.
//Sample Input: 
//80 70 90
//Sample Output: 
//Average = 80, Grade = A

using System;

namespace Oops1
{
    // Student class contains logic related to marks
    class Student
    {
        // Method to calculate average of three subjects
        public double CalculateAverage(int m1, int m2, int m3)
        {
            // Calculate average
            double average = (m1 + m2 + m3) / 3.0;

            // Return average value
            return average;
        }

        // Method to determine grade based on average
        public string GetGrade(double average)
        {
            // Use classic if/else instead of C# 8+ switch expression
            if (average >= 90)
                return "A";
            else if (average >= 80)
                return "B";
            else if (average >= 70)
                return "C";
            else if (average >= 60)
                return "D";
            else
                return "F";   // If average < 60
        }
    }

    // Main class where program execution starts
    internal class Program
    {
        static void Main()
        {
            // Asking user to enter marks
            Console.WriteLine("Enter marks for Subject 1:");
            int s1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks for Subject 2:");
            int s2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks for Subject 3:");
            int s3 = Convert.ToInt32(Console.ReadLine());

            // Create object of Student class
            Student objStudent = new Student();

            // Call method to calculate average
            double average = objStudent.CalculateAverage(s1, s2, s3);

            // Call method to calculate grade
            string grade = objStudent.GetGrade(average);

            // Display average
            Console.WriteLine("Average = " + average);

            // Display grade
            Console.WriteLine("Grade = " + grade);
        }
    }
}