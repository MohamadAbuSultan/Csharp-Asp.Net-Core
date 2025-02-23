using Abstraction;
using Inheritance;

namespace Polymorphism
{
    internal class SalaryEmployee : Employee
    {
        public decimal BasicSalary { get; set; }

        public decimal Transportation { get; set; }
        public decimal Housing { get; set; }

        public override IEnumerable<PayItem> GetPayItems()
        {
            return new[]
            {
                new PayItem("Basic Salary", BasicSalary),
                new PayItem("Transportation", Transportation),
                new PayItem("Housing", Housing)
            };
        }

        public override decimal GetSalary()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            return BasicSalary + Transportation + Housing;
        }
        public decimal GetSalary(int taxPercentage)
        {
            return GetSalary() - (BasicSalary * taxPercentage / 100);
        }
        public decimal GetSalary(int taxPercentage, int bouns)
        {
            return GetSalary(taxPercentage) + bouns;
        }
    }
}
