int[] numbers = { 1, 2, 3, 4, 5 };

int result = numbers.Aggregate((acc, next) =>
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

System.Console.WriteLine($"Result of aggregation: {concatenated}");