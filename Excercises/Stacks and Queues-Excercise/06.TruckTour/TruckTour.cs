using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.TruckTour
{
    public class TruckTour
    {
        public static void Main()
        {
            Queue<PetrolPump> pumps = new Queue<PetrolPump>();
            int numberOfPumps = int.Parse(Console.ReadLine());

            bool pumpIndexIsFound = false;
            int pumpIndex = 0;
            for (int i = 0; i < numberOfPumps; i++)
            {
                int[] tokens = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                PetrolPump pump = new PetrolPump(tokens[0], tokens[1], i);
                pumps.Enqueue(pump);
            }
            while (!pumpIndexIsFound)
            {
                PetrolPump currentPump = pumps.Dequeue();
                int petrolTank = 0;
                pumpIndex = currentPump.Index;
                pumps.Enqueue(currentPump);
                petrolTank += currentPump.AmountOfPetrol;
                petrolTank -= currentPump.DistanceToNextPump;
                if (petrolTank < 0)
                {
                    continue;
                }
                for (int i = 0; i < pumps.Count; i++)
                {
                    PetrolPump nextPump = pumps.Dequeue();
                    pumps.Enqueue(nextPump);
                    petrolTank += nextPump.AmountOfPetrol;
                    petrolTank -= nextPump.DistanceToNextPump;
                    if (petrolTank < 0)
                    {
                        break;
                    }
                }
                if (petrolTank >= 0)
                {
                    pumpIndexIsFound = true;
                }
            }
            Console.WriteLine(pumpIndex);
        }
    }

    public class PetrolPump
    {
        public int AmountOfPetrol { get; set; }
        public int DistanceToNextPump { get; set; }
        public int Index { get; set; }

        public PetrolPump(int amountOfPetrol, int distanceToNextPump, int index)
        {
            AmountOfPetrol = amountOfPetrol;
            DistanceToNextPump = distanceToNextPump;
            Index = index;
        }

    }
}
