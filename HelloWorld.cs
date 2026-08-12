using System;

// Custom exception for invalid expense amount
class InvalidExpenseException : Exception
{
    public InvalidExpenseException(string message) : base(message)
    {
    }
}

// Class representing an expense
class Expense
{
    private int expenseId;
    private string description;
    private double amount;

    // Constructor to initialize expense details
    public Expense(int id, string desc, double value)
    {
        expenseId = id;
        description = desc;
        amount = value;
    }

    // Method to display expense details
    public void DisplayExpense()
    {
        Console.WriteLine("Expense ID   : " + expenseId);
        Console.WriteLine("Description  : " + description);
        Console.WriteLine("Amount       : " + amount.ToString("F2"));
    }
}

// Main class
class ExpenseTrackingModule
{
    static void Main()
    {
        Console.WriteLine("====================================");
        Console.WriteLine("       EXPENSE TRACKING MODULE");
        Console.WriteLine("====================================");

        try
        {
            // Sample expense details
            int id = 101;
            string description = "Grocery";
            double amount = -500;

            // Validate expense amount
            if (amount <= 0)
            {
                throw new InvalidExpenseException(
                    "Expense amount must be greater than zero."
                );
            }

            // Create an Expense object
            Expense expense = new Expense(
                id,
                description,
                amount
            );

            Console.WriteLine("\n------------------------------------");
            Console.WriteLine("          EXPENSE RECORDED");
            Console.WriteLine("------------------------------------");

            // Display expense information
            expense.DisplayExpense();

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Expense added successfully.");
        }
        catch (InvalidExpenseException ex)
        {
            // Handle invalid expense amount
            Console.WriteLine("\nException: " + ex.Message);
        }
        catch (Exception ex)
        {
            // Handle any unexpected exception
            Console.WriteLine("\nUnexpected Exception: " + ex.Message);
        }
        finally
        {
            // This block always executes
            Console.WriteLine(
                "\nExpense tracking operation completed."
            );
        }
    }
}