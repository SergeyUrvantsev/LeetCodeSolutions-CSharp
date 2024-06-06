using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Medium._846._Hand_of_Straights
{
    public class NStraightHand
    {
        // Complexity:
        // Time complexity: O(n log n), где n - количество карт в руке (hand.Length)
        // Space complexity: O(n), для хранения карты и их счетчиков

        public bool Solve_v1(int[] hand, int groupSize)
        {
            if (hand.Length % groupSize != 0)
                return false;

            var groups = new int[hand.Length / groupSize, 2];

            for (int i = 0; i < hand.Length / groupSize; i++)
            {
                groups[i, 0] = 0;
                groups[i, 1] = -1;
            }

            foreach (var card in hand.Order())
            {
                var pos = -1;

                for (int i = 0; i < hand.Length / groupSize; i++)
                {
                    if (groups[i, 0] < groupSize
                        && (card - groups[i, 1] == 1 || groups[i, 1] == -1))
                    {
                        pos = i;
                        break;
                    }
                }

                if (pos == -1)
                    return false;

                groups[pos, 0]++;
                groups[pos, 1] = card;
            }

            return true;
        }

        public bool Solve_v2(int[] hand, int groupSize)
        {
            if (hand.Length % groupSize != 0)
                return false;

            // Считаем количество каждой карты
            var cardCount = new Dictionary<int, int>();
            foreach (var card in hand)
            {
                if (cardCount.ContainsKey(card))
                    cardCount[card]++;
                else
                    cardCount[card] = 1;
            }

            // Получаем все уникальные карты и сортируем их
            var uniqueCards = new List<int>(cardCount.Keys);
            uniqueCards.Sort();

            foreach (var card in uniqueCards)
            {
                int count = cardCount[card];
                if (count > 0)
                {
                    for (int i = 0; i < groupSize; i++)
                    {
                        int currentCard = card + i;
                        if (!cardCount.ContainsKey(currentCard) || cardCount[currentCard] < count)
                            return false;

                        cardCount[currentCard] -= count;
                    }
                }
            }

            return true;
        }

        public bool Solve_v3(int[] hand, int groupSize)
        {
            if (hand.Length % groupSize != 0)
                return false;

            var cardCount = new Dictionary<int, int>();
            foreach (var card in hand)
            {
                cardCount[card] = cardCount.GetValueOrDefault(card, 0) + 1;
            }

            var uniqueCards = new List<int>(cardCount.Keys);
            uniqueCards.Sort();

            foreach (var card in uniqueCards)
            {
                if (cardCount[card] > 0)
                {
                    var count = cardCount[card];
                    for (int currentCard = card; currentCard < card + groupSize; currentCard++)
                    {
                        if (!cardCount.ContainsKey(currentCard) || cardCount[currentCard] < count)
                            return false;

                        cardCount[currentCard] -= count;
                    }
                }
            }

            GC.Collect();
            return true;
        }
    }
}
