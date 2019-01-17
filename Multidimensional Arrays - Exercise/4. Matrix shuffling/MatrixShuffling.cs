namespace _4._Matrix_shuffling
{
    using System;
    using System.Linq;

    public class MatrixShuffling
    {
        public static void Main()
        {
            var matrixSize = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var rows = matrixSize[0];
            var cols = matrixSize[1];

            var matrix = new string[rows, cols];
            GetMatrix(matrix);

            while (true)
            {
                var input = Console.ReadLine().Split();

                if (input[0] == "END")
                {
                    break;
                }
                if (input[0] == "swap" && input.Length == 5)
                {
                    var firstRow = int.Parse(input[1]);
                    var firstCol = int.Parse(input[2]);
                    var secondRow = int.Parse(input[3]);
                    var SecondCol = int.Parse(input[4]);

                    bool firstIsValid = IsInside(firstRow, firstCol, matrix);
                    bool secondIsValid = IsInside(secondRow, SecondCol, matrix);

                    if (firstIsValid && secondIsValid)
                    {
                        var tempNumber = matrix[firstRow, firstCol];
                        matrix[firstRow, firstCol] = matrix[secondRow, SecondCol];
                        matrix[secondRow, SecondCol] = tempNumber;

                        PrintMatrix(matrix);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }

        private static void GetMatrix(string[,] matrix)
        {
            for (int rowIndex = 0; rowIndex < matrix.GetLength(0); rowIndex++)
            {
                var currentLine = Console.ReadLine()
                    .Split();

                for (int colIndex = 0; colIndex < matrix.GetLength(1); colIndex++)
                {
                    matrix[rowIndex, colIndex] = currentLine[colIndex];
                }
            }
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int rowIndex = 0; rowIndex < matrix.GetLength(0); rowIndex++)
            {
                for (int colIndex = 0; colIndex < matrix.GetLength(1); colIndex++)
                {
                    Console.Write(matrix[rowIndex, colIndex] + " ");
                }

                Console.WriteLine();
            }
        }

        private static bool IsInside(int firstRow, int firstCol, string[,] matrix)
        {
            return firstRow >= 0 && firstRow < matrix.GetLength(0) && firstCol >= 0 && firstCol < matrix.GetLength(1);
        }
    }
}
