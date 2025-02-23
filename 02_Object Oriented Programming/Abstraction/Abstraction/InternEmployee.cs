using Abstraction;
using Inheritance;

namespace Polymorphism
{
    internal class InternEmployee : Employee
    {
        public override IEnumerable<PayItem> GetPayItems()
        {
            return new[] { new PayItem("Basic Salary", 2000) };
        }

        public override decimal GetSalary()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            return 2000;
        }
    }
}
