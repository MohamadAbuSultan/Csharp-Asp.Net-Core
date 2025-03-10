// See https://aka.ms/new-console-template for more information
using GetSummationUsingSum;
using System.Collections.Generic;
using System.Linq;

int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
int sum = numbers.Sum();
// Console.WriteLine($"Sum: {sum}");

var expenses = ExpensesRepository.GetExpenses();
// ExpensesRepository.PrintExpenses(expenses);

var totalIncome = expenses.Where(x => x.Type == ExpensesType.Income);
// ExpensesRepository.PrintExpenses(totalIncome);

// var sum = expenses.Sum(expense => expense.Amount);
// Console.WriteLine($"Sum: {sum}");

var totalIncome2 = expenses.Where(x => x.Type == ExpensesType.Income).Sum(x => x.Amount);
Console.WriteLine($"Total Income: {totalIncome2}");

var totalOutcome = expenses.Where(x => x.Type == ExpensesType.Outcome).Sum(x => x.Amount);
Console.WriteLine($"Total Outcome: {totalOutcome}");