namespace CSharpFundamentals
{
    internal class For_loop
    {
        static void Main(string[] args)
        {
            //int[] Numbers = { 10, 20, 30, 40, 50, 100 };
            //for (int i = 0; i < Numbers.Length; i += 2)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Hello World");
            //}
            //for (int i = 65; i <= 90; i++)
            //{
            //    Console.Write($"{Convert.ToChar(i)} ");
            //}

            Console.WriteLine();
            for (int i = 97; i <= 122; i++)
            {
                Console.Write($"{Convert.ToChar(i)} ");
            }
            Console.WriteLine();
            for (int i = 48; i <= 57; i++)
            {
                Console.Write($"{Convert.ToChar(i)} ");
            }

            int[] Numbers = new int[5]; ;
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter number {i} : ");
                Numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(Numbers);
            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.Write($"Number {i} : {Numbers[i]} ");
            }
        }
    }
}
