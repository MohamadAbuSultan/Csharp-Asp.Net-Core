namespace Tap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cts = new CancellationTokenSource();
            Console.WriteLine("Main Thread Id: " + Environment.CurrentManagedThreadId);
            ProcessBatch1(cts.Token);
            ProcessBatch2(cts.Token);
        }

        private static object _lock = new();

        private static async Task ProcessBatch1(CancellationToken cancellationToken)
        {
            Console.WriteLine("Batch1 Thread Id: " + Environment.CurrentManagedThreadId);
            await Task.Delay(1);
            Console.WriteLine("Batch1 Thread Id: " + Environment.CurrentManagedThreadId);
            for (var i = 1; i <= 100; i++)
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
            return;
        }
        private static async Task ProcessBatch2(CancellationToken cancellationToken)
        {
            Console.WriteLine("\nBatch2 Thread Id: " + Environment.CurrentManagedThreadId);
            await Task.Delay(1);
            Console.WriteLine("\nBatch2 S2 Thread Id: " + Environment.CurrentManagedThreadId);
            for (var i = 101; i <= 200; i++)
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
            return;
        }
    }
}
