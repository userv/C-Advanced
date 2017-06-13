using System;
using System.Collections.Generic;
using System.Linq;


public class Palindromes
{
    public static void Main()
    {
        string[] inputString = Console.ReadLine()
            .Split(new char[] { ' ', ',', '.', '?', '!', '"' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        HashSet<string> palindromes = new HashSet<string>();
        foreach (var word in inputString)
        {
            string reversedWord = new string(word.Reverse().ToArray());
            if (word == reversedWord)
            {
                palindromes.Add(word);
            }
        }
        Console.WriteLine($"[{string.Join(", ", palindromes.OrderBy(n => n))}]");
    }
}

