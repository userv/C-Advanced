using System;
using System.Text.RegularExpressions;


public class MelrahShake
{
    public static void Main()
    {
        string inputString = Console.ReadLine();
        string pattern = Console.ReadLine();
        Regex regex = new Regex(Regex.Escape(pattern));
        MatchCollection matches = regex.Matches(inputString);
        while (true)
        {
            if (matches.Count >= 2 && pattern.Length > 0)
            {
                int startIndex = inputString.IndexOf(pattern);
                inputString = inputString.Remove(startIndex, pattern.Length);
                int lastIndex = inputString.LastIndexOf(pattern);
                inputString = inputString.Remove(lastIndex, pattern.Length);
                pattern = pattern.Remove(pattern.Length / 2, 1);
                Console.WriteLine("Shaked it.");
            }
            else
            {
                Console.WriteLine("No shake.");
                break;
            }
            if (pattern.Length > 0)
            {
                regex = new Regex(Regex.Escape(pattern));
                matches = regex.Matches(inputString);
            }

        }
        Console.WriteLine(inputString);
    }
}


