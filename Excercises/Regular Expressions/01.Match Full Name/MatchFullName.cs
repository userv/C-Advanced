using System;
using System.Text.RegularExpressions;



public class MatchFullName
{
    public static void Main()
    {
        string pattern = @"\b([A-Z][a-z]{2,} [A-Z][a-z]{2,})\b";
        string inputLine = Console.ReadLine();
        while (inputLine!="end")
        {
            Match match = Regex.Match(inputLine, pattern);
            if (match.Success)
            {
                Console.WriteLine(match);
            }
            inputLine = Console.ReadLine();
        }
    }
}
