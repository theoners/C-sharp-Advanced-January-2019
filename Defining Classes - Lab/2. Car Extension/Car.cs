namespace CarManufacturer
{
    using System;
    using System.Text;

    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;

        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; set; }

        public void Drive(double distance)
        {
            if (distance*FuelConsumption/100>FuelQuantity)
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
            else
            {
                FuelQuantity -= FuelConsumption/100 * distance;
            }
        }

        public string WhoAmI()
        {
            var carInfo = new StringBuilder();

            carInfo.AppendLine($"Make: {this.Make}");

            carInfo.AppendLine($"Model: {this.Model}");

            carInfo.AppendLine($"Year: {this.Year}");

            carInfo.Append($"Fuel: {this.FuelQuantity:F2}L");

            return carInfo.ToString();
        }
    }
}
