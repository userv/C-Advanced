using System;
using System.Collections.Generic;
using System.Text;

public class SumBigNumbers
{
    public static void Main()
    {
        Stack<char> firstNumber = new Stack<char>(Console.ReadLine());
        Stack<char> secondNumber = new Stack<char>(Console.ReadLine());
        StringBuilder sb = new StringBuilder();
        int sum = 0;
        while (firstNumber.Count != 0 || secondNumber.Count != 0)
        {
            if (firstNumber.Count != 0)
            {
                sum += (int) char.GetNumericValue(firstNumber.Pop());
            }
            if (secondNumber.Count != 0)
            {
                sum += (int)char.GetNumericValue(secondNumber.Pop());
            }
            sb.Insert(0, sum % 10);
            sum /= 10;
        }
        sb.Insert(0, sum);
        Console.WriteLine(sb.ToString().TrimStart('0'));

    }
}

