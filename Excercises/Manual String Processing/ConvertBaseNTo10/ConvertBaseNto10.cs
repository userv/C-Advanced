using System;
using System.Numerics;



public class ConvertBaseNto10
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Trim().Split();
        int baseN = int.Parse(input[0]);
        char[] baseTenNumber = input[1].ToCharArray();

        BigInteger result = new BigInteger(0);

        for (int i = 0; i < baseTenNumber.Length; i++)
        {
            int currentNumber = (int)Char.GetNumericValue(baseTenNumber[i]);
            result += currentNumber * BigInteger.Pow(baseN, baseTenNumber.Length - i - 1);
        }

        Console.WriteLine(result);
    }
}

