using Inheritance;

namespace Polymorphism
{
    internal class FreelanceEmployee : Employee
    {
        public decimal HourRate { get; set; }
        public decimal TotalWorkingHours { get; set; }
        public override decimal GetSalary()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            return HourRate * TotalWorkingHours;
        }
    }
}
