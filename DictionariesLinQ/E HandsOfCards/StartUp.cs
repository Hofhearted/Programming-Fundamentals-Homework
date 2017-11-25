using System;
using System.Collections.Generic;
using System.Linq;

namespace E_HandsOfCards
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> playersWithCards = new Dictionary<string, List<string>>();
            string line = Console.ReadLine();
            while (line != "JOKER")
            {
                string[] commandArgs = line?.Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                string playerName = commandArgs?[0];
                string[] cards = commandArgs?[1].Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (playerName != null && !playersWithCards.ContainsKey(playerName))
                {
                    playersWithCards.Add(playerName, new List<string>());
                }
                if (playerName != null && playersWithCards.ContainsKey(playerName)) playersWithCards[playerName].AddRange(cards);
                line = Console.ReadLine();
            }

            PrintPlayersScores(playersWithCards);
        }

        private static void PrintPlayersScores(Dictionary<string, List<string>> playersWithCards)
        {
            foreach (var playerEntry in playersWithCards)
            {
                string playerName = playerEntry.Key;
                List<string> cards = playerEntry.Value.Distinct().ToList();
                int sum = 0;
                foreach (var card in cards)
                {
                    string rank = card.Substring(0, card.Length - 1);
                    string suite = card.Substring(card.Length - 1);

                    int rankPower = GetRank(rank);
                    int suitePower = GetSuite(suite);

                    sum += rankPower * suitePower;
                }

                Console.WriteLine("{0}: {1}", playerName, sum);
            }
        }

        private static int GetSuite(string suite)
        {
            switch (suite)
            {
                case "S":
                    return 4;
                case "H":
                    return 3;
                case "D":
                    return 2;
                case "C":
                    return 1;
                default:
                    return 1;
            }
        }

        private static int GetRank(string rank)
        {
            switch (rank)
            {
                case "2":
                    return 2;
                case "3":
                    return 3;
                case "4":
                    return 4;
                case "5":
                    return 5;
                case "6":
                    return 6;
                case "7":
                    return 7;
                case "8":
                    return 8;
                case "9":
                    return 9;
                case "10":
                    return 10;
                case "J":
                    return 11;
                case "Q":
                    return 12;
                case "K":
                    return 13;
                case "A":
                    return 14;
                default:
                    return 1;
            }
        }
    }
}