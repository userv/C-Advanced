using System;
using System.Collections.Generic;

namespace _05.SequenceWithQueue
{
    public class SequenceWithQueue
    {
        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            Queue<long> elementsQueue = new Queue<long>();
            List<long> resultList = new List<long>();
            elementsQueue.Enqueue(n);
            resultList.Add(n);
            while (resultList.Count < 50)
            {
                long currentElement = elementsQueue.Dequeue();
                long firstElement = currentElement + 1;
                long secondElement = (currentElement * 2) + 1;
                long thirdElement = currentElement + 2;

                elementsQueue.Enqueue(firstElement);
                elementsQueue.Enqueue(secondElement);
                elementsQueue.Enqueue(thirdElement);

                resultList.Add(firstElement);
                resultList.Add(secondElement);
                resultList.Add(thirdElement);
            }
            for (int i = 0; i < 50; i++)
            {
                Console.Write(resultList[i] + " ");
            }
        }
    }
}
