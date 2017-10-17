using System;
using System.Collections.Generic;

namespace card_deck
{
    class Program
    {
        public class Card
        {
            public string StringVal { get; set; }
            public string Suit { get; set; }
            public int Val { get; set; }
        

            public Card(string suit, int val, string stringVal)
            {
                StringVal = stringVal;
                Suit = suit;
                Val = val;
            }

            public void ShowStatus() {
                System.Console.WriteLine("------CURRENT CARD-----");
                System.Console.WriteLine("StringVal: {0}", StringVal);
                System.Console.WriteLine("Suit: {0}", Suit);
                System.Console.WriteLine("Val: {0}", Val);
            }

        }

        public class Deck
        {
            public List<object> Cards { get; set; }

            public Deck()
            {
                int cardCount = 0;
                Cards = new List<object>();
                string[] suits = { "Spades", "Hearts", "Clubs", "Diamonds" };
                string[] stringVal = { 
                    "Ace",
                    "2",
                    "3",
                    "4",
                    "5",
                    "6",
                    "7",
                    "8",
                    "9",
                    "10",
                    "Jack",
                    "Queen",
                    "King"
                };
                int[] val = {
                    1,
                    2,
                    3,
                    4,
                    5,
                    6,
                    7,
                    8,
                    9,
                    10,
                    11,
                    12,
                    13
                };
                Dictionary<int, string> cardVal = new Dictionary<int, string>();
                foreach (int num in val) {
                    cardVal.Add(num, stringVal[num - 1]);
                }
                foreach (string suit in suits) {
                    foreach (KeyValuePair<int, string> card in cardVal) {
                        // System.Console.WriteLine("Key: {0}, Value: {1}", card.Key, card.Value);
                        Card currentCard = new Card(suit, card.Key, card.Value);
                        currentCard.ShowStatus();
                        cardCount += 1;
                        System.Console.WriteLine("Current Count: {0}", cardCount);
                        Cards.Add(currentCard);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Deck firstDeck = new Deck();
        }
    }

}
