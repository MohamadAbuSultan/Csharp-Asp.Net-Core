using Inheritance;

namespace Polymorphism
{
    internal class InternEmployee : Employee
    {
        public override decimal GetSalary()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            return 2000;
        }
    }
}
