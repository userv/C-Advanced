using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;



public class CharacterMultiplier
{
    public static void Main()
    {
        string[] inputLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Queue<char> firstString = new Queue<char>(inputLine[0]);
        Queue<char> secondString = new Queue<char>(inputLine[1]);
        int product = 0;
        int totalSum = 0;
        while (firstString.Count != 0 || secondString.Count != 0)
        {
            if (firstString.Count != 0 && secondString.Count != 0)
            {
                product = firstString.Dequeue() * secondString.Dequeue();
                totalSum += product;
            }
            else if (firstString.Count != 0 && secondString.Count == 0)
            {
                totalSum += firstString.Select(x => (int)x).Sum();
                break;
            }
            else if (firstString.Count == 0 && secondString.Count != 0)
            {
                totalSum += secondString.Select(x => (int)x).Sum();
                break;
            }
        }
        Console.WriteLine(totalSum);

    }
}

