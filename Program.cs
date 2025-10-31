using System;

namespace FactorialApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for factorial:");
            if (int.TryParse(Console.ReadLine(), out int num) && num >= 0)
            {
                long result = CalculateFactorial(num);
                Console.WriteLine($"Factorial of {num} is {result}");
            }
            else
            {
                Console.WriteLine("Invalid input. Enter a non-negative integer.");
            }
        }

        static long CalculateFactorial(int n)
        {
            if (n == 0 || n == 1) return 1;
            long fact = 1;
            for (int i = 2; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }
    }
}