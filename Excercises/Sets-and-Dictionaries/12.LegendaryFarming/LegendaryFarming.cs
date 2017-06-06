using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;

public class LegendaryFarming
{
    public const int ItemNeeded = 250;
    public static void Main()
    {
        string[] keyitems = new string[] { "shards", "fragments", "motes" };
        string legendaryItem = String.Empty;
        Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
        Dictionary<string, int> junk = new Dictionary<string, int>();
        foreach (var item in keyitems)
        {
            AddKeyMaterial(keyMaterials, item, 0);
        }

        string inputLine = Console.ReadLine();
        while (legendaryItem == String.Empty) 
        {
            string[] tokens = inputLine.Split(' ');
            if (tokens.Length % 2 != 0)
            {
                continue;
            }
            for (int i = 0; i < tokens.Length; i += 2)
            {
                int quantity = int.Parse(tokens[i]);
                string item = tokens[i + 1].ToLower();
                if (keyitems.Contains(item))
                {
                    AddKeyMaterial(keyMaterials, item, quantity);
                }
                else
                {
                    AddJunkMaterial(junk, item, quantity);
                }
                legendaryItem = LegendaryObtained(keyMaterials);
                switch (legendaryItem)
                {
                    case "Shadowmourne":
                        Console.WriteLine("Shadowmourne obtained!");
                        PrintRemainingMaterials(keyMaterials, junk);
                        Environment.Exit(0);
                        break;

                    case "Valanyr":
                        Console.WriteLine("Valanyr obtained!");
                        PrintRemainingMaterials(keyMaterials, junk);
                        Environment.Exit(0);
                        break;

                    case "Dragonwrath":
                        Console.WriteLine("Dragonwrath obtained!");
                        PrintRemainingMaterials(keyMaterials, junk);
                        Environment.Exit(0);
                        break;

                }
            }

            inputLine = Console.ReadLine();

        } 
    }

    private static void PrintRemainingMaterials(Dictionary<string, int> keyMaterials, Dictionary<string, int> junk)
    {
        foreach (var item in keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
        foreach (var item in junk.OrderBy(x => x.Key))
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }

    private static string LegendaryObtained(Dictionary<string, int> keyMaterials)
    {
        if (keyMaterials.ContainsKey("motes"))
        {
            if (keyMaterials["motes"] >= ItemNeeded)
            {
                keyMaterials["motes"] -= ItemNeeded;
                return "Dragonwrath";
            }
        }
        if (keyMaterials.ContainsKey("fragments"))
        {
            if (keyMaterials["fragments"] >= ItemNeeded)
            {
                keyMaterials["fragments"] -= ItemNeeded;
                return "Valanyr";
            }
        }
        if (keyMaterials.ContainsKey("shards"))
        {
            if (keyMaterials["shards"] >= ItemNeeded)
            {
                keyMaterials["shards"] -= ItemNeeded;
                return "Shadowmourne";
            }
        }
        return String.Empty;
    }

    private static void AddJunkMaterial(Dictionary<string, int> junk, string item, int quantity)
    {
        if (!junk.ContainsKey(item))
        {
            junk.Add(item, quantity);
        }
        else
        {
            junk[item] += quantity;
        }
    }

    private static void AddKeyMaterial(Dictionary<string, int> keyMaterials, string item, int quantity)
    {
        if (!keyMaterials.ContainsKey(item))
        {
            keyMaterials.Add(item, quantity);
        }
        else
        {
            keyMaterials[item] += quantity;
        }

    }
}

