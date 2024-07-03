using static Events.Program;

namespace Events
{
    public class SalaryCalculator
    {
        public delegate bool ShouldCalculate(Employee employee);

        public void CalculateSalaries(List<Employee> employees, ShouldCalculate predicate)
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
    }
}
