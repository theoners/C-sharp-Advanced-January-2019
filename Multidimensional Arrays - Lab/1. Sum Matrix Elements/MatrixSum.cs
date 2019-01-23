namespace _1._Sum_Matrix_Elements
{
    using System;
    using System.Linq;

    public class MatrixSum
    {
        public static void Main()
        {
            var matrixSize = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var matrix = new int[matrixSize[0], matrixSize[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] columnElements = Console.ReadLine()
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = columnElements[col];
                }
            }

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));

            var matrixSum = 0;

            foreach (var element in matrix)
            {
                matrixSum += element;
            }

            Console.WriteLine(matrixSum);
        }
    }
}