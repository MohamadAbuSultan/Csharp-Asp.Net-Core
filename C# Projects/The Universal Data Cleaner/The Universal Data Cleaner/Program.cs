namespace The_Universal_Data_Cleaner
{
    public delegate string DataProcessor(string input);

    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> messyStrings = new List<string> { " apple ", "ORANGE", " baNAna ", " " };

            var cleanedStrings = ProcessData(messyStrings, TrimData);

            Console.WriteLine(string.Join(",", cleanedStrings));

            DataProcessor trimAndLower = delegate (string input)
            {
                return input.Trim().ToLower();
            };

            var cleanedStrings2 = ProcessData(messyStrings, trimAndLower);
            Console.WriteLine(string.Join(",", cleanedStrings2));

            //Func<string, string> toLower = s => s.ToLower();


            DataProcessor addPrefix = s => "Fruit: " + s;

            var prefixedStrings = ProcessData(cleanedStrings, addPrefix);

            Console.WriteLine(string.Join(", ", prefixedStrings).ToLower());
        }

        public static List<string> ProcessData(List<string> data, DataProcessor rule)
        {
            List<string> result = new List<string>();

            foreach (var item in data)
            {
                if (string.IsNullOrWhiteSpace(item)) continue;

                result.Add(rule(item));
            }

            return result;
        }

        public static string TrimData(string input)
        {
            return input.Trim();
            //return input.Replace(" ", "");
        }
    }
}
