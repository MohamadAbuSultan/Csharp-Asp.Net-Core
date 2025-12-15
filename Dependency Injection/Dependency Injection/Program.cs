namespace Dependency_Injection
{
    public interface IToolUser
    {
        void SetHammer(Hammer hammer);
        void SetSaw(Saw saw);
    }

    public class Hammer
    {
        public void Use()
        {
            Console.WriteLine("Hammering Nails!");
        }
    }

    public class Saw
    {
        public void Use()
        {
            Console.WriteLine("Sawing Wood!");
        }
    }

    public class Builder : IToolUser
    {
        private Hammer _hammer;
        private Saw _saw;

        // Constructor Injection
        public Builder(Hammer hammer, Saw saw)
        {
            _hammer = hammer;
            _saw = saw;
        }

        // Setter Injection 
        public Hammer Hammer
        {
            get => _hammer;
            set => _hammer = value;
        }

        public Saw Saw
        {
            get => _saw;
            set => _saw = value;
        }

        public void BuildHouse()
        {
            _hammer.Use();
            _saw.Use();
            Console.WriteLine("House built");
        }

        // Interface Injection
        public void SetHammer(Hammer hammer)
        {
            _hammer = hammer;
        }

        public void SetSaw(Saw saw)
        {
            _saw = saw;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Hammer hammer = new Hammer();
            Saw saw = new Saw();

            // -------------------------------
            // Constructor Injection
            // -------------------------------
            Builder builder1 = new Builder(hammer, saw);
            Console.WriteLine("Constructor Injection");
            builder1.BuildHouse();

            // -------------------------------
            // Setter Injection
            // -------------------------------
            Builder builder2 = new Builder(null, null);
            builder2.Hammer = hammer;
            builder2.Saw = saw;
            Console.WriteLine("\nSetter Injection");
            builder2.BuildHouse();

            // -------------------------------
            // Interface Injection
            // -------------------------------
            Builder builder3 = new Builder(null, null);
            builder3.SetHammer(hammer);
            builder3.SetSaw(saw);
            Console.WriteLine("\nInterface Injection");
            builder3.BuildHouse();
        }
    }
}
