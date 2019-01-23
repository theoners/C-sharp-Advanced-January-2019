namespace _4._Symbol_in_Matrix
{
    using System;

    public class SymbolInMatrix
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            var matrix = new char[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var input = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            var symbol = char.Parse(Console.ReadLine());

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    var currentSymbol = matrix[row, col];

                    if (currentSymbol == symbol)
                    {
                        var rowIndex = row;
                        var colIndex = col;

                        Console.WriteLine($"({rowIndex}, {colIndex})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{symbol} does not occur in the matrix");
        }
    }
}