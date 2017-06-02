using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _11.PoisonousPlants
{
    public class PoisonousPlants
    {
        public static void Main()
        {
            int numberOfPlants = int.Parse(Console.ReadLine());
            long[] amountOfPesticide = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            Stack<long> plants = new Stack<long>(amountOfPesticide);
            bool plantsDied = false;
            int days = 1;
            while (!plantsDied)
            {
                for (int i = 0; i < plants.Count; i++)
                {
                    long p1 = plants.Pop();
                    long p2 = plants.Peek();
                    if (p2 > p1)
                    {
                    //    plants.Enqueue(p1);
                    //    plants.Dequeue();
                    }
                    else
                    {
                    //    plants.Enqueue(p1);
                    //    plants.Enqueue(plants.Dequeue());

                    }
                }
                days++;
            }
        }
    }
}
