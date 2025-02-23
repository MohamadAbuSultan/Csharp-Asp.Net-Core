namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inheritance ;- important things
            // it must me is-a relation ship
            // base class دور على ال
            // The classes that share common data should have a common relationship
            // or factor that brings them together so that we can justify using inheritance.
            // Example: Employee and Non (Applicant) - Employee classes; both represent individuals.
            // The common relationship that unites them is that they are people

            // Inheritance achieves the DRY principle
            // The DRY principle stands for "Don't Repeat Yourself,"
            // emphasizing the importance of avoiding code duplication in programming.

            // Inheritance achieves the usability principle." This means that by using inheritance,
            // we can enhance the usability of software by promoting code reusability and reducing redundancy


            var employee = new Employee();
            employee.SetName("Mohamad", "Khaled");
            employee.SetBirthDate(new DateOnly(1990, 1, 1));
            employee.SetBasicSalary(6000);
            employee.SetTaxPercentage(10);

            PrintPersonInfo(employee);
            Console.WriteLine("---------------------");
            var applicant = new Applicant();
            applicant.SetName("Khaled", "Mohamad");
            applicant.SetBirthDate(new DateOnly(1996, 1, 1));
            PrintPersonInfo(applicant);
            Console.WriteLine("---------------------");
            //Console.WriteLine($"Basic Salary: {employee.BasicSalary}");
            //Console.WriteLine($"Tax Percentage: {employee.TaxPercentage}");

            Person person = employee;
            person = applicant;

            void PrintPersonInfo(Person person)
            {
                Console.WriteLine($"Full Name: {person.FirstName} {person.LastName}");
                Console.WriteLine($"Birth Date: {person.BirthDate}");
            }

        }
    }
}
