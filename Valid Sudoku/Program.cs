using System.Runtime;

namespace Valid_Sudoku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[][] sudokuArray = new char[][] {
    new char[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
    new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
    new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
    new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
    new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
    new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
    new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
    new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
    new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
};


            Console.WriteLine(IsValidSudoku(sudokuArray));
            
        }


        public static bool IsValidSudoku(char[][] board)
        {


            foreach (var row in board)
            {

                bool rowHasDuplicates = row.Where(c => c != '.')
                                           .GroupBy(c => c)
                                           .Any(group => group.Count() > 1);

                if (rowHasDuplicates)
                {
                    return false;
                }
            }

            for (int col = 0; col < board[0].Length; col++)
            {
                bool colHasDuplicates = Enumerable.Range(0, board.Length)
                                                 .Select(row => board[row][col])
                                                 .Where(c => c != '.')
                                                 .GroupBy(c => c)
                                                 .Any(group => group.Count() > 1);

                if (colHasDuplicates)
                {
                    return false;
                }
            }



            List<int> temp = new List<int>();


            for (int boxRow = 0; boxRow < 9; boxRow += 3)
            {
                for (int boxCol = 0; boxCol < 9; boxCol += 3)
                {
                    bool boxHasDuplicates = Enumerable.Range(boxRow, 3)
                                                      .SelectMany(row => Enumerable.Range(boxCol, 3).Select(col => board[row][col]))
                                                      .Where(c => c != '.')
                                                      .GroupBy(c => c)
                                                      .Any(group => group.Count() > 1);

                    if (boxHasDuplicates)
                    {
                        return false;
                    }
                }
            }

            return true;

        }
    }
}