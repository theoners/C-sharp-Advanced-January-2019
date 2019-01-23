namespace _5._Square_With_Maximum_Sum
{
    using System;
    using System.Linq;

    public class MaxSum
    {
        public static void Main()
        {
            var size = Console.ReadLine()
                .Split(",")
                .Select(int.Parse)
                .ToArray();

            var matrix = new int[size[0], size[1]];

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

            var maxSum = int.MinValue;
            var rowIndex = 0;
            var colIndex = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {

                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    var currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] +
                                     matrix[row + 1, col + 1];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        rowIndex = row;
                        colIndex = col;
                    }
                }

            }

            Console.WriteLine($"{matrix[rowIndex, colIndex]} {matrix[rowIndex, colIndex + 1]}");
            Console.WriteLine($"{matrix[rowIndex + 1, colIndex]} {matrix[rowIndex + 1, colIndex + 1]}");
            Console.WriteLine(maxSum);
        }
    }
}