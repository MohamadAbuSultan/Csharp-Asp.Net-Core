using Polymorphism;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Both method overloading and method overriding are techniques in object-oriented programming and are part of the concept of polymorphism.
            // Method overloading allows a developer to define multiple functions(or methods) with the same name within the same class,
            // but these functions must differ in their signatures(number or type of parameters).
            // This enables the developer to use the same name to execute different functions based on the context which is a form of ad-hoc polymorphism.
            // On the other hand, method overriding is a technique used to allow a subclass to modify the implementation of a function(or method)
            // that exists in the superclass. It enables the subclass to replace the implementation of the method present in the superclass with a
            // customized implementation. This type of polymorphism is known as inheritance polymorphism.
            // Therefore, both method overloading and method overriding represent different forms of polymorphism in object-oriented programming,
            // allowing for multiple behaviors or implementations based on the context or type.




            var salaryEmployee = new SalaryEmployee();
            salaryEmployee.BasicSalary = 2000;
            salaryEmployee.Housing = 1000;
            salaryEmployee.Transportation = 500;
            Console.WriteLine($"Salary of Salaried Employee without taxes is {salaryEmployee.GetSalary():0.00}");
            Console.WriteLine($"Salary of Salaried Employee with taxes is {salaryEmployee.GetSalary(10):0.00}");
            Console.WriteLine($"Salary of Salaried Employee with taxes with 1000 ponus is {salaryEmployee.GetSalary(10, 1000):0.00}");

            var freelanceEmployee = new FreelanceEmployee();
            freelanceEmployee.HourRate = 200;
            freelanceEmployee.TotalWorkingHours = 60;
            Console.WriteLine($"Salary of Free Lancer Employee is {freelanceEmployee.GetSalary():0.00}");

            var internEmployee = new InternEmployee();
            Console.WriteLine($"Salary of intern Employee is {internEmployee.GetSalary():0.00}");

        }
    }
}
