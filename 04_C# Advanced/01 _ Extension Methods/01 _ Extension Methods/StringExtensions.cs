namespace _01___Extension_Methods
{
    public static class StringExtensions
    {
        public static string RemoveWhiteSpaces(this string value)
        {
            return value.Replace(" ", "");
        }

        public static string Reverse(this string value)
        {
            var charArray = value.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
