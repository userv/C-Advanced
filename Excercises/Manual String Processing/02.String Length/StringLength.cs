using System;


public class StringLength
{
    private const int MaximumLengthOfString = 20;
    public static void Main()
    {
        string inputString = Console.ReadLine();
        string result = string.Empty;
        if (inputString.Length > 20)
        {
            result = inputString.Substring(0, MaximumLengthOfString);
        }
        else
        {
            result = inputString.PadRight(MaximumLengthOfString, '*');
        }
        Console.WriteLine(result);

    }
}

