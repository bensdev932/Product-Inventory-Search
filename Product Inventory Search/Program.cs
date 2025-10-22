using System;
using System.Globalization;

namespace MovieRentalSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
           
            string[] products = { "Laptop", "Mouse", "Keyboard", "Monitor" };
            decimal[] price = { 999.99m, 25.50m, 75.00m, 299.99m };
            int[] quantities = { 5, 0, 2, 8 };

            Console.Write("Search Product: ");
            string searchProduct = Console.ReadLine();

            int i = 0;
            bool found = false;

            while (i < products.Length)
            {
                if (string.Equals(products[i], searchProduct, StringComparison.OrdinalIgnoreCase))
                {
                    if (quantities[i] > 0 && quantities[i] <= 3 )
                    {
                        Console.WriteLine($"Stock: ({quantities[i]} left)");
                    }

                    else if (quantities[i] == 0)
                    {
                        Console.WriteLine("Stock: Out of Stock");
                    }
                    else
                    {
                        Console.WriteLine($"Stock Available \"{quantities[i]}\"");
                    }
                    found = true;
                    break;
                }
                i++;
            }
          






        }

    }
}