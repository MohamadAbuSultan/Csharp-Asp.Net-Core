namespace Inheritance
{
    internal abstract class Person
    {
        // Inheritance ;- important things
        // it must me is-a relation ship
        // base class دور على ال
        // The classes that share common data should have a common relationship
        // or factor that brings them together so that we can justify using inheritance.
        // Example: Employee and Non (Applicant) - Employee classes; both represent individuals.
        // The common relationship that unites them is that they are people

        // Inheritance achieves the DRY principle
        // The DRY principle stands for "Don't Repeat Yourself,"
        // emphasizing the importance of avoiding code duplication in programming.

        // Inheritance achieves the usability principle." This means that by using inheritance,
        // we can enhance the usability of software by promoting code reusability and reducing redundancy

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
