using System;

namespace Exercise02_EcommerceSearchFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] products =
            {
                new Product(101, "Laptop", "Electronics"),
                new Product(102, "Mobile", "Electronics"),
                new Product(103, "Shoes", "Fashion"),
                new Product(104, "Watch", "Accessories"),
                new Product(105, "Book", "Education")
            };

            Console.WriteLine("===== LINEAR SEARCH =====");

            Product linearResult = SearchOperations.LinearSearch(products, 104);

            if (linearResult != null)
            {
                Console.WriteLine($"Product Found:");
                Console.WriteLine($"ID: {linearResult.ProductId}");
                Console.WriteLine($"Name: {linearResult.ProductName}");
                Console.WriteLine($"Category: {linearResult.Category}");
            }
            else
            {
                Console.WriteLine("Product Not Found");
            }

            Console.WriteLine();

            Console.WriteLine("===== BINARY SEARCH =====");

            Product binaryResult = SearchOperations.BinarySearch(products, 104);

            if (binaryResult != null)
            {
                Console.WriteLine($"Product Found:");
                Console.WriteLine($"ID: {binaryResult.ProductId}");
                Console.WriteLine($"Name: {binaryResult.ProductName}");
                Console.WriteLine($"Category: {binaryResult.Category}");
            }
            else
            {
                Console.WriteLine("Product Not Found");
            }

            Console.WriteLine();

            Console.WriteLine("========== ANALYSIS ==========");

            Console.WriteLine("Linear Search:");
            Console.WriteLine("Best Case    : O(1)");
            Console.WriteLine("Average Case : O(n)");
            Console.WriteLine("Worst Case   : O(n)");

            Console.WriteLine();

            Console.WriteLine("Binary Search:");
            Console.WriteLine("Best Case    : O(1)");
            Console.WriteLine("Average Case : O(log n)");
            Console.WriteLine("Worst Case   : O(log n)");

            Console.WriteLine();
            Console.WriteLine("Binary Search is faster for large sorted datasets.");
            Console.WriteLine("Linear Search is suitable for small or unsorted datasets.");

            Console.ReadKey();
        }
    }
}