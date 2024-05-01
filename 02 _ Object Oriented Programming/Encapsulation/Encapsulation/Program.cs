using Encapsulation;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Encapsulation
            // Encapsulation helps protect the object from entering an invalid state by making the properties private
            // or by restricting access to them. When properties are made private, direct access to them from external code is prevented.
            // Access and modification are allowed only through special methods that validate the values and ensure their validity.

            var employee = new Employee();
            employee.SetName("Mohamad", "Khaled");
            employee.SetBirthDate(new DateOnly(1990, 1, 1));
            employee.SetBasicSalary(6000);
            employee.SetTaxPercentage(10);
            Console.WriteLine($"Full Name: {employee.FirstName} {employee.LastName}");
            Console.WriteLine($"Birth Date: {employee.BirthDate}");
            Console.WriteLine($"Basic Salary: {employee.BasicSalary}");
            Console.WriteLine($"Tax Percentage: {employee.TaxPercentage}");
            // invalid state : الأوبجكت فيه قيم غير صحيحة وغير منطقية من ناحية البزنس 
            // invalid state :  الكائن يحتوي على قيم غير صحيحة أو غير منطقية بالنسبة لسياق التطبيق أو الأعمال التجارية
            // invalid state : This means that the object contains invalid or illogical values ​​in relation to the application context or business logic
        }
    }
}
