int[] numbers = { 1, 2, 3, 4, 5 };

int result = numbers.Aggregate(10, (acc, next) =>
{
    // Console.WriteLine($"acc: {acc}, next: {next}");
    return acc + next;
});

string sentence = "The quick brown fox jumps over the lazy dog";

string[] words = sentence.Split(' ');

string concatenated = words.Aggregate((acc, next) =>
{
    // Console.WriteLine($"acc: {acc}, next: {next}");
    return acc + " " + next;
});

// System.Console.WriteLine($"Result of aggregation: {concatenated}");

int[] ints = [4, 8, 15, 16, 23, 42];

int numEven = ints.Aggregate(0, (total, next) =>
{
    Console.WriteLine($"acc: {total}, next: {next}");
    return next % 2 == 0 ? total + 1 : total;
});
System.Console.WriteLine($"Number of even integers: {numEven}");