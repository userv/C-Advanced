using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


public class SrabskoUnleashed
{
    public static void Main()
    {
        Dictionary<string, Dictionary<string, int>> venues = new Dictionary<string, Dictionary<string, int>>();
        string pattern = @"(?<singer>\w.+)\s@(?<venue>\w.+)\s(?<price>\d+)\s(?<count>\d+)";
        string inputLine = Console.ReadLine();
        while (inputLine.ToLower() != "end")
        {
            Match match = Regex.Match(inputLine, pattern);
            if (match.Success)
            {
                string singer = match.Groups["singer"].Value;
                string venue = match.Groups["venue"].Value;
                int price = int.Parse(match.Groups["price"].Value);
                int count = int.Parse(match.Groups["count"].Value);
                int totalMoney = price * count;
                if (!venues.ContainsKey(venue))
                {
                    venues[venue] = new Dictionary<string, int>() { { singer, totalMoney } };
                }
                else
                {
                    if (!venues[venue].ContainsKey(singer))
                    {
                        venues[venue][singer] = totalMoney;
                    }
                    else
                    {
                        venues[venue][singer] += totalMoney;
                    }
                }
            }
            inputLine = Console.ReadLine();
        }
        foreach (var venue in venues)
        {
            Console.WriteLine($"{venue.Key}");
            foreach (var singer in venue.Value.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
            }
        }
    }
}

