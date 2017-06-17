using System;
using System.Text.RegularExpressions;


public class MatchPhoneNumber
{
    public static void Main()
    {
        string pattern = @"^\+359( |-)2\1[0-9]{3}\1[0-9]{4}\b";
        string inputLine = Console.ReadLine();
        while (inputLine != "end")
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

