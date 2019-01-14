namespace _10._Crossroads
{
    using System;
    using System.Collections.Generic;

    public class Crossroads
    {
        public static void Main()
        {
            int greenTime = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            var totalPassCars = 0;

            while (true)
            {
                var timeForPass = greenTime;
                var bonusTime = freeWindow;
                var input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                if (input != "green")
                {
                    cars.Enqueue(input);
                }
                else
                {
                    while (timeForPass > 0)
                    {
                        if (cars.Count != 0)
                        {
                            var car = cars.Dequeue();
                            var carLength = car.Length;
                            timeForPass -= carLength;
                            if (timeForPass < 0)
                            {
                                timeForPass += bonusTime;
                                if (timeForPass < 0)
                                {
                                    Console.WriteLine($"A crash happened!");
                                    Console.WriteLine($"{car} was hit at {car[carLength + timeForPass]}.");
                                    return;
                                }

                                timeForPass = 0;
                            }

                            totalPassCars++;
                        }
                        else
                        {
                            timeForPass = 0;
                        }
                    }
                }
            }

            Console.WriteLine($"Everyone is safe.");
            Console.WriteLine($"{totalPassCars} total cars passed the crossroads.");
        }
    }
}
