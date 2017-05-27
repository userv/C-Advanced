using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ReverseNumbers
{
   public class ReverseNumbers
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Stack<int> numStack=new Stack<int>(numbers);
            Console.WriteLine(String.Join(" ",numStack.ToArray()));
        }
    }
}
