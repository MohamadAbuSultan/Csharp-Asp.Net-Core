namespace _01___Extension_Methods
{
    public static class NumberExtension
    {
        public static bool IsBetween(this int value, int min, int max)
        {
            return value >= min && value <= max;
        }
    }
}
