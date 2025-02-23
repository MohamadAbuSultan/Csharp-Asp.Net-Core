using Abstraction;

namespace Inheritance
{
    internal abstract class Employee : Person
    {
        public string Email { get; internal set; }

        public abstract decimal GetSalary();
        public abstract IEnumerable<PayItem> GetPayItems();
    }
}