namespace _06._Auto_Repair_and_Service
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AutoService
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var carList = new Queue<string>(input);
            var servedCars = new Stack<string>();

            while (true)
            {
                var command = Console.ReadLine();
                if (command=="End")
                {
                    break;
                }

                if (command=="Service" && carList.Any())
                {
                    var currentCar= carList.Dequeue();
                    servedCars.Push(currentCar);
                    Console.WriteLine($"Vehicle {currentCar} got served.");
                }
                else if (command=="History")
                {
                    Console.WriteLine($"{string.Join(", ", servedCars)}");
                }
                else if (command!="Service")
              
              
                {
                    var carInfo = command.Split("-")[1];
                    if (carList.Contains(carInfo))
                    {
                        Console.WriteLine($"Still waiting for service.");
                    }
                    else
                    {
                        Console.WriteLine("Served.");
                    }
                }
            }

            if (carList.Any())
            {
                Console.WriteLine($"Vehicles for service: {string.Join(", ", carList)}");
            }

            if (servedCars.Any())
            {
                Console.WriteLine($"Served vehicles: {string.Join(", ", servedCars)}");
            }
        }
    }
}
