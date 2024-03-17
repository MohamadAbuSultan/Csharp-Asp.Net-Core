using System.Text.RegularExpressions;

namespace CSharpFundamentals
{
    internal class Palindrom_String
    {
        static void Main10(string[] args)
        {
            string word1 = ReadWord();
            string word2 = ReverseWord(word1);
            if (word1 == word2)
            {
                Console.WriteLine("Is Palindrom");
            }
            else
            {
                Console.WriteLine("Not Palindrom");
            }
        }
        static string ReadWord()
        {
            string word;
            do
            {
                Console.Write("Enter a valid word: ");
                word = Console.ReadLine();
            } while (string.IsNullOrEmpty(word) ||
                    string.IsNullOrWhiteSpace(word) ||
                    ContainsDigits(word));
            return word;
        }
        static string ReverseWord(string word)
        {
            //string result = "";
            //for (int i = word.Length - 1; i >= 0; i--)
            //{
            //    result += word[i];
            //}
            //return result;
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        static bool ContainsDigits(string input)
        {
            // Use a regular expression to check if the input contains any digits
            return Regex.IsMatch(input, @"\d");
            // regex ما كنت بعرفها ، طلعتها من البحث
        }
    }
}
