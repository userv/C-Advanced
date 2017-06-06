using System;
using System.Collections.Generic;
using System.Linq;

public class LogsAggregator
{
    public static void Main()
    {
        SortedDictionary<string, SortedDictionary<string, int>> logs = new SortedDictionary<string, SortedDictionary<string, int>>();
        int numberOfLines = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfLines; i++)
        {
            string[] tokens = Console.ReadLine().Split(' ');
            string ip = tokens[0];
            string username = tokens[1];
            int duration = int.Parse(tokens[2]);
            if (!logs.ContainsKey(username))
            {
                logs[username] = new SortedDictionary<string, int>() { { ip, duration } };
            }
            else
            {
                if (!logs[username].ContainsKey(ip))
                {
                    logs[username][ip] = duration;
                }
                else
                {
                    logs[username][ip] += duration;
                }
            }
        }
        foreach (var user in logs)
        {
            int totalDuration = user.Value.Values.Sum();
            Console.WriteLine($"{user.Key}: {totalDuration} [{string.Join(", ", user.Value.Keys)}]");
        }

    }
}

