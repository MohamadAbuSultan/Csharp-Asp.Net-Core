namespace Encapsulation
{
    internal class Employee
    {
        // Encapsulation
        // Encapsulation helps protect the object from entering an invalid state by making the properties private
        // or by restricting access to them. When properties are made private, direct access to them from external code is prevented.
        // Access and modification are allowed only through special methods that validate the values and ensure their validity.

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateOnly BirthDate { get; private set; }
        public decimal BasicSalary { get; set; }
        public int TaxPercentage { get; set; }
        
        public void SetName (string firstName,  string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("Invalid Name..");
            FirstName = firstName;
            LastName = lastName;
        }
        public void SetBirthDate(DateOnly birthDate)
        {
            if (birthDate < new DateOnly(1980, 1, 1))
            {
                throw new ArgumentException("Invalid birth date");
            }
            BirthDate = birthDate;
        }
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
