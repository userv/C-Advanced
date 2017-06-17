using System;
using System.Collections.Generic;
using System.Linq;

public class FindEvensOrOdds
{
    public static void Main()
    {
        Predicate<int> isEven = n => n % 2 == 0;
        int[] borders = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        string command = Console.ReadLine();
        int[] numbers = Enumerable.Range(borders[0], borders[1] - borders[0] + 1).ToArray();
        PrintEvensOrOddsNumbers(numbers, command, isEven);
    }

    private static void PrintEvensOrOddsNumbers(int[] numbers, string command, Predicate<int> isEven)
    {
        List<int> result = new List<int>();
        foreach (var number in numbers)
        {
            if (isEven(number) && command == "even")
            {
                result.Add(number);
            }
            else if (!isEven(number) && command == "odd")
            {
                result.Add(number);
            }
        }
        Console.WriteLine(string.Join(" ", result));
    }
}

