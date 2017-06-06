using System;
using System.Collections.Generic;
using System.Linq;

public class UserLogs
{
    public static void Main()
    {
        SortedDictionary<string, Dictionary<string, int>> usersLog = new SortedDictionary<string, Dictionary<string, int>>();
        string inputLine = Console.ReadLine();
        while (inputLine != "end")
        {
            string[] tokens = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string ip = tokens[0].Replace("IP=", "");
            string username = tokens[2].Replace("user=", "");
            if (!usersLog.ContainsKey(username))
            {
                usersLog[username] = new Dictionary<string, int>() { { ip, 1 } };
            }
            else
            {
                if (!usersLog[username].ContainsKey(ip))
                {
                    usersLog[username][ip] = 1;
                }
                else
                {
                    usersLog[username][ip] += 1;
                }
            }
            inputLine = Console.ReadLine();
        }
        PrintUsersLog(usersLog);
    }

    private static void PrintUsersLog(SortedDictionary<string, Dictionary<string, int>> usersLog)
    {
        foreach (var user in usersLog)
        {
            Console.WriteLine($"{user.Key}:");
            Console.WriteLine("{0}.", string.Join(", ", user.Value.Select(x => $"{x.Key} => {x.Value}")));
        }
    }
}

