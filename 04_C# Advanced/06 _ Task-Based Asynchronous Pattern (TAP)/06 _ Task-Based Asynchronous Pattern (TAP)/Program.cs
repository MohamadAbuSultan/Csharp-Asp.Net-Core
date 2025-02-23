namespace Tap
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var cts = new CancellationTokenSource();
            Console.WriteLine("Main Thread Id: " + Environment.CurrentManagedThreadId);
            //await ProcessBatch1(cts.Token);
            var task1 = ProcessBatch1(cts.Token);
            //var task2 = ProcessBatch2(cts.Token);
            //await task1;
            //await task2;

            var task2 = await task1.ContinueWith(async t => await ProcessBatch2(cts.Token));

            //var x = ProcessBatch1(cts.Token);
            //var y = await ProcessBatch1(cts.Token);

            await Task.WhenAll(task1, task2);
            //await Task.WhenAny(task1, task2);


            Console.WriteLine("Enter Your Name: ");
            var Name = Console.ReadLine();
            Console.WriteLine($"Welcome, {Name} !");
            Console.ReadKey();
        }

        private static object _lock = new();

        private static async Task<int> ProcessBatch1(CancellationToken cancellationToken)
        {
            Console.WriteLine("Batch1 Thread Id: " + Environment.CurrentManagedThreadId);
            Console.WriteLine("Batch1 Thread Id: " + Environment.CurrentManagedThreadId);
            for (var i = 1; i <= 100; i++)
            {
                if (cancellationToken.IsCancellationRequested)
                    return 0;

                await Task.Delay(100);

                lock (_lock)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($" {i} ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            return 100;
        }
        private static async Task ProcessBatch2(CancellationToken cancellationToken)
        {
            Console.WriteLine("\nBatch2 Thread Id: " + Environment.CurrentManagedThreadId);
            Console.WriteLine("\nBatch2 S2 Thread Id: " + Environment.CurrentManagedThreadId);
            for (var i = 101; i <= 200; i++)
            {
                if (cancellationToken.IsCancellationRequested)
                    return;

                await Task.Delay(100);

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
