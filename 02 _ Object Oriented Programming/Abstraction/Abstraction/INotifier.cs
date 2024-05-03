namespace Abstraction
{
    internal interface INotifier
    {
        // interface : contract without implementaion, all are abstract , all just public
        // abstract : contract with implementaion 
        // class don't support inheritance with more than 1 class ,
        // we can do implementation with more than 1 interface

        // Interfaces vs Abstract classes
        // Interfaces are contracts that define a set of methods that classes must implement.
        // Interfaces can only have abstract methods
        // Interfaces cannot be instantiated directly
        // Abstract classes are also contracts but they can have:Implemented methods(written already) - Abstract methods - Variables
        // Abstract classes cannot be instantiated directly
        // A class can inherit from only one abstract class, but it can implement multiple interfaces
        // In general
        // We use interfaces to define a common behavior that different classes should follow
        // We use abstract classes to provide default implementations for some methods that subclasses can use or override
        void Notify(string email, string subject, string body);
    }
}
