using System;
using System.Collections.Generic;
using System.Numerics;



public class ConvertBase10ToN
{
    public static void Main()
    {
        string[] inputLine = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        int baseN = int.Parse(inputLine[0]);
        BigInteger number = BigInteger.Parse(inputLine[1]);
        List<BigInteger> digits = new List<BigInteger>();
        if (baseN < 2 || baseN > 10)
        {
            return;
        }
        while (number != 0)
        {
            BigInteger remainder = number % baseN;
            number /= baseN;
            digits.Add(remainder);
        }
        digits.Reverse();
        Console.WriteLine(string.Join("", digits));
    }
}

