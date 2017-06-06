using System;
using System.Collections.Generic;
using System.Linq;


public class PopulationCounter
{
    public static void Main()
    {
        Dictionary<string, Dictionary<string, long>> countries = new Dictionary<string, Dictionary<string, long>>();
        string inputLine = Console.ReadLine();
        while (inputLine != "report")
        {
            string[] tokens = inputLine.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
            string city = tokens[0];
            string country = tokens[1];
            long population = long.Parse(tokens[2]);
            if (!countries.ContainsKey(country))
            {
                countries[country] = new Dictionary<string, long>() { { city, population } };
            }
            else
            {
                countries[country][city] = population;
            }
            inputLine = Console.ReadLine();
        }
        var orderdCountries = countries.OrderByDescending(x => x.Value.Values.Sum());
        foreach (var country in orderdCountries)
        {
            long totalPopulation = country.Value.Values.Sum();
            Console.WriteLine($"{country.Key} (total population: {totalPopulation})");
            foreach (var city in country.Value.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"=>{city.Key}: {city.Value}");
            }
        }
    }
}

