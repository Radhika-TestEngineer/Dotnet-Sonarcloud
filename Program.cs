using System;

namespace FactorialApp
{
    internal class Program
    {
        // Make the method public so tests can call it
        public static long CalculateFactorial(int n)
        {
            if (n == 0 || n == 1) return 1;
            long fact = 1;
            for (int i = 2; i <= n; i++) fact *= i;
            return fact;
        }

        // Only ONE entry point
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            if (int.TryParse(Console.ReadLine(), out int num) && num >= 0)
                Console.WriteLine($"Factorial = {CalculateFactorial(num)}");
            else
                Console.WriteLine("Invalid input.");
        }
    }
}