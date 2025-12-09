namespace Indexers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            arr[0] = 100; // Using the indexer to set the first element

            string str = "Hello";
            char firstChar = str[0]; // Using the indexer to get the first character

            IP ipAddress = new IP(192, 168, 1, 17);
            //Console.WriteLine(ipAddress.Address);

            var firstIndex = ipAddress[0];
            //Console.WriteLine(firstIndex);

            var ip = new IP("192.168.1.10");
            //Console.WriteLine(ip.Address);

            int[,] sudokuPuzzle = new int[,]
            {
                {0,0,0,2,6,0,7,0,1},
                {6,8,0,0,7,0,0,9,0},
                {1,9,0,0,0,4,5,0,0},
                {8,2,0,1,0,0,0,4,0},
                {0,0,4,6,0,2,9,0,0},
                {0,5,0,0,0,3,0,2,8},
                {0,0,9,3,0,0,0,7,4},
                {0,4,0,0,5,0,0,3,6},
                {7,0,3,0,1,8,0,0,0}
            };

            var suduko = new Suduko(sudokuPuzzle);
            Console.WriteLine(suduko[1, 1]);
        }
    }

    internal class IP
    {
        private int[] segments = new int[4];

        public int this[int index]
        {
            get
            {
                return segments[index];
            }
            set
            {
                segments[index] = value;
            }
        }

        public IP(string IPAddress)
        {
            var seg = IPAddress.Split(".");

            for (int i = 0; i < seg.Length; i++)
            {
                segments[i] = Convert.ToInt32(seg[i]);
            }
        }

        public IP(int segment1, int segment2, int segment3, int segment4)
        {
            segments[0] = segment1;
            segments[1] = segment2;
            segments[2] = segment3;
            segments[3] = segment4;
        }

        public string Address => string.Join(".", segments);
    }

    internal class Suduko
    {
        private int[,] _matrix;

        public int this[int row, int col]
        {
            get
            {
                return _matrix[row, col];
            }
            set
            {
                _matrix[row, col] = value;
            }
        }

        public Suduko(int[,] matrix){
            _matrix = matrix;   
        }
    }
}
