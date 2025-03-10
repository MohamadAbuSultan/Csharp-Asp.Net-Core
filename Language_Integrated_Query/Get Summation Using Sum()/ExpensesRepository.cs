using System;
using System.Collections.Generic;

namespace GetSummationUsingSum
{
    public record Expenses
    (
        DateOnly Date,
        double Amount,
        ExpensesType Type
    );

    public static class ExpensesRepository
    {
        public static IEnumerable<Expenses> GetExpenses()
        {
            return new List<Expenses>
            {
                new Expenses(new DateOnly(2023, 1, 1), 1000, ExpensesType.Income),
                new Expenses(new DateOnly(2023, 1, 2), 500, ExpensesType.Outcome),
                new Expenses(new DateOnly(2023, 1, 3), 1500, ExpensesType.Income),
                new Expenses(new DateOnly(2023, 1, 4), 700, ExpensesType.Outcome),
                new Expenses(new DateOnly(2023, 1, 5), 1200, ExpensesType.Income),
                new Expenses(new DateOnly(2023, 1, 6), 300, ExpensesType.Outcome),
                new Expenses(new DateOnly(2023, 1, 7), 800, ExpensesType.Income),
                new Expenses(new DateOnly(2023, 1, 8), 400, ExpensesType.Outcome),
                new Expenses(new DateOnly(2023, 1, 9), 1100, ExpensesType.Income),
                new Expenses(new DateOnly(2023, 1, 10), 600, ExpensesType.Outcome),
                new Expenses(new DateOnly(2023, 1, 11), 1300, ExpensesType.Income),
                new Expenses(new DateOnly(2023, 1, 12), 200, ExpensesType.Outcome),
                new Expenses(new DateOnly(2023, 1, 13), 900, ExpensesType.Income),
                new Expenses(new DateOnly(2023, 1, 14), 500, ExpensesType.Outcome),
                new Expenses(new DateOnly(2023, 1, 15), 1400, ExpensesType.Income),
                new Expenses(new DateOnly(2023, 1, 16), 100, ExpensesType.Outcome),
                new Expenses(new DateOnly(2023, 1, 17), 1000, ExpensesType.Income),
                new Expenses(new DateOnly(2023, 1, 18), 700, ExpensesType.Outcome),
                new Expenses(new DateOnly(2023, 1, 19), 1500, ExpensesType.Income),
                new Expenses(new DateOnly(2023, 1, 20), 300, ExpensesType.Outcome),
                new Expenses(new DateOnly(2023, 1, 21), 1200, ExpensesType.Income),
                new Expenses(new DateOnly(2023, 1, 22), 400, ExpensesType.Outcome),
                new Expenses(new DateOnly(2023, 1, 23), 800, ExpensesType.Income),
                new Expenses(new DateOnly(2023, 1, 24), 600, ExpensesType.Outcome),
                new Expenses(new DateOnly(2023, 1, 25), 1300, ExpensesType.Income),
                new Expenses(new DateOnly(2023, 1, 26), 200, ExpensesType.Outcome),
                new Expenses(new DateOnly(2023, 1, 27), 900, ExpensesType.Income)
            };
        }

        public static void PrintExpenses(IEnumerable<Expenses> expenses)
        {
            foreach (var expense in expenses)
            {
                Console.WriteLine($"Date: {expense.Date}, Amount: {expense.Amount}, Type: {expense.Type}");
            }
        }
    }

    public enum ExpensesType
    {
        Income,
        Outcome
    }
}