using System;
using System.Text;

namespace VegetableShopApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            VegetableShop shop = new VegetableShop();

            bool running = true;
            while (running)
            {
                Console.WriteLine("\nОберіть овоч для додавання:");
                Console.WriteLine("1. Морква");
                Console.WriteLine("2. Помідор");
                Console.WriteLine("3. Картопля (кг)");
                Console.WriteLine("4. Огірок (кг)");
                Console.WriteLine("5. Завершити та показати кошик");
                Console.Write("Ваш вибір: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        shop.AddProduct(new Carrot(5));
                        break;
                    case "2":
                        shop.AddProduct(new Tomato(6));
                        break;
                    case "3":
                        Console.Write("Введіть кількість кг картоплі: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal potatoKg))
                        {
                            shop.AddProduct(new Potato(3, potatoKg));
                        }
                        else Console.WriteLine("Невірне значення.");
                        break;
                    case "4":
                        Console.Write("Введіть кількість кг огірків: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal cucumberKg))
                        {
                            shop.AddProduct(new Cucumber(4, cucumberKg));
                        }
                        else Console.WriteLine("Невірне значення.");
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Невірний вибір.");
                        break;
                }
            }

            shop.DisplayProducts();
        }
    }
}
