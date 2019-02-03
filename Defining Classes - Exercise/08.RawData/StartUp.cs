namespace _08.RawData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var input = new Queue<string>(Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries));
                var model = input.Dequeue();
                var engineSpeed = int.Parse(input.Dequeue());
                var enginePower = int.Parse(input.Dequeue());
                var cargoWeight = int.Parse(input.Dequeue());
                var cargoType = input.Dequeue();

                var engine = new Engine(engineSpeed, enginePower);
                var cargo = new Cargo(cargoWeight, cargoType);
                var tires = new List<Tire>();
                while (input.Any())
                {
                    var tirePressure = double.Parse(input.Dequeue());
                    var tireYear = int.Parse(input.Dequeue());
                    var tire = new Tire(tirePressure, tireYear);
                    tires.Add(tire);
                }

                var car = new Car(model, engine, cargo, tires);
                cars.Add(car);
            }

            var command = Console.ReadLine();

            if (command == "fragile")
            {
                foreach (var car in cars.Where(x => x.Cargo.CargoType == command && x.Tire.Any(y => y.Pressure < 1)))
                {
                    Console.WriteLine($"{car.Model}");
                }
            }
            else
            {
                foreach (var car in cars.Where(x => x.Cargo.CargoType == command && x.Engine.EnginePower > 250))
                {
                    Console.WriteLine($"{car.Model}");
                }
            }
        }
    }
}
