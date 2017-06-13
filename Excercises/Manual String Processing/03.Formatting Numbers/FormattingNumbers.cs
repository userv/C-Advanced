using System;


public class FormattingNumbers
{
    private const int MaximumBinLength = 10;
    public static void Main()
    {
        string[] inputLine = Console.ReadLine().Split(new char[]{' ','\t'},StringSplitOptions.RemoveEmptyEntries);
        int a = int.Parse(inputLine[0]);
        double b = double.Parse(inputLine[1]);
        double c = double.Parse(inputLine[2]);
        string aToBin = Convert.ToString(a, 2);
        string aToHex = a.ToString("X");
        if (aToBin.Length > MaximumBinLength)
        {
            aToBin = aToBin.Substring(0, MaximumBinLength);
        }
        else
        {
            aToBin = aToBin.PadLeft(MaximumBinLength, '0');
        }
        string result = string.Format("|{0,-10}|{1,10}|{2,10:F2}|{3,-10:F3}|", aToHex, aToBin, b, c);
        Console.WriteLine(result);


    }
}

