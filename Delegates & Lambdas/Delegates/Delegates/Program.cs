namespace Delegates
{
    // Delegate type: points to methods with same signature
    delegate string Del(string name);

    delegate bool Operation(int num1, int num2);

    internal class Program
    {
        static void Main(string[] args)
        {
            // Assign delegate to EnglishToFrench
            Del translator = new Del(EnglishToFrench);

            // Invoke delegate (two equivalent ways)
            string result = translator.Invoke("Hi");
            string result2 = translator("Hi");
            //Console.WriteLine(result);
            //Console.WriteLine(result2);


            translator = new Del(EnglishToSpanish);
            result = translator.Invoke("Hi");
            //Console.WriteLine(result);

            List<int> l1 = new(){ 1, 2, 3, 4, 5, 6, 7 };

            List<int> output1 = GetValues(l1, 5, IsGreaterThan);
            List<int> output2 = GetValues(l1, 5, IsLessThan);
            foreach (var item in output2)
            {
                Console.WriteLine(item);
            }
        }

        private static List<int> GetValues(List<int> list1, int x, Operation op)
        {
            List<int> result = new List<int>();

            foreach (var number in list1)
            {
                if (op(number, x))
                    result.Add(number);
            }

            return result;
        }

        static bool IsGreaterThan(int x, int y)
        {
            return x > y;
        }

        static bool IsLessThan(int x, int y)
        {
            return x < y;
        }

        private static string EnglishToFrench(string name)
        {
            return "Bonjour";
        }

        private static string EnglishToSpanish(string name)
        {
            return "Hola";
        }
    }
}
