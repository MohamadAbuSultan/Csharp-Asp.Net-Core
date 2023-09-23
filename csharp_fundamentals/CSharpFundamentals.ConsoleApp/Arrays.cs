namespace CSharpFundamentals
{
    internal class Arrays
    {
        static void Main6(string[] args)
        {
            // array (مجموعة قيم من نفس النوع (من نفس الداتا تايب
            int[] numbers = { 1, 2, 3, 4, 5 };
            //     index =    0  1  2  3  4
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Element {i + 1} = {numbers[i]}");
            }

            Console.WriteLine("----------------------");

            int[] numbers2 = { 1, 7, 3, 9, 5 };
            Array.Sort(numbers2); // Sort ترتيب العناصر
            for (int j = 0; j < numbers.Length; j++)
            {
                Console.WriteLine($"Element {j + 1} = {numbers2[j]}");
            }

            Console.WriteLine("----------------------");

            // copy array 
            int[] numbers3 = new int[5];
            Array.Copy(numbers, numbers3, numbers.Length); // بتنسخ numbers وبتحطها في numbers3
            // numbers.Length أنت هنا بتقله كم عنصر بدك تنسخ ، لما تكتب هيك بتقله إنسخ عناصر المصفوفة كلها
            // بس لازم تقله كم طول المصفوفة إلي بدك تحط فيها العناصر
            for (int k = 0; k < numbers.Length; k++)
            {
                Console.WriteLine($"Element {k + 1} = {numbers3[k]}");
            }
        }
    }
}
