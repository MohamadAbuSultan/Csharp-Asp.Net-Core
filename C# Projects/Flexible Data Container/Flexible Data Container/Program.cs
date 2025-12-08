namespace Flexible_Data_Container
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataContainer<int> intContainer = new DataContainer<int>(42);
            intContainer.PrintData();

            DataContainer<string> stringContainer = new DataContainer<string>("Hello, World!");
            stringContainer.PrintData();
        }
    }

    internal class DataContainer<T>
    {
        private T _data;

        public DataContainer(T data)
        {
            _data = data;
        }

        public void PrintData()
        {
            Console.WriteLine($"Stored Data: {_data}, Type: {_data.GetType()}");
        }
    }
}
