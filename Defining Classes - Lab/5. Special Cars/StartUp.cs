namespace _5._Special_Cars
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        private Engine engine;
        private Tire[] tires;

        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; set; }

        public Engine Engine { get; set; }

        public Tire[] Tires { get; set; }

        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;
        }
        public Car(string make, string model, int year) : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine,
            Tire[] tires) : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.Engine = engine;
            this.Tires = tires;
        }

        public void Drive(double distance)
        {
            if (distance * FuelConsumption / 100 > FuelQuantity)
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
            else
            {
                FuelQuantity -= FuelConsumption / 100 * distance;
            }
        }
    }

    public class Tire
    {
        private int year;
        private double pressure;

        public int Year { get; set; }
        public double Pressure { get; set; }

        public Tire(int year, double pressure)
        {
            this.Year = year;
            this.Pressure = pressure;
        }
    }

    public class Engine
    {
        private int horsePower;
        private double cubicCapacity;

        public int HorsePower { get; set; }

        public double CubicCapacity { get; set; }

        public Engine(int horsePower, double cubicCapacity)
        {
            this.HorsePower = horsePower;
            this.CubicCapacity = cubicCapacity;
        }
    }

    public class StartUp
    {
        const double distance = 20.0;

        public static void Main()
        {
            var allTires = new List<Tire[]>();
            var allEngines = new List<Engine>();
            var allCars = new List<Car>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "No more tires")
                {
                    break;
                }

                var tires = input.Split(" ");
                var fourTires = new Tire[4]
                {
                        new Tire(int.Parse(tires[0]),double.Parse(tires[1])),
                        new Tire(int.Parse(tires[2]),double.Parse(tires[3])),
                        new Tire(int.Parse(tires[4]),double.Parse(tires[5])),
                        new Tire(int.Parse(tires[6]),double.Parse(tires[7])),
                };
                allTires.Add(fourTires);
            }

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "Engines done")
                {
                    break;
                }

                var engines = input.Split(" ");
                for (int i = 0; i < engines.Length - 1; i++)
                {
                    var engineHorsePower = int.Parse(engines[i]);
                    var engineCubicCapacity = double.Parse(engines[i + 1]);
                    var engine = new Engine(engineHorsePower, engineCubicCapacity);
                    allEngines.Add(engine);
                }
            }

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Show special")
                {
                    break;
                }

                var carInfo = input.Split();
                var make = carInfo[0];
                var model = carInfo[1];
                var year = int.Parse(carInfo[2]);
                var fuelQuantity = double.Parse(carInfo[3]);
                var fuelConsumption = double.Parse(carInfo[4]);
                var engineIndex = int.Parse(carInfo[5]);
                var tireIndex = int.Parse(carInfo[6]);
                var car = new Car(make, model, year, fuelQuantity, fuelConsumption, allEngines[engineIndex], allTires[tireIndex]);
                var isSpecialCar = IsSpecialCar(car);
                if (isSpecialCar)
                {
                    car.Drive(distance);
                }

                if (car.FuelQuantity!=fuelQuantity)
                {
                    allCars.Add(car);
                }
            }

            foreach (var specialCar in allCars)
            {
                Console.WriteLine($"Make: {specialCar.Make}");
                Console.WriteLine($"Model: {specialCar.Model}");
                Console.WriteLine($"Year: {specialCar.Year}");
                Console.WriteLine($"HorsePowers: {specialCar.Engine.HorsePower}");
                Console.WriteLine($"FuelQuantity: {specialCar.FuelQuantity}");
            }
        }

        private static bool IsSpecialCar(Car car)
        {
            return car.Year >= 2017 && car.Engine.HorsePower >= 330 && car.Tires.Select(x => x.Pressure).Sum() >= 9 &&
                   car.Tires.Select(x => x.Pressure).Sum() <= 10;
        }
    }
}
