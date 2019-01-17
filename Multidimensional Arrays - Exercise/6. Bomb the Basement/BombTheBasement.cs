namespace _6._Bomb_the_Basement
{
    using System;
    using System.Linq;

    public class BombTheBasement
    {
        public static void Main()
        {
            var matrixSize = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var rows = matrixSize[0];
            var cols = matrixSize[1];
            var matrix = new int[rows,cols];

            GetMatrix(matrix);

            var bombParameters = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var bombRow = bombParameters[0];
            var bombCol = bombParameters[1];
            var bombRadius = bombParameters[2];

            ReplaceCells(matrix, bombRow, bombCol, bombRadius);
            ItemFallingDown(matrix);
            PrintMatrix(matrix);
        }

        private static void ItemFallingDown(int[,] matrix)
        {
            for (int rowIndex = 0; rowIndex < matrix.GetLength(0); rowIndex++)
            {
                for (int colIndex = 0; colIndex < matrix.GetLength(1); colIndex++)
                {
                    if (matrix[rowIndex,colIndex]==0)
                    {
                        for (int i = rowIndex; i < matrix.GetLength(0); i++)
                        {
                            if (matrix[i,colIndex]==1)
                            {
                                matrix[rowIndex, colIndex] = 1;
                                matrix[i, colIndex] = 0;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int rowIndex = 0; rowIndex < matrix.GetLength(0); rowIndex++)
            {
                for (int colIndex = 0; colIndex < matrix.GetLength(1); colIndex++)
                {
                    Console.Write(matrix[rowIndex,colIndex]);
                }

                Console.WriteLine();
            }
        }

        private static void ReplaceCells(int[,] matrix, int bombRow, int bombCol, int bombRadius)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (Math.Pow((row - bombRow), 2) + Math.Pow((col - bombCol), 2) <= Math.Pow(bombRadius, 2))
                    {
                        matrix[row,col] = 1;
                    }
                }
            }
        }

        private static void GetMatrix(int[,] matrix)
        {
            for (int rowIndex = 0; rowIndex < matrix.GetLength(0); rowIndex++)
            {
                for (int colIndex = 0; colIndex < matrix.GetLength(1); colIndex++)
                {
                    matrix[rowIndex, colIndex] = 0;
                }
            }
        }
    }
}
