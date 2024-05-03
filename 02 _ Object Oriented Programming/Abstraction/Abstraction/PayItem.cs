namespace Abstraction
{
    internal class PayItem
    {
        public PayItem(string name, decimal value)
        {
            Name = name;
            Value = value;
        }
        // immutable object
        public string Name { get; private set; }
        public decimal Value { get; private set; }
    }
}
