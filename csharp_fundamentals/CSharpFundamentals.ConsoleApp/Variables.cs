namespace CSharpFundamentals
{
    internal class Variables
    {
        static void Main(string[] args)
        {
            string statementToPrint = "Hello , passionate coders";
            Console.WriteLine(statementToPrint);
            Console.WriteLine(statementToPrint);
            Console.WriteLine(statementToPrint);
            Console.WriteLine(statementToPrint);
            Console.WriteLine(statementToPrint); // حاجز مساحة في الميموري مرة واحدة وليس خمس مرات


            // Boolean  
            bool isAlive = false;
            Console.Write("IsAlive = ");
            Console.WriteLine(isAlive);


            // Character
            Console.Write("Write any Character then press enter : ");
            int i = Console.Read();
            //ASCII code
            Console.WriteLine(i);
            char c = 'A';
            Console.WriteLine(c);
            Console.WriteLine((int)c);
            bool isDigit = char.IsDigit('1');
            Console.WriteLine(isDigit);
            isDigit = char.IsDigit('A');
            Console.WriteLine(isDigit);
            bool isLetter = char.IsLetter('A');
            Console.WriteLine(isLetter);


            // String
            Console.WriteLine("\\tHello\nWorld");
            string first = "Mohamad";
            string last = " Sult";
            Console.WriteLine(first + last);
            Console.WriteLine(@"\\tHello
            \nWorld
            this is moh."); // @ بتقول للكومبايلر عامل كل النص كأنه واحد 
            // @ بتلغي تأثير ال special characters
            // @ بتخليني أعمل ال string على أكثر من سطر multiple lines string
            //string name1 = "MOH";
            //Console.WriteLine($"Hello {name1} , how are u today ? "); // string template {}  ||  string intrpolation {}
            Console.Write("Enter Your Name: ");
            string name = "";
            name = Console.ReadLine();
            Console.WriteLine($"Hello {name}, that's very nice name !");
            Console.WriteLine($"Length of your name : {name.Length}");
            Console.WriteLine($"Upper Case : {name.ToUpper()}");
            Console.WriteLine($"Lower Case : {name.ToLower()}");
            Console.WriteLine(name.StartsWith("M"));
            Console.WriteLine(name.StartsWith("m"));
            Console.WriteLine(name.StartsWith("MOH"));
            Console.WriteLine(name.StartsWith("MOH", StringComparison.OrdinalIgnoreCase)); // convert from CaseSensitive TO InCaseSensitive , IgnoreCase من إسمها
            Console.WriteLine(name.EndsWith("ad"));
            Console.WriteLine(name.EndsWith("ad", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(name.Contains("ad"));
            Console.WriteLine(name.Contains("ad", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(name.IndexOf("m"));
            Console.WriteLine(name.IndexOf("ad", StringComparison.OrdinalIgnoreCase)); // وين بتبدأ بالزبط ؟ ، مكان بدايتها ؟
            Console.WriteLine(name.LastIndexOf("m")); // آخر مكان ، آخر نتيجة بتطلع 
            Console.WriteLine(name.Replace("MOHAMAD", "AHMED"));
        }
    }
}
