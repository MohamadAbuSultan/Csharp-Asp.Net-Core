// See https://aka.ms/new-console-template for more information

// Pure Function
// -Robust And Testable Code
// -Prefer Declarative over imparative coding

// Functional Programming
// -Programming paradigm for developing software using functions
// -Functional programming is the key part of functional programming

using FunctionalProgramming;

class Program
{
    static void Main(string[] args)
    {
        // RunExtensionProcedural();
        RunExtensionFunctional();
        Console.ReadKey();
    }

    private static void RunExtensionFunctional()
    {
        var list = EmployeeRepository.LoadEmployees();
        var q1 = ExtensionFunctional.Filter(list, e => e.FirstName.ToLowerInvariant().StartsWith("ma"));
        ExtensionFunctional.Print(q1, "Employees with first name starting with 'ma'");

        var q2 = ExtensionFunctional.Filter(list, e => e.LastName.ToLowerInvariant().StartsWith("ju"));
        ExtensionFunctional.Print(q2, "Employees with last name starting with 'ju'");

        var q3 = ExtensionFunctional.Filter(list, e => e.Department.ToLowerInvariant() == "hr");
        ExtensionFunctional.Print(q3, "Employees in 'HR' department");

        var q4 = ExtensionFunctional.Filter(list, e => e.Gender.ToLowerInvariant() == "female");
        ExtensionFunctional.Print(q4, "Female employees");

        var q5 = ExtensionFunctional.Filter(list, e => e.HireDate.Year == 2018);
        ExtensionFunctional.Print(q5, "Employees hired in '2018'");

        var q6 = ExtensionFunctional.Filter(list, e => e.Salary > 50000);
        ExtensionFunctional.Print(q6, "Employees with salary greater than 50000");
    }

    private static void RunExtensionProcedural()
    {
        var q1 = EmployeeService.GetEmployeesWithFirstNameStartsWith("na");
        EmployeeService.Print(q1, "Employees with first name starting with 'na'");

        var q2 = EmployeeService.GetEmployeesWithLastNameStartsWith("last");
        EmployeeService.Print(q2, "Employees with last name starting with 'last'");

        var q3 = EmployeeService.GetEmployeesByDepartment("HR");
        EmployeeService.Print(q3, "Employees in 'HR' department");

        var q4 = EmployeeService.GetEmployeesByGender("female");
        EmployeeService.Print(q4, "Female employees");

        var q5 = EmployeeService.GetEmployeesByHireDate(new DateTime(2018, 1, 1));
        EmployeeService.Print(q5, "Employees hired in '2018'");

        var q6 = EmployeeService.GetEmployeesBySalary(50000, 100000);
        EmployeeService.Print(q6, "Employees with salary greater than 50000");
    }

    // delegate void MDelegate();
    // Action, Function, Predicate
    // static void Main(string[] args)
    // {
    //    M2(M1); // Output: M1 M2
    //     Action action = M1;
    //     M2(action); // Output: M1 M2

    // }

    // static void M1(){
    //     Console.WriteLine("M1");
    // }

    // static void M2(Action action){
    //     action();
    //     Console.WriteLine("M2");
    // }
}