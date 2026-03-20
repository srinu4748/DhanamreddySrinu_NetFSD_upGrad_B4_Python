//Level - 2 Problem 1: Bank Account with Encapsulation
//Scenario:
//A bank wants to manage customer accounts securely using encapsulation.

//Requirements:
//1.Create class BankAccount.
//2.Private field: balance.
//3.Public methods: Deposit(double amount), Withdraw(double amount).
//4.Method GetBalance() to return balance.
//5. Prevent withdrawal if insufficient balance.
//Technical Constraints:
//1.Balance must be private.
//2.Access balance only through public methods.
//3.Use appropriate return types.

//Expectations:
//Proper use of encapsulation and object-oriented principles.
//Learning Outcome:
//Understand encapsulation, access modifiers, and secure data handling.
//Sample Input: 
//Deposit 1000, Withdraw 300
//Sample Output: 
//Current Balance = 700

using System;

class BankAccount
{
    private double balance;

    // Constructor to set initial balance
    public BankAccount(double initialBalance)
    {
        balance = initialBalance;
    }
    // Deposit method to add amount to balance
    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine($"Current Balance = {balance}");
    }
    // Withdraw method to check for sufficient balance before withdrawal
    public void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Remaining balance is {balance}");
        }
        else
        {
            Console.WriteLine("Insufficient Balance");
        }
    }
    // Method to get current balance
    public double GetBalance()
    {
        return balance;
    }
}
// Main program to demonstrate the BankAccount class
class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to your savings account!");

        BankAccount objAccount = new BankAccount(10000);

        Console.WriteLine($"Initial Balance = {objAccount.GetBalance()}");

        Console.WriteLine("Enter amount to deposit:");
        double deposit = Convert.ToDouble(Console.ReadLine());

        objAccount.Deposit(deposit);

        Console.WriteLine("Enter amount to withdraw:");
        double withdraw = Convert.ToDouble(Console.ReadLine());

        objAccount.Withdraw(withdraw);
    }
}