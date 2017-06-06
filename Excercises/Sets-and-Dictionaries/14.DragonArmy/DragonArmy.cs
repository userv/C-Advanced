using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DragonArmy
{
    private const double DefaultHealth = 250;
    private const double DefaultDamage = 45;
    private const double DefaultArmor = 10;
    public static void Main()
    {
        Dictionary<string, Dictionary<string, double[]>> dragonsArmy = new Dictionary<string, Dictionary<string, double[]>>();
        double numberOfDragons = double.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfDragons; i++)
        {
            string[] dragonData = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string dragonType = dragonData[0];
            string dragonName = dragonData[1];
            double dragonDamage = (dragonData[2] == "null") ? DefaultDamage : double.Parse(dragonData[2]);
            double dragonHealth = (dragonData[3] == "null") ? DefaultHealth : double.Parse(dragonData[3]);
            double dragonArmor = (dragonData[4] == "null") ? DefaultArmor : double.Parse(dragonData[4]);
            if (!dragonsArmy.ContainsKey(dragonType))
            {
                dragonsArmy[dragonType] = new Dictionary<string, double[]>() { { dragonName, new[] { dragonDamage, dragonHealth, dragonArmor } } };
            }
            else
            {
                if (!dragonsArmy[dragonType].ContainsKey(dragonName))
                {
                    dragonsArmy[dragonType][dragonName] = new[] { dragonDamage, dragonHealth, dragonArmor };
                }
                else
                {
                    dragonsArmy[dragonType][dragonName] = new[] { dragonDamage, dragonHealth, dragonArmor };
                }
            }
        }
        foreach (var dragonType in dragonsArmy)
        {
            double averageDamage = 0;
            double averageHealth = 0;
            double averageArmor = 0;

            StringBuilder dragonInfo = new StringBuilder();
            foreach (var dragon in dragonType.Value.OrderBy(x => x.Key))
            {
                dragonInfo.Append(
                    $"-{dragon.Key} -> damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}\r\n");
                averageDamage += dragon.Value[0];
                averageHealth += dragon.Value[1];
                averageArmor += dragon.Value[2];
            }
            averageDamage /= dragonType.Value.Count;
            averageHealth /= dragonType.Value.Count;
            averageArmor /= dragonType.Value.Count;
            Console.WriteLine($"{dragonType.Key}::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");
            Console.Write(dragonInfo.ToString());
        }


    }
}

