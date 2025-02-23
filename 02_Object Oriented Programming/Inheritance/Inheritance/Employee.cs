namespace Inheritance
{
    internal class Employee : Person
    {
        public decimal BasicSalary { get; set; }
        public int TaxPercentage { get; set; }
        public void SetBasicSalary(decimal basicSalary)
        {
            if (basicSalary < 6000)
                throw new ArgumentException("Invalid Basic Salary");
            BasicSalary = basicSalary;
        }
        public void SetTaxPercentage(int taxPercentage)
        {
            if (taxPercentage > 10)
                throw new ArgumentException("Invalid tax percentage");
            TaxPercentage = taxPercentage;
        }

    }
}
