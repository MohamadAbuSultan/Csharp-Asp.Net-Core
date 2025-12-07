namespace Stack___Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // STACK is a LIFO data structure
            // STACK - LIFO: Last In First Out
            // Example: Stack of plates

            // Stack is a generic collection
            //System.Collections.Generic.Stack<int> genericStack = new System.Collections.Generic.Stack<int>();

            // we use stack for undo/redo operations in applications

            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            Stack<int> stack = new Stack<int>(numbers);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            //int resultPop = stack.Pop();
            //int resultPop2 = stack.Pop();

            //Console.WriteLine(resultPop);
            //Console.WriteLine(resultPop2);

            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(stack.Peek());

            //while (stack.Count > 0)
            //{
            //    Console.WriteLine(stack.Pop());
            //}

            //Console.WriteLine($"\nStack Count: {stack.Count}");




            // QUEUE is a FIFO data structure
            // QUEUE - FIFO: First In First Out
            // Example: Cashier line in a supermarket
            Queue<int> queue = new Queue<int>(numbers);
            queue.Enqueue(11);
            queue.Enqueue(12);
            queue.Enqueue(14);
            //foreach (var customer in queue)
            //{
            //    Console.WriteLine(customer);
            //}

            //Console.WriteLine($"\nNext to be served: {queue.Peek()}\n");
            //Console.WriteLine($"Dequeue: {queue.Dequeue()}\n");


        }
    }
}
