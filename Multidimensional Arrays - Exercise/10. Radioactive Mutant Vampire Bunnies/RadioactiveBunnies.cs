namespace _10._Radioactive_Mutant_Vampire_Bunnies
{
    using System;
    using System.Linq;

    public class RadioactiveBunnies
    {
        public static void Main()
        {
            var matrixSize = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var field = new char[matrixSize[0]][];

            GetField(field, matrixSize[1]);
            var commands = Console.ReadLine().ToCharArray();
            int[] playerPosition = PLayerPositions(field);
            bool isWon = false;
            bool isLost = false;
            for (int i = 0; i < commands.Length; i++)
            {
                bool isDead;
                int[] newPosition = ReturnNewPositions(field, commands[i], playerPosition);
                if (newPosition.Contains(-1) && !isWon)
                {
                    field[playerPosition[0]][playerPosition[1]] = '.';
                    isWon = true;
                }
                else if (!isWon)
                {
                    isDead = MovePlayer(field, playerPosition, newPosition);

                    if (isDead)
                    {
                        isLost = true;
                    }

                    playerPosition[0] = newPosition[0];
                    playerPosition[1] = newPosition[1];
                }

                isDead = MoveBunnies(field);

                if (isDead)
                {
                    isLost = true;
                    break;
                }
            }

            if (isWon)
            {
                PrintField(field);
                Console.WriteLine($"won: {playerPosition[0]} {playerPosition[1]}");
            }
            else if (isLost)
            {
                PrintField(field);
                Console.WriteLine($"dead: {playerPosition[0]} {playerPosition[1]}");
            }
        }

        private static bool MoveBunnies(char[][] field)
        {
            for (int row = 0; row < field.Length; row++)
            {
                for (int col = 0; col < field[row].Length; col++)
                {
                    if (field[row][col] == 'B')
                    {
                        if (row > 0)
                        {
                            if (field[row - 1][col] != 'B')
                            {
                                field[row - 1][col] = 'S';
                            }

                        }
                        if (row < field.Length - 1)
                        {
                            if (field[row + 1][col] != 'B')
                            {
                                field[row + 1][col] = 'S';
                            }
                        }
                        if (col > 0)
                        {
                            if (field[row][col - 1] != 'B')
                            {
                                field[row][col - 1] = 'S';
                            }
                        }
                        if (col < field[row].Length - 1)
                        {
                            if (field[row][col + 1] != 'B')
                            {
                                field[row][col + 1] = 'S';
                            }
                        }
                    }
                }
            }

            var isDead = true;
            for (int row = 0; row < field.Length; row++)
            {
                for (int col = 0; col < field[row].Length; col++)
                {
                    if (field[row][col] == 'S')
                    {
                        field[row][col] = 'B';
                    }
                    if (field[row][col] == 'P' && isDead)
                    {
                        isDead = false;
                    }
                }
            }

            return isDead;
        }

        private static bool MovePlayer(char[][] field, int[] playerPosition, int[] newPosition)
        {
            var row = playerPosition[0];
            var col = playerPosition[1];
            var newRow = newPosition[0];
            var newCol = newPosition[1];
            bool isDead = false;
            if (field[newRow][newCol] != 'B')
            {
                field[row][col] = '.';
                field[newRow][newCol] = 'P';
            }
            else
            {
                isDead = true;
            }

            return isDead;
        }

        private static int[] PLayerPositions(char[][] field)
        {
            var playerPosition = new int[2];

            for (int row = 0; row < field.Length; row++)
            {
                for (int col = 0; col < field[row].Length; col++)
                {
                    if (field[row][col] == 'P')
                    {
                        playerPosition[0] = row;
                        playerPosition[1] = col;
                    }
                }
            }

            return playerPosition;
        }

        private static int[] ReturnNewPositions(char[][] field, char command, int[] playerPosition)
        {
            var newPlayerPosition = new int[2];
            var playerRow = playerPosition[0];
            var playerCol = playerPosition[1];
            if (command == 'U')
            {
                if (playerRow - 1 >= 0)
                {
                    newPlayerPosition[0] = playerRow - 1;
                    newPlayerPosition[1] = playerCol;
                }
                else
                {
                    newPlayerPosition[0] = -1;
                    newPlayerPosition[0] = playerCol;
                }
            }
            else if (command == 'D')
            {
                if (playerRow + 1 < field.Length)
                {
                    newPlayerPosition[0] = playerRow + 1;
                }
                else
                {
                    newPlayerPosition[0] = -1;
                }
                newPlayerPosition[1] = playerCol;
            }
            else if (command == 'L')
            {
                if (playerCol - 1 >= 0)
                {
                    newPlayerPosition[1] = playerCol - 1;
                }
                else
                {
                    newPlayerPosition[1] = -1;
                }

                newPlayerPosition[0] = playerRow;
            }
            else if (command == 'R')
            {
                if (playerCol + 1 < field[0].Length)
                {
                    newPlayerPosition[1] = playerCol + 1;
                }
                else
                {
                    newPlayerPosition[1] = -1;
                }
                newPlayerPosition[0] = playerRow;
            }

            return newPlayerPosition;
        }

        private static void PrintField(char[][] field)
        {
            foreach (var line in field)
            {
                Console.WriteLine(string.Join("", line));
            }
        }

        private static void GetField(char[][] field, int col)
        {
            for (int row = 0; row < field.Length; row++)
            {
                var inputLine = Console.ReadLine().ToCharArray();
                field[row] = inputLine;
            }
        }
    }
}
