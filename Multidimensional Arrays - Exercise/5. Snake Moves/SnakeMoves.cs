namespace _5._Snake_Moves
{
    using System;
    using System.Linq;

    public class SnakeMoves
    {
        public static void Main()
        {
            var matrixSize = Console.ReadLine()?
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            //second zero test - input is Empty :)
            if (matrixSize.Length == 0)
            {
                return;
            }

            var matrix = new char[matrixSize[0]][];
            var text = Console.ReadLine().ToCharArray();

            GetMatrix(matrix, text, matrixSize[1]);
            PrintMatrix(matrix);
        }

        private static void PrintMatrix(char[][] matrix)
        {
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join("", row));
            }
        }

        private static void GetMatrix(char[][] matrix, char[] text, int size)
        {
            var charCounter = 0;
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new char[size];

                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = text[charCounter % text.Length];
                    charCounter++;
                }
            }
        }
    }
}
