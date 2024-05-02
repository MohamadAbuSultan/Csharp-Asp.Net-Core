namespace Inheritance
{
    internal abstract class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateOnly BirthDate { get; private set; }


        public void SetName(string firstName, string lastName)
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
    }
}
