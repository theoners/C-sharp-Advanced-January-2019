namespace _6._Jagged_Array_Modification
{
    using System;
    using System.Linq;

    public class JaggedArray
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            var jaggedArray = new int[size][];

            for (int i = 0; i < size; i++)
            {
                var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jaggedArray[i] = numbers;
            }

            while (true)
            {
                var input = Console.ReadLine().Split();
                if (input[0] == "END")
                {
                    break;
                }

                var command = input[0];
                var row = int.Parse(input[1]);
                var col = int.Parse(input[2]);
                var value = int.Parse(input[3]);

                if (command == "Add")
                {
                    if (row < size && row >= 0)
                    {
                        if (jaggedArray[row].Length > col && col >= 0)
                        {
                            jaggedArray[row][col] += value;
                        }
                        else
                        {
                            Console.WriteLine("Invalid coordinates");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
                else if (command == "Subtract")
                {
                    if (row < size && row >= 0)
                    {
                        if (jaggedArray[row].Length > col && col >= 0)
                        {
                            jaggedArray[row][col] -= value;
                        }
                        else
                        {
                            Console.WriteLine("Invalid coordinates");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
            }

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}