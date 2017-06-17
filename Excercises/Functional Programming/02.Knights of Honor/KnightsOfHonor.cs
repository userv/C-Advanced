using System;

public class KnightsOfHonor
{
    public static void Main()
    {
        Action<string> print = s => Console.WriteLine("Sir " + s);
        var input = Console.ReadLine().Split(' ');
        PrintAllNames(input, print);
    }

    private static void PrintAllNames(string[] input, Action<string> print)
    {
        foreach (var name in input)
            print(name);
    }
}