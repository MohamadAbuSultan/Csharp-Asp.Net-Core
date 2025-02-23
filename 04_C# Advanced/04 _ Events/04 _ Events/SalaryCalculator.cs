namespace Events
{
    public class SalaryCalculator
    {
        public delegate bool ShouldCalculate(Employee employee);

        public event EmployeeSalaryCalculatedEventHandler EmployeeSalaryCalculated;
        public delegate void EmployeeSalaryCalculatedEventHandler(Employee employee, int salary);

        public void CalculateSalaries(List<Employee> employees, ShouldCalculate predicate)
        {
            foreach (var employee in employees)
            {
                if (predicate(employee))
                {
                    var salary = employee.BasicSalary + employee.Bonus - employee.Deductions;
                    EmployeeSalaryCalculated?.Invoke(employee, salary); // object is null?.
                }
            }
        }
    }
}
