namespace _09._Rectangle_Intersection
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var n = int.Parse(input[0]);
            var m = int.Parse(input[1]);
            var rectangles = new List<Rectangle>();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var id = line[0];
                var width = double.Parse(line[1]);
                var height = double.Parse(line[2]);
                var topLeftX = double.Parse(line[3]);
                var topLeftY = double.Parse(line[4]);
                var points = new Point(topLeftX,topLeftY,width,height);
                var rectangle = new Rectangle(id,points);
                rectangles.Add(rectangle);
            }

            for (int i = 0; i < m; i++)
            {
                var line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var firstRectangleId = line[0];
                var secondRectangleId = line[1];
                var firstRectangleIndex = rectangles.FindIndex(x => x.Id == firstRectangleId);
                var secondRectangleIndex = rectangles.FindIndex(x => x.Id == secondRectangleId);
                Console.WriteLine(rectangles[firstRectangleIndex].IntersectRectangles(rectangles[secondRectangleIndex])
                    ? "true"
                    : "false");
            }

        }
    }
}
