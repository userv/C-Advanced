using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Maximum_Element
{
    public class MaximumElement
    {
        public static void Main()
        {
            int numberQueries = int.Parse(Console.ReadLine());
            Stack<int> elementsStack = new Stack<int>();
            Stack<int> maxElements = new Stack<int>();
            int maxNumber = int.MinValue;
            for (int i = 0; i < numberQueries; i++)
            {
                int[] tokens = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int op = tokens[0];
                switch (op)
                {
                    case 1:
                        int element = tokens[1];
                        elementsStack.Push(element);
                        if (element > maxNumber)
                        {
                            maxNumber = element;
                            maxElements.Push(maxNumber);
                        }
                        break;
                    case 2:
                        if ((elementsStack.Peek() == maxNumber) && (maxElements.Count > 0))
                        {
                            maxElements.Pop();
                            if (maxElements.Count == 0)
                            {
                                maxNumber = Int32.MinValue;
                            }
                            else
                            {
                                maxNumber = maxElements.Peek();
                            }
                        }
                        elementsStack.Pop();
                        break;
                    case 3:
                        Console.WriteLine(maxNumber);
                        break;
                }
            }

        }
    }
}
