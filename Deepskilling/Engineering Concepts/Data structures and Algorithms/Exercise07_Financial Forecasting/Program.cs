using System;

namespace Exercise07_FinancialForecasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double currentValue = 10000;
            double growthRate = 0.10;   // 10%
            int years = 5;

            double futureValue = FinancialForecast.PredictFutureValue(currentValue, growthRate, years);

            Console.WriteLine("===== Financial Forecasting =====");
            Console.WriteLine($"Current Value : {currentValue:C}");
            Console.WriteLine($"Growth Rate   : {growthRate * 100}%");
            Console.WriteLine($"Years         : {years}");
            Console.WriteLine($"Future Value  : {futureValue:C}");

            Console.WriteLine();
            Console.WriteLine("Analysis");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Time Complexity : O(n)");
            Console.WriteLine("Space Complexity: O(n)");
            Console.WriteLine();
            Console.WriteLine("Optimization:");
            Console.WriteLine("- Recursion uses the call stack.");
            Console.WriteLine("- For large values of years, an iterative solution is more memory-efficient.");
            Console.WriteLine("- Memoization is useful when the recursive function solves overlapping subproblems.");

            Console.ReadKey();
        }
    }
}