using System;

public class UnicodeCharacters
{
    public static void Main()
    {
        string inputLine = Console.ReadLine();
        foreach (var ch in inputLine)
        {
            Console.Write($"\\u{(int)ch:x4}");
        }
    }
}

