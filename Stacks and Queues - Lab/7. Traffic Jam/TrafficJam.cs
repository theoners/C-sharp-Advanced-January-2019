namespace _7._Traffic_Jam
{
    using System;
    using System.Collections.Generic;

    public class TrafficJam
    {
        public static void Main()
        {
            var numberOfCars = int.Parse(Console.ReadLine());
            var totalCarsInTraffic = new Queue<string>();
            var carCounter = 0;

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                if (input == "green")
                {
                    for (int i = 0; i < numberOfCars; i++)
                    {
                        if (totalCarsInTraffic.Count != 0)
                        {
                            Console.WriteLine(totalCarsInTraffic.Dequeue() + " passed!");
                            carCounter++;
                        }

                    }
                }

                else
                {
                    totalCarsInTraffic.Enqueue(input);
                }
            }

            Console.WriteLine($"{carCounter} cars passed the crossroads.");
        }
    }
}
