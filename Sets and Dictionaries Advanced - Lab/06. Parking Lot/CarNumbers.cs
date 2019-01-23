namespace _06._Parking_Lot
{
    using System;
    using System.Collections.Generic;

    public class CarNumbers
    {
        public static void Main()
        {
            var carNumbers = new HashSet<string>();

            while (true)
            {
                var input = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "END")
                {
                    break;
                }

                if (input[0] == "IN")
                {
                    carNumbers.Add(input[1]);
                }
                else
                {
                    carNumbers.Remove(input[1]);
                }
            }

            if (carNumbers.Count == 0)
            {
                Console.WriteLine($"Parking Lot is Empty");
            }
            else
            {
                foreach (var number in carNumbers)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}