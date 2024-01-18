using System;
using System.Collections.Generic;

namespace LinqProducts
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                List<Products> products = new List<Products>
                {
                    new Products { ProductId = 1, ProductName = "Iphone", ProductDescription = "Apple Product", UnitInStock = 5 },
                    new Products { ProductId = 2, ProductName = "Samsung", ProductDescription = "Samsung Product", UnitInStock = 0 },
                    new Products { ProductId = 3, ProductName = "Oneplus", ProductDescription = "Oneplus Product", UnitInStock = 10 },
                    new Products { ProductId = 4, ProductName = "Mac", ProductDescription = "Apple Product", UnitInStock = 0 },
                    new Products { ProductId = 5, ProductName = "Ipad", ProductDescription = "Apple Product", UnitInStock = 8 },
                    new Products { ProductId = 6, ProductName = "Desk", ProductDescription = "Furniture", UnitInStock = 10 },
                };

                Console.WriteLine("Enter 1 to display all products, 2 for sold-out products, or 'exit' to end:");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        DisplayAllProducts(products);
                        break;

                    case "2":
                        DisplaySoldOutProducts(products);
                        break;

                    case "exit":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }

        public static void DisplayAllProducts(List<Products> productList)
        {
            Console.WriteLine("All products:");
            foreach (var product in productList)
            {
                Console.WriteLine(product);
            }
        }

        public static void DisplaySoldOutProducts(List<Products> productList)
        {
            var soldOutProducts = from p in productList
                                  where p.UnitInStock == 0
                                  select p;

            Console.WriteLine("Sold out products:");
            foreach (var product in soldOutProducts)
            {
                Console.WriteLine(product);
            }
        }
    }
}
