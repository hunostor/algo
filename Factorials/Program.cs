using System;

namespace Factorials
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter the nth value as integer: ");
            var n = Convert.ToInt32(Console.ReadLine());

            // loop calculation
            System.Console.WriteLine($"LOOP calculation: Factorial of {n} is {CalculateLoop(n)}");
            System.Console.WriteLine($"LOOP2 calculation: Factorial of {n} is {CalculateLoop2(n)}");
            System.Console.WriteLine($"Recursion calculation: Factorial of {n} is {CalculateRecursion(n)}");

            Console.ReadLine();
        }

        private static int CalculateLoop(int n)
        {
            var factorial = 1;
            for(int i = n; i >= 1; i--)
            {
                factorial *= i;
            }

            return factorial;
        }

        private static int CalculateLoop2(int n)
        {
            var factorial = n;
            for (int i = 1; i < n; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        private static int CalculateRecursion(int n)
        {
            if (n == 1)
                return 1;

            return n * CalculateRecursion(n - 1);
        }
    }
}
