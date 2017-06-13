using System;
using System.Collections.Generic;
using System.Text;



class MultiplyBigNumber
{
    static void Main(string[] args)
    {
        Stack<char> firstNumber = new Stack<char>(Console.ReadLine().TrimStart('0'));
        byte secondNumber = byte.Parse(Console.ReadLine());
        StringBuilder sb = new StringBuilder();
        int product = 0, numberInMind = 0, remainder = 0;
        while (firstNumber.Count != 0)
        {
            byte currentDigit = (byte)char.GetNumericValue(firstNumber.Pop());
            product = currentDigit * secondNumber + numberInMind;
            numberInMind = product / 10;
            remainder = product % 10;
            sb.Insert(0, remainder);
        }
        if (numberInMind != 0)
        {
            sb.Insert(0, numberInMind);
        }
        string result = sb.ToString().TrimStart('0');
        if (result.Length==0)
        {
            Console.WriteLine(0);
        }
        else
        {
            Console.WriteLine(result);
        }
        
    }
}
