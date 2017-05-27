using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.BasicQueueOperations
{
    public class QueueOperations
    {
        public static void Main()
        {

            int[] inputLine = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] elementsArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numberElementsToAdd = inputLine[0];
            int numberElementsToRemove = inputLine[1];
            int element = inputLine[2];
            Queue<int> elementsQueue = new Queue<int>();
            for (int i = 0; i < numberElementsToAdd; i++)
            {
                elementsQueue.Enqueue(elementsArray[i]);
            }
            for (int i = 0; i < numberElementsToRemove; i++)
            {
                elementsQueue.Dequeue();
            }
            if (elementsQueue.Contains(element))
            {
                Console.WriteLine("true");
            }
            else if (elementsQueue.Count > 0)
            {
                Console.WriteLine(elementsQueue.Min());
            }
            else
            {
                Console.WriteLine(0);
            }

        }
    }
}
