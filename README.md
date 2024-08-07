using System;

namespace RetailCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize total retail value
            double totalRetailValue = 0;

            // Sentinel-controlled loop
            while (true)
            {
                try
                {
                    // Read product number and quantity sold
                    Console.Write("Enter product number (1, 2, or 3) or -1 to exit: ");
                    int productNumber = Convert.ToInt32(Console.ReadLine());

                    if (productNumber == -1)
                        break;

                    Console.Write("Enter quantity sold: ");
                    int quantitySold = Convert.ToInt32(Console.ReadLine());

                    // Calculate retail price based on product number
                    double retailPrice;
                    switch (productNumber)
                    {
                        case 1:
                            retailPrice = 2.98;
                            break;
                        case 2:
                            retailPrice = 4.50;
                            break;
                        case 3:
                            retailPrice = 9.98;
                            break;
                        default:
                            Console.WriteLine("Invalid product number. Please enter 1, 2, or 3.");
                            continue;
                    }

                    // Calculate total retail value for this product
                    double productTotal = retailPrice * quantitySold;

                    totalRetailValue += productTotal;

                    Console.WriteLine($"Total Product Sold  = ${productTotal:F2} \n");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter valid numbers. \n");
                }
            }

            // Display final results
            Console.WriteLine($"Total retail value of all products sold: ${totalRetailValue:F2} \n");
        }
    }
}
