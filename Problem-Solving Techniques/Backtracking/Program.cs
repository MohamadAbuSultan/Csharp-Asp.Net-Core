const int SIZE = 9;

int[,] board =
{
    { 5, 3, 0, 0, 7, 0, 0, 0, 0 },
    { 6, 0, 0, 1, 9, 5, 0, 0, 0 },
    { 0, 9, 8, 0, 0, 0, 0, 6, 0 },
    { 8, 0, 0, 0, 6, 0, 0, 0, 3 },
    { 4, 0, 0, 8, 0, 3, 0, 0, 1 },
    { 7, 0, 0, 0, 2, 0, 0, 0, 6 },
    { 0, 6, 0, 0, 0, 0, 2, 8, 0 },
    { 0, 0, 0, 4, 1, 9, 0, 0 ,5},
    {0, 0, 0, 0, 8, 0, 0, 7, 9}
};

SolveSudoku(board);
Console.WriteLine("Sudoku Board:");
PrintBoard(board);

void PrintBoard(int[,] board)
{
    for (int row = 0; row < SIZE; row++)
    {
        for (int col = 0; col < SIZE; col++)
        {
            Console.Write(board[row, col] + " ");
        }
        Console.WriteLine();
    }
}

bool SolveSudoku(int[,] board)
{
    for (int row = 0; row < SIZE; row++)
    {
        for (int col = 0; col < SIZE; col++)
        {
            if (board[row, col] == 0)
            {
                for (int num = 1; num <= SIZE; num++)
                {
                    if (IsValid(board, row, col, num))
                    {
                        board[row, col] = num;

                        if (SolveSudoku(board))
                            return true;

                        board[row, col] = 0;
                    }
                }
                return false;
            }
        }
    }
    return true;
}

bool IsValid(int[,] board, int row, int col, int num)
{
    for (int i = 0; i < SIZE; i++)
    {
        int boxRowStart = row - (row % 3);
        int boxColStart = col - (col % 3);

        if (board[row, i] == num
        || board[i, col] == num
        || board[boxRowStart + i / 3, boxColStart + i % 3] == num)
        {
            return false;
        }
    }
    return true;
}
