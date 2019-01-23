namespace _7._Pascal_Triangle
{
    using System;

    public class PascalTriangle
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            var jaggedArray = new long[number][];

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                jaggedArray[i] = new long[i + 1];
                jaggedArray[i][0] = 1;
                jaggedArray[i][i] = 1;
            }

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                if (jaggedArray[i].Length > 2)
                {
                    for (int j = 1; j < jaggedArray[i].Length - 1; j++)
                    {
                        jaggedArray[i][j] = jaggedArray[i - 1][j - 1] + jaggedArray[i - 1][j];
                    }
                }
            }

            foreach (var array in jaggedArray)
            {
                Console.WriteLine(string.Join(" ", array));
            }
        }
    }
}
