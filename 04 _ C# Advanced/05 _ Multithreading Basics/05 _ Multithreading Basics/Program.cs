﻿namespace Multithreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cts = new CancellationTokenSource();
            ThreadPool.QueueUserWorkItem(ProcessBatch1, cts.Token);
            ThreadPool.QueueUserWorkItem(ProcessBatch2, cts.Token);
            Thread.Sleep(1200);
            cts.Cancel();
            Console.ReadKey();
        }

        private static object _lock = new();

        private static void ProcessBatch1(object? state)
        {
            var cancellationToken = (CancellationToken)state;

            Thread.Sleep(1000);
            for (var i = 1; i <= 1000; i++)
            {
                if (cancellationToken.IsCancellationRequested)
                    return;

                lock (_lock)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($" {i} ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
        private static void ProcessBatch2(object? state)
        {
            var cancellationToken = (CancellationToken)state;

            Thread.Sleep(1000);
            for (var i = 1001; i <= 2000; i++)
            {
                if (cancellationToken.IsCancellationRequested)
                    return;

                lock (_lock)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($" {i} ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}
