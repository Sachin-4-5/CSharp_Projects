namespace ExpenseTrackerApp.Utilities
{
    public static class InputHelper
    {
        public static decimal ReadDecimal(string message)
        {
            while (true)
            {
                Console.Write(message);
                if (decimal.TryParse(Console.ReadLine(), out decimal value))
                    return value;
                Console.WriteLine("Invalid number. Try again.");
            }
        }

        public static DateTime ReadDate(string message)
        {
            while (true)
            {
                Console.Write(message);
                if (DateTime.TryParse(Console.ReadLine(), out DateTime date))
                    return date;
                Console.WriteLine("Invalid date. Try again.");
            }
        }
    }
}