Console.WriteLine(CalculateFactorial(5));
static int CalculateFactorial(int number)
{
    if (number <= 1)
        return number;

    return number * CalculateFactorial(number - 1);
}

// Call Stack
// The call stack tells you how the code reached this line,
// or in other words, which method called the method that brought/reach us to this line
// You can use the keyboard shortcut Ctrl+Alt+C to open the Call Stack window
// directly after setting a breakpoint and starting the debugging process

PrintDirectoryFileSystemEntries("D:\\My_Learning\\Csharp-Asp.Net-Core\\04 _ C# Advanced\\02 _ Recursion", 1);

var size = CalculateDirectorySize("D:\\My_Learning\\Csharp-Asp.Net-Core\\04 _ C# Advanced\\02 _ Recursion");
Console.WriteLine(size);
Console.WriteLine(size / 1024);

static void PrintDirectoryFileSystemEntries(string dirPath, int level)
{
    foreach (var fileName in Directory.GetFiles(dirPath))
        Console.WriteLine($"{new string('-', level)} {new FileInfo(fileName).Name}");

    foreach (var dirName in Directory.GetDirectories(dirPath))
    {
        Console.WriteLine($"{new string('-', level)} {new DirectoryInfo(dirName).Name}");
        PrintDirectoryFileSystemEntries(dirName, level + 1);
    }
}

static long CalculateDirectorySize(string dirPath)
{
    long size = 0;

    foreach (var fileName in Directory.GetFiles(dirPath))
        size += new FileInfo(fileName).Length;

    foreach (var dirName in Directory.GetDirectories(dirPath))
        size += CalculateDirectorySize(dirName);

    return size;
}