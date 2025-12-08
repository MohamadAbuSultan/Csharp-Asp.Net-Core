namespace The_Sentence_Reverser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string reverseWords2 = SentenceReverser.ReverseWords("The sky is blue");
            Console.WriteLine(reverseWords2);
        }
    }

    //internal static class SentenceReverser
    //{
    //    public static string ReverseWords(string sentence)
    //    {
    //        if (string.IsNullOrWhiteSpace(sentence)) return sentence;

    //        var words = sentence.Split(' ');

    //        Array.Reverse(words);

    //        return string.Join(" ", words);
    //    }
    //}
    internal static class SentenceReverser
    {
        public static string ReverseWords(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence)) return sentence;

            string result = " ";
            var words = sentence.Split(' ');

            for (int i = words.Length - 1; i >= 0; i--)
            {
                result += words[i].ToString();
                if (i > 0) result += " ";
            }

            return result;
        }
    }
}
