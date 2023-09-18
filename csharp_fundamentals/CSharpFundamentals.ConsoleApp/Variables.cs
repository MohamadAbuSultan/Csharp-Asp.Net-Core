namespace CSharpFundamentals
{
    internal class Variables
    {
        static void Main3(string[] args)
        {
            //string statementToPrint = "Hello , passionate coders";
            //Console.WriteLine(statementToPrint);
            //Console.WriteLine(statementToPrint);
            //Console.WriteLine(statementToPrint);
            //Console.WriteLine(statementToPrint);
            //Console.WriteLine(statementToPrint); // حاجز مساحة في الميموري مرة واحدة وليس خمس مرات


            //// Boolean  
            //bool isAlive = false;
            //Console.Write("IsAlive = ");
            //Console.WriteLine(isAlive);


            //// Character
            //Console.Write("Write any Character then press enter : ");
            //int i = Console.Read();
            ////ASCII code
            //Console.WriteLine(i);
            //char c = 'A';
            //Console.WriteLine(c);
            //Console.WriteLine((int)c);
            //bool isDigit = char.IsDigit('1');
            //Console.WriteLine(isDigit);
            //isDigit = char.IsDigit('A');
            //Console.WriteLine(isDigit);
            //bool isLetter = char.IsLetter('A');
            //Console.WriteLine(isLetter);


            //// String
            //Console.WriteLine("\\tHello\nWorld");
            //string first = "Mohamad";
            //string last = " Sult";
            //Console.WriteLine(first + last);
            //Console.WriteLine(@"\\tHello
            //\nWorld
            //this is moh."); // @ بتقول للكومبايلر عامل كل النص كأنه واحد 
            // @ بتلغي تأثير ال special characters
            // @ بتخليني أعمل ال string على أكثر من سطر multiple lines string
            //string name1 = "MOH";
            //Console.WriteLine($"Hello {name1} , how are u today ? "); // string template {}  ||  string intrpolation {}
            //Console.Write("Enter Your Name: ");
            //string name = "";
            //name = Console.ReadLine();
            //Console.WriteLine($"Hello {name}, that's very nice name !");
            //Console.WriteLine($"Length of your name : {name.Length}");
            //Console.WriteLine($"Upper Case : {name.ToUpper()}");
            //Console.WriteLine($"Lower Case : {name.ToLower()}");
            //Console.WriteLine(name.StartsWith("M"));
            //Console.WriteLine(name.StartsWith("m"));
            //Console.WriteLine(name.StartsWith("MOH"));
            //Console.WriteLine(name.StartsWith("MOH", StringComparison.OrdinalIgnoreCase)); // convert from CaseSensitive TO InCaseSensitive , IgnoreCase من إسمها
            //Console.WriteLine(name.EndsWith("ad"));
            //Console.WriteLine(name.EndsWith("ad", StringComparison.OrdinalIgnoreCase));
            //Console.WriteLine(name.Contains("ad"));
            //Console.WriteLine(name.Contains("ad", StringComparison.OrdinalIgnoreCase));
            //Console.WriteLine(name.IndexOf("m"));
            //Console.WriteLine(name.IndexOf("ad", StringComparison.OrdinalIgnoreCase)); // وين بتبدأ بالزبط ؟ ، مكان بدايتها ؟
            //Console.WriteLine(name.LastIndexOf("m")); // آخر مكان ، آخر نتيجة بتطلع 
            //Console.WriteLine(name.Replace("MOHAMAD", "AHMED"));

            //// integer
            //int int1 = 0;
            //int int2 = 50;
            //int int3 = -50;
            //// unsigned int
            //uint uint1 = 0;
            //uint uint2 = 50;
            //uint uint3 = -50; // not allowed
            //Console.WriteLine($"Integer Memory Size : {sizeof(int)}"); // 4
            //Console.WriteLine($"Unsigned Integer Memory Size : {sizeof(uint)}"); // 4
            //Console.WriteLine($"long Integer Memory Size : {sizeof(long)}"); // 8
            //Console.WriteLine($"Unsigned long Integer Memory Size : {sizeof(long)}"); // 8
            //Console.WriteLine("____________________________");
            //Console.WriteLine($"Int Min Value : {int.MinValue}"); // -2147483648
            //Console.WriteLine($"Int Max Value : {int.MaxValue}"); // 2147483647
            //Console.WriteLine("____________________________");
            //Console.WriteLine($"Unsigned Int Min Value : {uint.MinValue}"); // 0 لأنه موجب لا يقبل السالب
            //Console.WriteLine($"Unsigned Int Max Value : {uint.MaxValue}"); // 4294967295
            //Console.WriteLine("____________________________");
            //Console.WriteLine($"long Int Min Value : {long.MinValue}"); // -9223372036854775808
            //Console.WriteLine($"long Int Max Value : {long.MaxValue}"); // 9223372036854775807
            //Console.WriteLine($"Unsigned long Max Value : {ulong.MaxValue}"); // 18446744073709551615

            // float & double
            //Console.WriteLine($"float Memory Size : {sizeof(float)}"); // 4
            //Console.WriteLine($"double Memory Size : {sizeof(double)}"); // 8
            //Console.WriteLine($"float Min Value : {float.MinValue}"); // -3.4028235E+38
            //Console.WriteLine($"float Max Value : {float.MaxValue}"); // 3.4028235E+38
            //Console.WriteLine($"double Min Value : {double.MinValue}"); // -1.7976931348623157E+308
            //Console.WriteLine($"double Max Value : {double.MaxValue}"); // 1.7976931348623157E+308
            float f = 5.53456971231259f;
            double d = 5.53456971231259;
            Console.WriteLine($"float {f}");
            Console.WriteLine($"Double {d}");
            // هي في دقة الكسر float و double الفرق الجوهري بين 
        }
    }
}
