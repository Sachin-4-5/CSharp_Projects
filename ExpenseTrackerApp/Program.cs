using ExpenseTrackerApp.Models;
using ExpenseTrackerApp.Services;
using ExpenseTrackerApp.Utilities;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;


var service = new ExpenseService();
bool running = true;
while (running)
{
    Console.WriteLine("\n=== Expense Tracker ===");
    Console.WriteLine("1. Add Expense");
    Console.WriteLine("2. View All Expenses");
    Console.WriteLine("3. View Total Expense");
    Console.WriteLine("4. Exit");
    Console.Write("Choose option: ");

    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            AddExpense(service);
            break;

        case "2":
            ViewExpenses(service);
            break;

        case "3":
            Console.WriteLine($"Total Expense: ₹{service.GetTotalExpense()}");
            break;

        case "4":
            running = false;
            break;

        default:
            Console.WriteLine("Invalid choice.");
            break;
    }
}


static void AddExpense(ExpenseService service)
{
    decimal amount = InputHelper.ReadDecimal("Amount: ");
    DateTime date = InputHelper.ReadDate("Date (yyyy-mm-dd): ");
    Console.WriteLine("Select Category:");
    foreach (var cat in Enum.GetValues(typeof(ExpenseCategory)))
    {
        Console.WriteLine($"{(int)cat}. {cat}");
    }

    int categoryInput = int.Parse(Console.ReadLine());
    ExpenseCategory category = (ExpenseCategory)categoryInput;

    Console.Write("Description: ");
    string desc = Console.ReadLine();

    service.AddExpense(new Expense
    {
        Amount = amount,
        Date = date,
        Category = category,
        Description = desc
    });

    Console.WriteLine("Expense added successfully!");
}


static void ViewExpenses(ExpenseService service)
{
    var expenses = service.GetAllExpenses();

    if (!expenses.Any())
    {
        Console.WriteLine("No expenses recorded.");
        return;
    }

    foreach (var e in expenses)
    {
        Console.WriteLine($"{e.Date:d} | {e.Category} | ₹{e.Amount} | {e.Description}");
    }
}