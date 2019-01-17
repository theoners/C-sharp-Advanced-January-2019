namespace _8._Bombs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Bombs
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var matrix = new int[n][];
            GetMatrix(matrix, n);


            var bombIndex = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            BombExplode(matrix, bombIndex);
            List<int> aliveCells = AliveCells(matrix);
            Console.WriteLine($"Alive cells: {aliveCells.Count}");
            Console.WriteLine($"Sum: {aliveCells.Sum()}");
            PrintMatrix(matrix);
        }

        private static List<int> AliveCells(int[][] matrix)
        {
            var positiveNumbers = new List<int>();
            foreach (var numbers in matrix)
            {
                foreach (var number in numbers.Where(x => x > 0))
                {
                    positiveNumbers.Add(number);
                }
            }

            return positiveNumbers;
        }

        private static void BombExplode(int[][] matrix, string[] bombIndex)
        {
            for (int i = 0; i < bombIndex.Length; i++)
            {
                var bombRow = int.Parse(bombIndex[i].Split(",")[0]);
                var bombCol = int.Parse(bombIndex[i].Split(",")[1]);
                var bombDamage = matrix[bombRow][bombCol];
                if (bombDamage > 0)
                {
                    for (int row = bombRow - 1; row <= bombRow + 1; row++)
                    {
                        for (int col = bombCol - 1; col <= bombCol + 1; col++)
                        {
                            if (IsInside(matrix, row, col))
                            {
                                if (matrix[row][col] > 0)
                                {
                                    matrix[row][col] -= bombDamage;
                                }
                            }
                        }
                    }
                }
            }
        }

        private static bool IsInside(int[][] matrix, int bombRow, int bombCol)
        {
            return bombRow >= 0 && bombRow < matrix.Length && bombCol >= 0 && bombCol < matrix[bombRow].Length;
        }

        private static void PrintMatrix(int[][] matrix)
        {
            foreach (var numbers in matrix)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }

        private static void GetMatrix(int[][] matrix, int n)
        {
            for (int row = 0; row < n; row++)
            {
                var input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                matrix[row] = input;
            }
        }
    }
}
