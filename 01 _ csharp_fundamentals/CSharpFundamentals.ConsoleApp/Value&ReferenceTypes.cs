namespace CSharpFundamentals
{
    internal class Value_ReferenceType
    {
        static void Main16(string[] args)
        {
            // value type:> stack
            // reference :> heap
            int number = 5;
            DuplicateValue(number);
            Console.WriteLine(number);

            int[] numbers = { 1, 2, 3 };
            DuplicateArrayValues(numbers);
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            string str = "Hello ";
            str += "world"; // قيمة str تم أخذ منها نسخة وإنحط عليها قيمة world وإتعمل متغير جديد وإنحجز مكان جديد خالص في الميموري
            // هاي بتسوي مشكلة جداً كبيرة بالمشاريع إسمهاmemory leak 
            // الميموري بتضلها تزيد تزيد ما بتنزلش ، معلومة مهمة جداً
            //immutable in the sense of memory.
            //It creates new objects every time you create strings or assign a new string/ change the value.
            //That's why it is advisable to be careful when using strings. Charbuffer would be better. –
            //String is immutable(once created can not be changed) object.
            //The object created as a String is stored in the Constant String Pool.
            //Every immutable object in Java is thread safe ,
            //that implies String is also thread safe.String can not be used by two threads simultaneously.
            //String once assigned can not be changed. – 

            //int num1 = 5;
            //int num2 = num1;
            //num1 = 10;
            //Console.WriteLine($"num1 = {num1}");
            //Console.WriteLine($"num2 = {num2}");
            //int[] numbers1 = { 1 };
            //int[] numbers2 = numbers1;
            //numbers1[0] = 10;
            //Console.WriteLine($"numbers1 = {numbers1[0]}");
            //Console.WriteLine($"numbers2 = {numbers2[0]}");
        }
        static void DuplicateValue(int number)
        {
            number *= 2;
        }
        static void DuplicateArrayValues(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= 2;
            }
        }
    }
}
