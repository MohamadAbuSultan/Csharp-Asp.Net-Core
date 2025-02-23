using Abstraction;
using Inheritance;

namespace Polymorphism
{
    internal class FreelanceEmployee : Employee
    {
        public decimal HourRate { get; set; }
        public decimal TotalWorkingHours { get; set; }

        public override IEnumerable<PayItem> GetPayItems()
        {
            return new[] { new PayItem("Total Hours", GetSalary()) };
        }

        public override decimal GetSalary()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            return HourRate * TotalWorkingHours;
        }
    }
}
