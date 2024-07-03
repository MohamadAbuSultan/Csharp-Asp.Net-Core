namespace Events
{
    internal partial class Program
    {

        delegate int CalculateDelegate(int num1, int num2);
        static void Main(string[] args)
        {
            List<Employee> employees = new();
            for (int i = 1; i <= 100; i++)
            {
                employees.Add(new Employee
                {
                    Name = $"Employee{i}",
                    BasicSalary = Random.Shared.Next(1000, 5001),
                    Deductions = Random.Shared.Next(0, 501),
                    Bonus = Random.Shared.Next(0, 1001)
                });
            }
            var Calculator = new SalaryCalculator();
            Calculator.CalculateSalaries(employees, e => e.BasicSalary > 2000);
        }

    }
}