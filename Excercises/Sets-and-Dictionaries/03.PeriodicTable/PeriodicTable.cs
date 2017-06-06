using System;
using System.Collections.Generic;



namespace _03.PeriodicTable
{
    public class PeriodicTable
    {
        public static void Main()
        {
           
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> periodicTable = new SortedSet<string>();
            for (int i = 0; i < n; i++)
            {
                
                string[] elements = Console.ReadLine().Split(' ');
                for (int j = 0; j < elements.Length; j++)
                {
                    periodicTable.Add(elements[j]);
                }
            }
            Console.WriteLine(String.Join(" ", periodicTable));
        }
    }
}
