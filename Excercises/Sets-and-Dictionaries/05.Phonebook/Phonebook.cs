using System;
using System.Collections.Generic;

namespace _05.Phonebook
{
    public class Phonebook
    {
        public static void Main()
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            string command = String.Empty;
            while (command != "search")
            {
                string[] inputLine = Console.ReadLine().Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                command = inputLine[0];
                if (command == "search")
                {
                    continue;
                }
                string name = inputLine[0];
                string number = inputLine[1];
                if (!phonebook.ContainsKey(name))
                {
                    phonebook.Add(name, number);
                }
                else
                {
                    phonebook[name] = number;
                }
            }
            while (command != "stop")
            {
                string[] inputLine = Console.ReadLine().Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                command = inputLine[0];
                if (command == "stop")
                {
                    continue;
                }
                string name = inputLine[0];
                if (phonebook.ContainsKey(name))
                {
                    Console.WriteLine($"{name} -> {phonebook[name]}");
                }
                else
                {
                    Console.WriteLine($"Contact {name} does not exist.");
                }
            }
        }
    }
}
