namespace Word_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[][] board = new char[][]
            {
                new char[] { 'X', 'O', 'X' },
                new char[] { 'O', 'X', 'O' },
                new char[] { 'X', 'O', 'X' }
            };



            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    char element = board[i][j];
                    Console.WriteLine("Element at row {0}, column {1}: {2}", i, j, element);
                }
            }
        }
    }
}