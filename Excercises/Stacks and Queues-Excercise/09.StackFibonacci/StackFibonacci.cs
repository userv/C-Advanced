using System;
using System.Collections.Generic;

namespace _09.StackFibonacci
{
    public class StackFibonacci
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Stack<long> fibonacciStack=new Stack<long>();
            fibonacciStack.Push(0);
            fibonacciStack.Push(1);
            for (int i = 1; i < n; i++)
            {
                long n1 = fibonacciStack.Pop();
                long n2 = fibonacciStack.Peek();
                fibonacciStack.Push(n1);
                fibonacciStack.Push(n1+n2);
            }
            Console.WriteLine(fibonacciStack.Pop());
        }
    }
}
