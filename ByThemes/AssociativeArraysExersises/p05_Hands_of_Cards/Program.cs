using System;
using System.Collections.Generic;
using System.Linq;

namespace p05_Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            var mapPlayers = new Dictionary<string, Dictionary<string,int>>();
            string cmnd = "";
            
            do
            {
                cmnd = ProcessCmnd(mapPlayers);
            } while (!("JOKER".Equals(cmnd)));
        }

        private static string ProcessCmnd(Dictionary<string, Dictionary<string, int>> mapPlayers)
        {
            var strArrA = Console.ReadLine().Split(':').ToArray();
      
            
            string cmnd = strArrA[0];
            if ("JOKER".Equals(cmnd))
            {
                PrintMap(mapPlayers);
            }
            else {
                var strArrB = strArrA[1].Split(new char[] { ' ', ',', ':' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                Dictionary<string, int> playersDeck = GetMapFromArray(strArrB);
                bool found = false;
                
                found = mapPlayers.TryGetValue(cmnd, out var mapCards);
                var toFillMap = new Dictionary<string, int>();
                
                toFillMap = InsertNewCards(found, mapCards, playersDeck);
                mapPlayers[cmnd] = toFillMap;
                 }
            return cmnd;
        }

        private static Dictionary<string, int> InsertNewCards(bool found, Dictionary<string, int> mapCards, 
            Dictionary<string, int> playersDeck)
        {
            if (found)
            {
                foreach (var item in playersDeck)
                {
                    mapCards[item.Key] = item.Value;
                }
                return mapCards;
            }
            else return playersDeck;
        }

        private static void PrintMap(Dictionary<string, Dictionary<string, int>> mapPlayers)
        {
            foreach (var item in mapPlayers)
            {
                long sumPowers = 0;
                foreach (var item1 in item.Value)
                {
                    sumPowers += item1.Value;
                }
                Console.WriteLine($"{item.Key}: {sumPowers}");
            }
        }

        private static Dictionary<string, int> GetMapFromArray(string[] strArr)
        {
            int arrSize = strArr.Length;
            Dictionary<string, int> cardsMap = new Dictionary<string, int>(arrSize);
            for (int i = 0; i < arrSize; i++)
            {
                string card = strArr[i];
                int cardPower = GetCardPower(card);
                cardsMap[card] = cardPower;
            }
            return cardsMap;
        }

        private static int GetCardPower(string card)
        {
            Dictionary<string, int> cardPwr = new Dictionary<string, int>();
            for (int i = 2; i <= 10; i++)
            {
                string key = i.ToString();
                cardPwr[key] = i;
            }
            cardPwr["J"] = 11; cardPwr["Q"] = 12; cardPwr["K"] = 13; cardPwr["A"] = 14;
            Dictionary<string, int> cardType = new Dictionary<string, int>();
            cardType["S"] = 4; cardType["H"] = 3; cardType["D"] = 2; cardType["C"] = 1;
            int typePwr = 0;
            if (card.Substring(0,2).Equals("10"))
            {
                string type = card[2].ToString();
                typePwr = 10 * cardType[type];
            }
            else
            {
                string pwr = card[0].ToString();
                string type = card[1].ToString();
                typePwr = cardPwr[pwr] * cardType[type];
            }
            return typePwr;
        }
    }
}
