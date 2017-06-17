using System;
using System.Linq;

public class CustomMinFunction
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var minNumber = int.MaxValue;
        Func<int, int, int> min = (x, y) =>
        {
            if (x < y)
                return x;
            if (x > y)
                return y;
            return x;
        };

        foreach (var num in numbers)
        {
            minNumber = min(minNumber, num);
        }
        Console.WriteLine(minNumber);
    }
}