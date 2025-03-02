int[] numbers = { 1, 3, 5, 7, 9 };
int target = 6;

var result = Contains(numbers, target);

System.Console.WriteLine($"'{target}' {(result ? "found" : "not found")} in the array");

static bool Contains(int[] source, int target)
{
    for (int i = 0; i < source.Length; i++)
        if (source[i] == target)
            return true;

    return false;
}