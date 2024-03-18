namespace CSharpFundamentals
{
    internal class Type_Casting
    {
        /* [ Type Casting ]
         - Implicit Casting بتتحول من الصغير للكبير 
         - Explicit Casting من الكبير للصغير
         */
        static void Main(string[] args)
        {
            int i = 5;
            // Implicit Casting
            float f = i;
            double d = i;
            double c = f;

            // float f2 = c; Cannot implicitly convert type 'double' to 'float'. An explicit conversion exists (are you missing a cast?)
            // int i2 = d; Cannot implicitly convert type 'double' to 'integer'.An explicit conversion exists(are you missing a cast?)
            // int i3 = f; Cannot implicitly convert type 'float' to 'integer'.An explicit conversion exists(are you missing a cast?)

            // Explicit Casting
            float f2 = 5.5f;
            int i2 = (int)f2;
            Console.WriteLine(i2);
            // Explicit Casting
            double d2 = 5.5;
            int i3 = (int)d2;
            Console.WriteLine(i3);
        }
    }
}
