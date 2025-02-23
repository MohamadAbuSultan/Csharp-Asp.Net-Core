namespace Delegates
{
    internal class Program
    {
        delegate bool ShouldCalculate(Employee employee);
        public class Employee
        {
            public string Name { get; set; }
            public int BasicSalary { get; set; }
            public int Deductions { get; set; }
            public int Bonus { get; set; }
        }

        //  delegate is a function pointer or method pointer
        delegate int CalculateDelegate(int num1, int num2);
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 2;
            CalculateWithDelegate(num1, num2, Add);
            CalculateWithDelegate(num1, num2, Sub);
            CalculateWithDelegate(num1, num2, Multi);
            CalculateWithDelegate(num1, num2, Div);
            CalculateWithDelegate(num1, num2, delegate (int num1, int num2) { return num1 / num2; });
            CalculateWithDelegate(num1, num2, (int a, int b) => a / b); // lambda expression
            CalculateWithDelegate(num1, num2, (x, y) => x % y); // lambda expression

            CalculateDelegate dlg = new CalculateDelegate(Add);
            CalculateDelegate dlg1 = Add;
            dlg1 = Sub;

            // multicast 
            // Multicast refers to the ability to use a delegate to invoke multiple functions simultaneously. In other words, a multicast delegate can contain a list of different functions, and when it is invoked, each function in the list is executed sequentially.
            dlg = Div;
            dlg += Sub;
            dlg += Multi;
            dlg += Add;
            CalculateWithDelegate(num1, num2, dlg);
            Console.WriteLine("-------------");
            dlg -= Div;
            CalculateWithDelegate(num1, num2, dlg);
            Console.WriteLine("-------------");
            dlg -= Multi;
            CalculateWithDelegate(num1, num2, dlg);
            Console.WriteLine("-------------");
            dlg -= Sub;
            CalculateWithDelegate(num1, num2, dlg);
            Console.WriteLine("-------------");


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

            // CalculateSalaries(employees, e => e.BasicSalary <= 2000);
            CalculateSalaries(employees, e => e.BasicSalary > 2000);
        }

        private static void CalculateSalaries(List<Employee> employees, ShouldCalculate predicate)
        {
            foreach (var employee in employees)
            {
                if (predicate(employee))
                {
                    var salary = employee.BasicSalary + employee.Bonus - employee.Deductions;
                    Console.WriteLine($"Salary for employee '{employee.Name}' with basic salary ({employee.BasicSalary}) = {salary}");
                }
            }
        }

        static void CalculateWithDelegate(int num1, int num2, CalculateDelegate dlg)
        {
            int result = dlg(num1, num2);
            Console.WriteLine($"Result = {result}");
        }
        static int Add(int num1, int num2)
        {
            Console.Write("\nAdd ");
            return num1 + num2;
        }
        static int Sub(int num1, int num2)
        {
            Console.Write("\nSub ");
            return num1 - num2;
        }
        static int Multi(int num1, int num2)
        {
            Console.Write("\nMulti ");
            return num1 * num2;
        }
        static int Div(int num1, int num2)
        {
            Console.Write("\nDiv ");
            return num1 / num2;
        }
    }
}
