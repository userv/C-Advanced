using System;
using System.Collections.Generic;
using System.Linq;

public class HandsOfCards
{
    public static void Main()
    {
        Dictionary<string, HashSet<string>> players = new Dictionary<string, HashSet<string>>();
        string inputLine = Console.ReadLine();
        while (inputLine != "JOKER")
        {
            string[] tokens = inputLine.Split(':').Select(x => x.Trim()).ToArray();
            string playerName = tokens[0];
            string[] cards = tokens[1]
                      .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                      .Select(x => x.Trim())
                      .ToArray();
            if (!players.ContainsKey(playerName))
            {
                players.Add(playerName, new HashSet<string>(cards));
            }
            else
            {
                players[playerName].UnionWith(cards);
            }
            inputLine = Console.ReadLine();
        }
        PrintPlayersAndHands(players);
    }

    private static void PrintPlayersAndHands(Dictionary<string, HashSet<string>> players)
    {
        foreach (var player in players)
        {
            HashSet<string> cards = player.Value;
            int score = CalculatePlayerScore(cards);
            Console.WriteLine($"{player.Key}: {score}");
        }
    }

    private static int CalculatePlayerScore(HashSet<string> cards)
    {
        int totalScore = 0;
        foreach (var card in cards)
        {
            int score = 0, power = 0, type = 0;
            string cardPower = card.Substring(0, card.Length - 1);
            string cardType = card.Last().ToString();
            bool isDigit = int.TryParse(cardPower, out power);
            if (!isDigit)
            {
                switch (cardPower)
                {
                    case "J":
                        power = 11;
                        break;
                    case "Q":
                        power = 12;
                        break;
                    case "K":
                        power = 13;
                        break;
                    case "A":
                        power = 14;
                        break;
                }
            }
            switch (cardType)
            {
                case "S":
                    type = 4;
                    break;
                case "H":
                    type = 3;
                    break;
                case "D":
                    type = 2;
                    break;
                case "C":
                    type = 1;
                    break;
            }
            score = power * type;
            totalScore += score;
        }
        return totalScore;
    }
}

