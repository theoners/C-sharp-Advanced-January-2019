namespace _9._Miner
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Miner
    {
        public static void Main()
        {
            var n = long.Parse(Console.ReadLine());
            var command = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var coalIndex = new List<long[]>();
            var playerIndex = new long[2];
            var endIndex = new long[2];
            var row = 0;
            while (row != n)
            {
                var input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == 'c')
                    {
                        var index = new long[] { row, i };
                        coalIndex.Add(index);
                    }
                    else if (input[i] == 'e')
                    {
                        endIndex = new long[] { row, i };
                    }
                    else if (input[i] == 's')
                    {
                        playerIndex = new long[] { row, i };
                    }
                }

                row++;
            }

            for (int i = 0; i < command.Length; i++)
            {
                var cmd = command[i];
                if (cmd == "up")
                {
                    if (IsValidIndex(playerIndex[0] - 1, playerIndex[1], n))
                    {
                        playerIndex[0] -= 1;
                    }
                }
                else if (cmd == "right")
                {
                    if (IsValidIndex(playerIndex[0], playerIndex[1] + 1, n))
                    {
                        playerIndex[1] += 1;
                    }
                }
                else if (cmd == "down")
                {
                    if (IsValidIndex(playerIndex[0] + 1, playerIndex[1], n))
                    {
                        playerIndex[0] += 1;
                    }
                }
                else if (cmd == "left")
                {
                    if (IsValidIndex(playerIndex[0], playerIndex[1] - 1, n))
                    {
                        playerIndex[1] -= 1;
                    }
                }

                if (coalIndex.Exists(x => x.SequenceEqual(playerIndex)))
                {
                    for (int j = 0; j < coalIndex.Count; j++)
                    {
                        if (coalIndex[j].SequenceEqual(playerIndex))
                        {
                            coalIndex.RemoveAt(j);
                            j = coalIndex.Count;
                        }
                    }
                    if (coalIndex.Count == 0)
                    {
                        Console.WriteLine($"You collected all coals! ({playerIndex[0]}, {playerIndex[1]})");

                        return;
                    }
                }
                else if (endIndex.SequenceEqual(playerIndex))
                {
                    Console.WriteLine($"Game over! ({playerIndex[0]}, {playerIndex[1]})");
                    return;
                }
            }

            Console.WriteLine($"{coalIndex.Count} coals left. ({playerIndex[0]}, {playerIndex[1]})");
        }

        private static bool IsValidIndex(long row, long col, long size)
        {
            return row >= 0 && row < size && col >= 0 && col < size;
        }
    }
}
