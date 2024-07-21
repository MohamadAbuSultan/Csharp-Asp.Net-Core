using System.Collections;

namespace _07___Enumerables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var employee = new Employee();
            employee.AddPayItem("Basic Salary", 1000);
            employee.AddPayItem("Housing", 500);
            employee.AddPayItem("Transportation", 200);
            employee.AddPayItem("Insurance", -300);

            //var payitems = employee.GetPayItems();
            //var enumerator = employee.GetEnumerator();

            //foreach (var payItem in employee)
            //    Console.WriteLine($"{payItem.Name} = {payItem.Value}");

            //var test = new TestYield();
            //foreach (var item in test)
            //    Console.WriteLine(item);

            for (var i = 0; i < employee.Count(); i++)
                Console.WriteLine($"{employee[i].Name} = {employee[i]).Value}");
        }

        public class TestYield : IEnumerable<int>
        {
            public IEnumerator<int> GetEnumerator()
            {
                yield return 1;
                yield return 2;
                yield return 3;
                yield return 4;
                yield return 5;
            }
            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
    }
}