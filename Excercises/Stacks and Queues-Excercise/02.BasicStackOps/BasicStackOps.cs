using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicStackOps
{
    public class BasicStackOps
    {
        public static void Main()
        {
            int[] inputLine = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> elementsStack = new Stack<int>();
            int elementsToPush = inputLine[0];
            int elementsToPop = inputLine[1];
            int elementX = inputLine[2];
            for (int i = 0; i < elementsToPush; i++)
            {
                elementsStack.Push(numbers[i]);
            }
            for (int i = 0; i < elementsToPop; i++)
            {
                elementsStack.Pop();
            }
            if (elementsStack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (elementsStack.Contains(elementX))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(elementsStack.Min());
            }

        }
    }
}
