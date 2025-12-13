namespace Grade_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[5];

            Console.WriteLine("Please enter five test scores (integers):");

            int sum = 0;

            for (int i = 0; i < scores.Length; i++)
            {
                scores[i] = int.Parse(Console.ReadLine());
                sum += scores[i];
            }

            int average = sum / scores.Length;

            switch (average)
            {
                case int n when (n >= 90 && n <= 100):
                    Console.WriteLine("Grade A");
                    break;
                case int n when (n >= 80 && n <= 90):
                    Console.WriteLine("Grade B");
                    break;
                case int n when (n >= 70 && n <= 80):
                    Console.WriteLine("Grade C");
                    break;
                case int n when (n >= 60 && n <= 70):
                    Console.WriteLine("Grade D");
                    break;

                default:
                    Console.WriteLine("Grade F");
                    break;
            }
        }
    }
}
