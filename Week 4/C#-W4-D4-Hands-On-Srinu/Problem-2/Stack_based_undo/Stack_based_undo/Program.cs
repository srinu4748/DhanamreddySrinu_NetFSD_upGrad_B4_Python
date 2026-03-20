//Level - 1 Problem 2: Stack - Based Undo System
//Scenario:
//Design a simple text editor undo feature using Stack (LIFO principle).
//Requirements:
//-Implement stack using arrays.
//-Support push(add action) and pop(undo action).
//-Display current state after each operation.
//Technical Constraints:
//-Only array - based stack implementation.
//-Must follow LIFO order strictly.
//- Handle empty stack condition.
//Sample Input:
//Actions: Type A, Type B, Type C, Undo, Undo
//Sample Output:
//Current State After Operations: Type A
//Expectations:
//-Correct LIFO implementation.
//-Proper error handling.
//-Clear logic structure.


//Learning Outcome:
//-Understand stack operations.
//-Learn LIFO principle application.
//- Implement stack using arrays.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Stack_based_undo
{
    class StackUndo
    {
        static string[] stack = new string[10]; // array stack
        static int top = -1; // stack pointer
        
        static void Main()
        {
            // Simulating user actions
            Push("Type A");
            Push("Type B");
            Push("Type C");

            Pop(); // Undo
            Pop(); // Undo

            Display();
        }

        // Push operation
        static void Push(string action)
        {
            // Check for stack overflow
            if (top == stack.Length - 1)
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            // Add action to stack
            top++;
            stack[top] = action;

            Console.WriteLine("Action Added: " + action);
        }

        // Pop operation (Undo)
        static void Pop()
        {
            // Check for stack underflow
            if (top == -1)
            {
                Console.WriteLine("Nothing to Undo (Stack Empty)");
                return;
            }

            Console.WriteLine("Undo Action: " + stack[top]);
            top--;
        }

        // Display current state
        static void Display()
        {
            // Check if stack is empty
            if (top == -1)
            {
                Console.WriteLine("No Actions Available");
                return;
            }

            Console.WriteLine("\nCurrent State After Operations: " + stack[top]);
        }
    }
}
