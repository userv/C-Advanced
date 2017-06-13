using System;
using System.Collections.Generic;


public class MagicWords
{
    public static void Main()
    {
        string[] inputLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string firstWord = inputLine[0];
        string secondWord = inputLine[1];
        Console.WriteLine(AreExchangeable(firstWord, secondWord).ToString().ToLower());
    }

    private static bool AreExchangeable(string firstWord, string secondWord)
    {

        int length = Math.Max(firstWord.Length, secondWord.Length);
        Dictionary<char, char> letters = new Dictionary<char, char>();
        for (int i = 0; i < length; i++)
        {
            if (firstWord.Length > i && secondWord.Length > i)
            {
                if (!letters.ContainsKey(firstWord[i]))
                {
                    letters.Add(firstWord[i], secondWord[i]);
                }
                else if (!letters.ContainsValue(secondWord[i]))
                {
                    return false;
                }
            }
            if (firstWord.Length < i && secondWord.Length > i)
            {
                if (!letters.ContainsValue(secondWord[i]))
                {
                    return false;
                }
            }
            if (firstWord.Length > i && secondWord.Length < i)
            {
                if (!letters.ContainsValue(firstWord[i]))
                {
                    return false;
                }
            }
        }
        return true;
    }
}

