public class EmployeeService
{
    public static IEnumerable<Employee> GetEmployeesWithFirstNameStartsWith(string value)
    {
        var employees = EmployeeRepository.LoadEmployees();

        foreach (var employee in employees)
        {
            if (employee.FirstName.ToLowerInvariant().StartsWith(value.ToLowerInvariant()))
            {
                yield return employee;
            }
        }
    }

    public static IEnumerable<Employee> GetEmployeesWithLastNameStartsWith(string value)
    {
        var employees = EmployeeRepository.LoadEmployees();

        foreach (var employee in employees)
        {
            if (employee.LastName.ToLowerInvariant().StartsWith(value.ToLowerInvariant()))
            {
                yield return employee;
            }
        }
    }

    public static IEnumerable<Employee> GetEmployeesByDepartment(string department)
    {
        if (string.IsNullOrWhiteSpace(department))
        {
            yield break;
        }

        var employees = EmployeeRepository.LoadEmployees();

        foreach (var employee in employees)
        {
            if (employee.Department.Equals(department, StringComparison.OrdinalIgnoreCase))
            {
                yield return employee;
            }
        }
    }

    public static IEnumerable<Employee> GetEmployeesByHireDate(DateTime hireDate)
    {
        var employees = EmployeeRepository.LoadEmployees();

        foreach (var employee in employees)
        {
            if (employee.HireDate.Date == hireDate.Date)
            {
                yield return employee;
            }
        }
    }

    public static IEnumerable<Employee> GetEmployeesByGender(string gender)
    {
        if (string.IsNullOrWhiteSpace(gender))
        {
            yield break;
        }

        var employees = EmployeeRepository.LoadEmployees();

        foreach (var employee in employees)
        {
            if (employee.Gender.Equals(gender, StringComparison.OrdinalIgnoreCase))
            {
                yield return employee;
            }
        }
    }

    public static IEnumerable<Employee> GetEmployeesWithHealthInsurance(bool hasHealthInsurance)
    {
        var employees = EmployeeRepository.LoadEmployees();

        foreach (var employee in employees)
        {
            if (employee.HasHealthInsurance == hasHealthInsurance)
            {
                yield return employee;
            }
        }
    }

    public static IEnumerable<Employee> GetEmployeesWithPensionPlan(bool hasPensionPlan)
    {
        var employees = EmployeeRepository.LoadEmployees();

        foreach (var employee in employees)
        {
            if (employee.HasPensionPlan == hasPensionPlan)
            {
                yield return employee;
            }
        }
    }

    public static IEnumerable<Employee> GetEmployeesBySalary(decimal minSalary, decimal maxSalary)
    {
        var employees = EmployeeRepository.LoadEmployees();

        foreach (var employee in employees)
        {
            if (employee.Salary >= minSalary && employee.Salary <= maxSalary)
            {
                yield return employee;
            }
        }
    }

    public static void Print<T>(IEnumerable<T> source, string title)
    {
        if (source == null)
        {
            return;
        }

        Console.WriteLine();
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine($"| {title.PadRight(52, ' ')} |");
        Console.WriteLine("----------------------------------------------------");

        foreach (var item in source)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("----------------------------------------------------");
    }

}