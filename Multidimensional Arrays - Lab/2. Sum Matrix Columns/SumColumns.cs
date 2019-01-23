namespace _2._Sum_Matrix_Columns
{
    using System;
    using System.Linq;

    public class SumColumns
    {
        public static void Main()
        {
            var matrixSize = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            var matrix = new int[matrixSize[0], matrixSize[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var numbers = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                var columnSum = 0;

                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    columnSum += matrix[j, i];
                }
                Console.WriteLine(columnSum);
            }
        }
    }
}