using System.Collections;

namespace Dictionary__SortedList___Hashtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // key value pairs
            // used in configuration settings
            // used in caching data
      

            // Dictionary collection class is found in System.Collections.Generic namespace
            // Dictionary<TKey,TValue> class represents a collection of key/value pairs
            // that are organized based on the key.

            //System.Collections.Generic.Dictionary<int, string> myDictionary = 
            //    new System.Collections.Generic.Dictionary<int, string>();

            // Dictionary<TKey,TValue>
            Dictionary<string, int> ages = new Dictionary<string, int>();
            ages.Add("Mohamad", 24);
            ages.Add("Ali", 29);
            ages.Add("Hassan", 34);
            // keys must be unique
            // values can be duplicate
            var ageOfMo = ages["Mohamad"];
            //Console.WriteLine(ageOfMo);

            //foreach (var kvp in ages)
            //{
            //    Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            //}


            // SortedList uses a binary search algorithm to store the key/value pairs
            // in sorted order based on the key.
            // SortedList<TKey, TValue> works like Dictionary<TKey, TValue>,
            // but the keys are stored in sorted order.
            SortedList<int, string> employeeNumber = new SortedList<int, string>();
            employeeNumber.Add(24, "Mohamad");
            employeeNumber.Add(29, "Ali");
            employeeNumber.Add(34, "Hassan");
            //foreach (var kvp in employeeNumber)
            //{
            //    Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            //}


            // Hashtable - non-generic collection
            // obsolete 
            Hashtable employeeNumber2 = new Hashtable();
            employeeNumber2.Add(24, "Mohamad");
            employeeNumber2.Add(25, "Omar");
            employeeNumber2.Add(26, "M");
            employeeNumber2.Add(30, "H");

            foreach (var item in employeeNumber2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
