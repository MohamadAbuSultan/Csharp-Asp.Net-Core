using Abstraction;
using Polymorphism;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var salaryEmployee = new SalaryEmployee();
            salaryEmployee.SetName("Mohamad", "Khaled");
            salaryEmployee.Email = "mohamadkhaled@gmail.com";
            salaryEmployee.BasicSalary = 2000;
            salaryEmployee.Housing = 1000;
            salaryEmployee.Transportation = 500;
            Console.WriteLine($"Salary of Salaried Employee without taxes is {salaryEmployee.GetSalary():0.00}");
            Console.WriteLine($"Salary of Salaried Employee with taxes is {salaryEmployee.GetSalary(10):0.00}");
            Console.WriteLine($"Salary of Salaried Employee with taxes with 1000 ponus is {salaryEmployee.GetSalary(10, 1000):0.00}");

            var freelanceEmployee = new FreelanceEmployee();
            freelanceEmployee.SetName("Mohamad", "Khaled");
            freelanceEmployee.Email = "mohamadkhaled@gmail.com";
            freelanceEmployee.HourRate = 200;
            freelanceEmployee.TotalWorkingHours = 60;
            Console.WriteLine($"Salary of Free Lancer Employee is {freelanceEmployee.GetSalary():0.00}");

            var internEmployee = new InternEmployee();
            internEmployee.SetName("Mohamad", "Khaled");
            internEmployee.Email = "mohamadkhaled@gmail.com";
            Console.WriteLine($"Salary of intern Employee is {internEmployee.GetSalary():0.00}");


            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("_________________________________");
            var notifier = new Notifier("mail@example.com", 25, "noreply@example.com", "Abc123");
            var payslipGenerator = new PayslipGenerator(notifier);
            payslipGenerator.Generate(salaryEmployee);
            payslipGenerator.Generate(freelanceEmployee);
            payslipGenerator.Generate(internEmployee);

        }
    }
}
