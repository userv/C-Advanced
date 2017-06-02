using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    public class SetsOfElements
    {
        public static void Main()
        {
            int[] inputLine = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int lengthOfFirstSet = inputLine[0];
            int lengthOfSecondSet = inputLine[1];
            HashSet<int> firstHashSet = new HashSet<int>();
            HashSet<int> secondHashSet = new HashSet<int>();
            for (int i = 0; i < lengthOfFirstSet; i++)
            {
                firstHashSet.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < lengthOfSecondSet; i++)
            {
                secondHashSet.Add(int.Parse(Console.ReadLine()));
            }
            foreach (var number in firstHashSet)
            {
                if (secondHashSet.Contains(number))
                {
                    Console.Write(number + " ");
                }
            }
        }
    }
}
