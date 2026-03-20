//Level - 1 Problem 1: Student Score Analyzer Using Arrays and Maps
//Scenario:
//A training institute wants to analyze student scores stored in an array. The system should calculate total marks, average, highest score, and count of students scoring above a threshold.
//Requirements:
//-Store student marks in an array.
//- Use array methods (push, map, filter, reduce) for processing.
//- Store subject-wise highest marks using a Map (key - value pair).
//-Display total, average, and filtered results.
//Technical Constraints:
//-Must use array indexing and iteration.
//- Use reduce() for total calculation.
//- Use filter() for threshold-based filtering.
//- Use Map or Dictionary for subject-highest mapping.
//Sample Input:
//Marks: [78, 85, 90, 67, 88]
//Threshold: 80
//Sample Output:
//Total Marks: 408
//Average Marks: 81.6
//Students above 80: 3
//Highest Score: 90
//Expectations:
//-Clean and modular implementation.
//- Proper use of array methods.
//- Efficient iteration logic.
//Learning Outcome:
//-Understand array manipulation.
//-Use Map for key-value storage.
//- Apply functional programming methods.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_score_analyser
{
    class StudentAnalyzer
    {
        // Entry point of the program
        static void Main()
        {
            int[] marks = { 78, 85, 90, 67, 88 };
            int threshold = 80;
            // Calculate total, average, highest score, and count of students above threshold
            int total = CalculateTotal(marks);
            double average = CalculateAverage(marks);
            int highest = GetHighest(marks);
            int countAboveThreshold = CountAboveThreshold(marks, threshold);
            //  Display results
            Console.WriteLine("Total Marks: " + total);
            Console.WriteLine("Average Marks: " + average);
            Console.WriteLine("Students above 80: " + countAboveThreshold);
            Console.WriteLine("Highest Score: " + highest);

            Console.WriteLine("\nSubject Highest Marks:");
            // Get and display subject-wise highest marks
            Dictionary<string, int> subjectHighest = GetSubjectHighestMarks();

            foreach (var item in subjectHighest)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }

        // reduce() -> Aggregate()
        static int CalculateTotal(int[] marks)
        {
            return marks.Aggregate((a, b) => a + b);
        }
        // map() -> Select()
        static double CalculateAverage(int[] marks)
        {
            return marks.Average();
        }
        // max() -> Max()
        static int GetHighest(int[] marks)
        {
            return marks.Max();
        }

        // filter() -> Where()
        static int CountAboveThreshold(int[] marks, int threshold)
        {
            return marks.Where(m => m > threshold).Count();
        }
        // Using Dictionary to store subject-wise highest marks
        static Dictionary<string, int> GetSubjectHighestMarks()
        {
            Dictionary<string, int[]> subjectMarks = new Dictionary<string, int[]>
        {
            { "Math", new int[] {78,85,90,67,88} },
            { "Physics", new int[] {80,70,95,88,84} },
            { "Chemistry", new int[] {60,75,89,92,77} }
        };
            // Dictionary to store highest marks for each subject
            Dictionary<string, int> subjectHighest = new Dictionary<string, int>();
            // Calculate highest marks for each subject and store in the dictionary
            foreach (var subject in subjectMarks)
            {
                int highest = subject.Value.Max();
                subjectHighest.Add(subject.Key, highest);
            }

            return subjectHighest;
        }
    }

}
    

