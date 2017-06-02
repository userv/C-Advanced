using System;
using System.Collections.Generic;
using System.Linq;


namespace _04.CountSymbols
{
    public class CountSymbols
    {
        public static void Main()
        {
            Dictionary<char,int> symbolsDictionary=new Dictionary<char, int>();
            string text = Console.ReadLine();
            foreach (var ch in text)
            {
                if (!symbolsDictionary.ContainsKey(ch))
                {
                    symbolsDictionary.Add(ch,1);
                }
                else
                {
                    symbolsDictionary[ch]++;
                }
            }
            foreach (var kvp in symbolsDictionary.OrderBy(k => k.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }
    }
}
