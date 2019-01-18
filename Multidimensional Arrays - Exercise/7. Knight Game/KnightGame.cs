namespace _7._Knight_Game
{
    using System;

    public class KnightGame
    {
        public static void Main()
        {
            int matrixSize = int.Parse(Console.ReadLine());
            var matrix = new char[matrixSize][];
            GetMatrix(matrix);
            var removeKnights = 0;

            while (true)
            {
                bool isRemoved = RemoveKnight(matrix);
                if (isRemoved == false)
                {
                    break;
                }

                removeKnights++;
            }

            Console.WriteLine(removeKnights);

        }

        private static bool RemoveKnight(char[][] matrix)
        {
            var knightWithMostFight = 0;
            int row = -1;
            int col = -1;
            for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            {
                for (int colIndex = 0; colIndex < matrix[rowIndex].Length; colIndex++)
                {
                    if (matrix[rowIndex][colIndex] == 'K')
                    {
                        var currentKnightFights = CheckCells(matrix, rowIndex, colIndex);

                        if (currentKnightFights > knightWithMostFight)
                        {
                            knightWithMostFight = currentKnightFights;
                            row = rowIndex;
                            col = colIndex;
                        }
                    }
                }
            }

            if (IsInside(matrix, row, col))
            {
                matrix[row][col] = '0';
                return true;
            }
            return false;
        }

        private static int CheckCells(char[][] matrix, int rowIndex, int colIndex)
        {
            var knightFightsCount = 0;
            var currentRow = rowIndex - 2;
            var currentCol = colIndex - 1;
            knightFightsCount = CheckForKnight(matrix, currentRow, currentCol, knightFightsCount);

            currentRow = rowIndex - 2;
            currentCol = colIndex + 1;
            knightFightsCount = CheckForKnight(matrix, currentRow, currentCol, knightFightsCount);

            currentRow = rowIndex + 2;
            currentCol = colIndex + 1;
            knightFightsCount = CheckForKnight(matrix, currentRow, currentCol, knightFightsCount);

            currentRow = rowIndex + 2;
            currentCol = colIndex - 1;
            knightFightsCount = CheckForKnight(matrix, currentRow, currentCol, knightFightsCount);

            currentRow = rowIndex - 1;
            currentCol = colIndex - 2;
            knightFightsCount = CheckForKnight(matrix, currentRow, currentCol, knightFightsCount);

            currentRow = rowIndex - 1;
            currentCol = colIndex + 2;
            knightFightsCount = CheckForKnight(matrix, currentRow, currentCol, knightFightsCount);

            currentRow = rowIndex + 1;
            currentCol = colIndex - 2;
            knightFightsCount = CheckForKnight(matrix, currentRow, currentCol, knightFightsCount);

            currentRow = rowIndex + 1;
            currentCol = colIndex + 2;
            knightFightsCount = CheckForKnight(matrix, currentRow, currentCol, knightFightsCount);


            return knightFightsCount;
        }

        private static int CheckForKnight(char[][] matrix, int currentRow, int currentCol, int knightFightsCount)
        {
            var isValidCell = IsInside(matrix, currentCol, currentRow);
            if (isValidCell)
            {
                if (matrix[currentRow][currentCol] == 'K')
                {
                    return ++knightFightsCount;
                }
            }

            return knightFightsCount;
        }

        private static bool IsInside(char[][] matrix, int rowIndex, int colIndex)
        {
            return rowIndex >= 0 && rowIndex < matrix.Length && colIndex >= 0 && colIndex < matrix.Length;
        }

        private static void GetMatrix(char[][] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                var line = Console.ReadLine()?.ToCharArray();
                matrix[row] = line;
            }
        }
    }
}
