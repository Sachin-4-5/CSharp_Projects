using CalculatorApp;
using System;


Calculator calc = new Calculator();

Console.WriteLine("Welcome to Calculator App");
Console.WriteLine("-------------------------");

bool continueCalculation = true;
while (continueCalculation)
{
    try
    {
        Console.Write("Enter first number: ");
        Decimal num1 = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Enter second number: ");
        Decimal num2 = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("\nSelect Operation:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");

        Console.Write("Enter your choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        Decimal result = 0;

        switch (choice)
        {
            case 1:
                result = calc.Add(num1, num2);
                break;
            case 2:
                result = calc.Subtract(num1, num2);
                break;
            case 3:
                result = calc.Multiply(num1, num2);
                break;
            case 4:
                if (num2 != 0)
                    result = calc.Divide(num1, num2);
                else
                    throw new DivideByZeroException();
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
        Console.WriteLine($"Result: {result}");
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid input! Please enter numeric values only.");
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Cannot divide by zero.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }

    Console.Write("\nDo you want to continue? (y/n): ");
    string option = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(option) || option.ToLower() != "y")
    {
        continueCalculation = false;
    }
}