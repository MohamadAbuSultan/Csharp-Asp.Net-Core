namespace CSharpFundamentals
{
    internal class String_Formatting
    {
        /* [ String Formatting ]
         * - Basic Formatting
         * - Control Spcaing
         * - Format Arguments (0.00, N2, C2)
         */
        static void Main12(string[] args)
        {
            // placeholders {0} {1} كأني حاجز مكان لداتا معينة هدخلها بعدين
            string str = "Hello {0}, My name is {1}";
            Console.WriteLine(str);
            str = string.Format(str, "ahmad", "mohamad");
            Console.WriteLine(str);

            str = "Hello My name is {1}";
            str = string.Format(str, "ahmad", "mohamad");
            Console.WriteLine(str);

            str = "Hello My name is {0} {1}";
            str = string.Format(str, "mohamad", "khaled");
            Console.WriteLine(str);

            str = "Hello My name is {0,15} {1,12}";
            str = string.Format(str, "mohamad", "khaled");
            Console.WriteLine(str);
            // الأرقام 15 و 12 لحجز مساحة معينة ، مثلاً بدي أحجز 15 حرف لكلمة سر أو لجدول

            Console.WriteLine("----------------");

            double salary = 3000;
            string str2 = "Your Salary is : {0}";
            str2 = string.Format(str2, salary);
            Console.WriteLine(str2);

            // C: Currency
            str2 = "Your Salary is : {0:C2}";
            str2 = string.Format(str2, salary);
            Console.WriteLine(str2);

            str2 = "Your Salary is : {0:C5}";
            str2 = string.Format(str2, salary);
            Console.WriteLine(str2);

            // N: Number
            str2 = "Your Salary is : {0:N2}";
            str2 = string.Format(str2, salary);
            Console.WriteLine(str2);

            str2 = "Your Salary is : {0:N5}";
            str2 = string.Format(str2, salary);
            Console.WriteLine(str2);

            str2 = "Your Salary is : {0:0.00}";
            str2 = string.Format(str2, salary);
            Console.WriteLine(str2);
        }
    }
}
