using System;
using System.Text.RegularExpressions;



public class SeriesOfLetters
{
    public static void Main(string[] args)
    {
        string pattern = @"([A-Za-z])\1+";
        string inputLine = Console.ReadLine();
        Console.WriteLine(Regex.Replace(inputLine,pattern,"$1"));
    }
}

