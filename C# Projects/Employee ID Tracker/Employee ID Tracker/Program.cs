namespace Employee_ID_Tracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> employeeId = new List<int>();

            while (employeeId.Count < 5)
            {
                Console.Write($"Enter ID for Employee #{employeeId.Count + 1}: ");
                string input = Console.ReadLine();

                // 1. TryParse prevents the program from crashing on non-numeric input
                if (int.TryParse(input, out int newId))
                {
                    // 2. Contains ensures uniqueness
                    if (employeeId.Contains(newId))
                    {
                        Console.WriteLine("ID already exists. Please try a different number.");
                    }
                    else
                    {
                        employeeId.Add(newId);
                        Console.WriteLine("ID added successfully.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a whole number.");
                }
            }


            employeeId.Sort();

            foreach (var id in employeeId)
            {
                Console.WriteLine(id);
            }

        }
    }
}
