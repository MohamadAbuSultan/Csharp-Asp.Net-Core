int[] numbers = { 500, 200, 300, 100, 400 };
int minNumber = numbers.Min();
// Console.WriteLine($"The minimum number is: {minNumber}");

double[] prices = { 19.99, 5.99, 12.50, 7.25 };
double minPrice = prices.Min();
Console.WriteLine($"The minimum price is: {minPrice}");

DateTime[] dates = {
    new DateTime(2023, 5, 1),
    new DateTime(2022, 12, 31),
    new DateTime(2024, 1, 15)
};
DateTime earliest = dates.Min();
Console.WriteLine($"The earliest date is: {earliest.ToShortDateString()}");

var people = new[]
{
    new { Name = "Ali", Age = 30 },
    new { Name = "Sara", Age = 22 },
    new { Name = "Omar", Age = 27 }
};
var youngest = people.MinBy(p => p.Age);
Console.WriteLine($"The youngest person is: {youngest?.Name}, Age: {youngest?.Age}");

string[] names = { "Mohammad", "Ali", "Reem", "Yousef" };
string? shortestName = names.MinBy(n => n.Length);
Console.WriteLine($"The shortest name is: {shortestName}");