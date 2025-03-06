using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write(">> ");
            var input = Console.ReadLine().Trim();
            var whiteSpaceIndex = input.IndexOf(' ');

            if (whiteSpaceIndex == -1)
            {
                Console.WriteLine("Invalid command. Please enter a valid command followed by a path.");
                continue;
            }

            var command = input.Substring(0, whiteSpaceIndex).ToLower();
            var path = input.Substring(whiteSpaceIndex + 1).Trim();

            if (command == "list")
            {
                ListEntries(path);
            }
            else if (command == "info")
            {
                DisplayInfo(path);
            }
            else if (command == "mkdir")
            {
                Directory.CreateDirectory(path);
            }
            else if (command == "remove")
            {
                if (Directory.Exists(path))
                {
                    Directory.Delete(path, true);
                }
                else if (File.Exists(path))
                {
                    File.Delete(path);
                }
            }
            else if (command == "print")
            {
                if (File.Exists(path))
                {
                    var fileContent = File.ReadAllText(path);
                    Console.WriteLine(fileContent);
                }
            }
            else if (command == "exit")
            {
                break;
            }
            else
            {
                Console.WriteLine("Unknown command. Please try again.");
            }
        }
    }

    static void ListEntries(string path)
    {
        if (!Directory.Exists(path))
        {
            Console.WriteLine("The specified path does not exist.");
            return;
        }

        foreach (var entry in Directory.GetDirectories(path))
            Console.WriteLine($"\t[Dir] {entry}");
        foreach (var entry in Directory.GetFiles(path))
            Console.WriteLine($"\t[File] {entry}");
    }

    static void DisplayInfo(string path)
    {
        if (Directory.Exists(path))
        {
            var directoryInfo = new DirectoryInfo(path);
            Console.WriteLine($"Directory Name: {directoryInfo.Name}");
            Console.WriteLine($"Created on: {directoryInfo.CreationTime}");
            Console.WriteLine($"Last modified on: {directoryInfo.LastWriteTime}");
        }
        else if (File.Exists(path))
        {
            var fileInfo = new FileInfo(path);
            Console.WriteLine($"File Name: {fileInfo.Name}");
            Console.WriteLine($"Created on: {fileInfo.CreationTime}");
            Console.WriteLine($"Last modified on: {fileInfo.LastWriteTime}");
            Console.WriteLine($"Size in bytes: {fileInfo.Length}");
        }
        else
        {
            Console.WriteLine("The specified path does not exist.");
        }
    }
}