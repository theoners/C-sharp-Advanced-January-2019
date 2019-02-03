namespace _10.CarSalesman
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var engineCount = int.Parse(Console.ReadLine());
            var engines = new List<Engine>();

            for (int i = 0; i < engineCount; i++)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var engineModel = input[0];
                var enginePower = int.Parse(input[1]);
                var displacement = input.Length > 2 ? !char.IsLetter(input[2][0]) ? input[2] : "n/a" : "n/a";
                displacement = input.Length > 3 ? !char.IsLetter(input[3][0]) ? input[3] : displacement : displacement;
                var efficiency = input.Length > 2 ? char.IsLetter(input[2][0]) ? input[2] : "n/a" : "n/a";
                efficiency = input.Length > 3 ? char.IsLetter(input[3][0]) ? input[3] : efficiency : efficiency;
                var engine = new Engine(engineModel,enginePower,displacement,efficiency);
                engines.Add(engine);
            }

            var carCount = int.Parse(Console.ReadLine());
            var cars = new List<Car>();
            for (int i = 0; i < carCount; i++)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var carModel = input[0];
                var engineModel = input[1];
                var weight = input.Length > 2 ? !char.IsLetter(input[2][0]) ? input[2] : "n/a" : "n/a";
                weight = input.Length > 3 ? !char.IsLetter(input[3][0]) ? input[3] : weight : weight;
                var color = input.Length > 2 ? char.IsLetter(input[2][0]) ? input[2] : "n/a" : "n/a";
                color = input.Length > 3 ? char.IsLetter(input[3][0]) ? input[3] : color : color;
                var engine = engines.FirstOrDefault(x => x.Model == engineModel);
                var car = new Car(carModel,engine,weight,color);
                cars.Add(car);
            }

            foreach (var car in cars)
            {
                car.PrintCar();
            }
        }
    }
}
