namespace _07._Speed_Racing
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var model = input[0];
                var fuelAmount = double.Parse(input[1]);
                var fuelConsumption = double.Parse(input[2]);

                var car = new Car(model,fuelAmount,fuelConsumption);
                cars.Add(car);
            }

            while (true)
            {
                var input = Console.ReadLine().Split();
                if (input[0]=="End")
                {
                    break;
                }

                var model = input[1];
                var distance = double.Parse(input[2]);
                var indexOfCurrentCar = cars.IndexOf(cars.Find(x => x.Model == model));
                cars[indexOfCurrentCar].Drive(distance);
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.Distance}");
            }
        }
    }
}
