using System;
using System.Text;
using System.Text.RegularExpressions;


public class ReplaceATag
{
    public static void Main()
    {
        // string pattern = @"<a\s+href=(\""|)(.+?)\1>(.+?)(<\/a>)";
        string pattern = @"<a\s+(href=.+?)>(.+?)(<\/a>)";
        string inputLine = Console.ReadLine();
        StringBuilder sb = new StringBuilder();
        while (inputLine != "end")
        {
            sb.AppendLine(inputLine);
            inputLine = Console.ReadLine();
        }

        string replased = Regex.Replace(sb.ToString(), pattern,w => $"[URL {w.Groups[1].Value}]{w.Groups[2].Value}[/URL]");
        Console.WriteLine(replased);
    }
}

