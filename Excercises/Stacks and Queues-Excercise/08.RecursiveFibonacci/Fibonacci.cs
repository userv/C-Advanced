using System;

namespace _08.RecursiveFibonacci
{
    public class Fibonacci
    {
        public static long[] fibonacciNumbers;
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            fibonacciNumbers = new long[number];
            var fib = GetFibonacci(number);
            Console.WriteLine(fib);

        }
        public static long GetFibonacci(int n)
        {
            if (n <= 2)
            {
                return 1;
            }
            if (fibonacciNumbers[n - 1] != 0)
            {
                return fibonacciNumbers[n - 1];
            }
            return fibonacciNumbers[n - 1] = GetFibonacci(n - 1) + GetFibonacci(n - 2);
        }
    }
}
