namespace Integer_Collection_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Collections.ArrayList arrayList = new System.Collections.ArrayList();
            arrayList.Add(10);
            arrayList.Add(20);
            arrayList.Add(30);
            arrayList.Add(40);
            arrayList.Add(50);

            int sum = 0;

            foreach (var item in arrayList)
            {
                if(item is int value)
                    sum += value;
                else
                    Console.WriteLine($"Warning: Found non-integer item: {item}");
            }

            Console.WriteLine(sum);
        }
    }
}
