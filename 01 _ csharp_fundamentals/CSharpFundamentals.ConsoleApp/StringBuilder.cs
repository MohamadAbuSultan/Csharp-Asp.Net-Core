namespace CSharpFundamentals
{
    internal class StringBuilder
    {
        /*
         * 
         * StringBuilder 
              Advantages of using StringBuilder:
                * Performance: StringBuilder is more efficient than string when making frequent modifications to strings.
                * Memory usage: StringBuilder reduces memory usage when concatenating multiple strings.
             
         */
        static void Main12(string[] args)
        {
            // immutable object مجرد ما تعطي الأوبجكت فاليو ما بيتغيرش 
            // immutable object: عندما نُعرّف متغيرًا من نوع string ونُعطيه قيمة، لا يمكننا تغيير هذه القيمة لاحقًا. تُسمى هذه الخاصية بـ "immutable".
            // immutable object: Once you assign a value to a string variable, you cannot change it.This property is called "immutable".

            string str = "Hello"; // "Hello" is stored in memory
            str = "Hello World"; // "Hello World" is stored in a new memory location
            str += "I love passionate coders"; // "I love passionate coders" is stored in a new memory location
                                               // 3 string objects are created in memory

            // StringBuilder وهنا بييجي دور ال 
            // StringBuilder: It is a mutable data type used to efficiently modify strings.
            // هو بيوحيلك أنو عدل في المكان إلي هو فيه بالميموري يعني محجزش مكان جديد
            // It allows you to modify the string in the same memory location without creating a new one
            StringBuilder sb = new StringBuilder(); // new: A keyword used to create a new instance of a specific data type.
            sb.Append("Hello, World!");
            sb.Append("I love passionate coders channel!");
            sb.Append("Thank u!");
            sb.AppendLine("Thank u!"); // modifies it by adding a new line of text بتضيف وبتنزل على سطر جديد
            // It first adds the text "Thank u!" to the end of the existing string in the StringBuilder
            // It then adds a newline character(\n) to the end, effectively creating a new line with the text "Thank u!" on it.
            // this line adds the message "Thank u!" followed by a newline character to the StringBuilder object.

            // stringbuilder بيحجز جواها 16 byte : 16 character
            Console.WriteLine($"length = {sb.Length}");
            // The Length is set to 0 by default.
            Console.WriteLine($"Capacity = {sb.Capacity}"); // Capacity: A property that returns the maximum length of the string that can be stored in StringBuilder.
            // The Capacity is set to 16 by default.
            Console.WriteLine($"MaxCapacity = {sb.MaxCapacity}");
            // The MaxCapacity is set to 2147483647.
            Console.WriteLine($"length = {sb.Length}"); // 13
            Console.WriteLine($"capacity = {sb.Capacity}"); // 16 (automatically increased)
            Console.WriteLine($"max capacity = {sb.MaxCapacity}"); // 2147483647
        }
    }
}