using System;
using System.Collections.Generic;

namespace VegetableShopApp
{
    public class VegetableShop
    {
        private List<Vegetable> products = new List<Vegetable>();

        public void AddProduct(Vegetable product)
        {
            products.Add(product);
        }

        public void DisplayProducts()
        {
            Console.WriteLine("\n=== Список продуктів ===");
            decimal totalPrice = 0;
            foreach (var product in products)
            {
                Console.WriteLine(product.GetInfo());
                totalPrice += product.Price;
            }
            Console.WriteLine($"Загальна ціна всіх продуктів: {totalPrice:C}");
        }
    }
}
