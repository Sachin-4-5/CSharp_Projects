using ExpenseTrackerApp.Models;

namespace ExpenseTrackerApp.Services
{
    public class ExpenseService
    {
        private readonly List<Expense> _expenses = new();
        public void AddExpense(Expense expense)
        {
            _expenses.Add(expense);
        }

        public List<Expense> GetAllExpenses()
        {
            return _expenses;
        }

        public decimal GetTotalExpense()
        {
            return _expenses.Sum(e => e.Amount);
        }

        public List<Expense> GetExpensesByCategory(ExpenseCategory category)
        {
            return _expenses
                .Where(e => e.Category == category)
                .ToList();
        }
    }
}