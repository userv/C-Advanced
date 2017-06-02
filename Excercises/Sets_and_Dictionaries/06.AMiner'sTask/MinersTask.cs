using System;
using System.Collections.Generic;

namespace _06.AMiner_sTask
{
    public class MinersTask
    {
        public static void Main()
        {
            Dictionary<string, long> resources = new Dictionary<string, long>();
            string command = String.Empty;
            while (command.ToLower() != "stop")
            {
                string inputLine = Console.ReadLine();
                command = inputLine;
                if (command.ToLower() == "stop")
                {
                    continue;
                }
                string resource = inputLine;
                long quantity = long.Parse(Console.ReadLine());
                if (!resources.ContainsKey(resource))
                {
                    resources.Add(resource, quantity);
                }
                else
                {
                    resources[resource] += quantity;
                }
            }
            foreach (var kvp in resources)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
