using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.FixEmails
{
    public class FixEmails
    {
        public static void Main()
        {
            Dictionary<string, string> emails = new Dictionary<string, string>();
            string command = String.Empty;
            while (command.ToLower() != "stop")
            {
                string inputLine = Console.ReadLine().Trim();
                command = inputLine;
                if (command.ToLower() == "stop")
                {
                    continue;
                }
                string name = inputLine;
                string email = Console.ReadLine().Trim();
                string domain = email.Split('.').Last().ToString().ToLower();
                if (domain == "us" || domain == "us")
                {
                    continue;
                }
                if (!emails.ContainsKey(name))
                {
                    emails.Add(name, email);
                }
                else
                {
                    emails[name] = email;
                }
            }
            foreach (var kvp in emails)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
