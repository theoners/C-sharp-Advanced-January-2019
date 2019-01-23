namespace _03._Product_Shop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Shop
    {
        public static void Main()
        {

            var shopAndProducts = new Dictionary<string, Dictionary<string, double>>();

            while (true)
            {
                var input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "Revision")
                {
                    break;
                }

                var shopName = input[0];
                var product = input[1];
                var price = double.Parse(input[2]);

                if (!shopAndProducts.ContainsKey(shopName))
                {
                    shopAndProducts.Add(shopName, new Dictionary<string, double>());
                }
                shopAndProducts[shopName].Add(product, price);
            }

            foreach (var shop in shopAndProducts.OrderBy(x => x.Key))
            {
                Console.WriteLine(shop.Key + "->");
                foreach (var products in shop.Value)
                {
                    Console.WriteLine($"Product: {products.Key}, Price: {products.Value}");
                }
            }
        }
    }
}