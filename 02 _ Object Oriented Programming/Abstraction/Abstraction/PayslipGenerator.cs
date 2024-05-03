using Inheritance;
using System.Text;

namespace Abstraction
{
    internal class PayslipGenerator
    {
        private readonly INotifier _notifier;
        public PayslipGenerator(INotifier notifier)
        {
            _notifier = notifier;
        }

        //                   Abstraction هنا ال 
        public void Generate(Employee employee)
        {
            var payItems = employee.GetPayItems();
            var message = new StringBuilder();
            message.AppendLine($"Dear {employee.FirstName} {employee.LastName},");
            message.AppendLine("Please find below your payslip details");
            foreach (var item in payItems)
                message.AppendLine($"{item.Name}\t\t{item.Value}");
            _notifier.Notify(employee.Email, "Payslip Generated !", message.ToString());
        }
    }
}
