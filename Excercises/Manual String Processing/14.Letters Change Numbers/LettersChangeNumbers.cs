using System;


public class LettersChangeNumbers
{
    public static void Main()
    {
        string[] inputLine = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        double totalSum = 0;
        foreach (var str in inputLine)
        {
            double result = CalculateString(str);
            totalSum += result;
        }
        Console.WriteLine($"{totalSum:f2}");
    }

    private static double CalculateString(string str)
    {
        double result = 0;
        char firstLetter = str[0];
        char lastLetter = str[str.Length - 1];
        int number = int.Parse(str.Substring(1, str.Length - 2));
        int positionOfFirstLetter = char.ToUpper(firstLetter) - 'A' + 1;
        int positionOfLastLetter = char.ToUpper(lastLetter) - 'A' + 1;
        if (char.IsUpper(firstLetter))
        {
            result = (double)number / positionOfFirstLetter;
        }
        else
        {
            result = (double) number * positionOfFirstLetter;
        }
        if (char.IsUpper(lastLetter))
        {
            result -= positionOfLastLetter;
        }
        else
        {
            result += positionOfLastLetter;
        }
        return result;
    }
}

