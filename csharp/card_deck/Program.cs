using System;
using System.Collections.Generic;
using System.Linq;

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
            public List<Card> Cards { get; set; }
            public int CardCount { get; set; }

            public Deck()
            {
                int cardCount = 0;
                Cards = new List<Card>();
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
                        // currentCard.ShowStatus();
                        cardCount += 1;
                        // System.Console.WriteLine("Current Count: {0}", cardCount);
                        Cards.Add(currentCard);
                    }
                }
                CardCount = cardCount;
            }

            public Card Deal() {
                List<Card> currentDeck = this.Cards;
                Card currentCard = currentDeck[1];
                System.Console.WriteLine(currentCard.Val);
                currentDeck.RemoveAt(1);
                this.CardCount -= 1;
                return currentCard;
            }

            public void Shuffle()
            {
                Random rand = new Random();
                for (int idx = 0; idx < Cards.Count - 1; idx++)
                {
                    int randIdx = rand.Next(idx + 1, Cards.Count);
                    Card tempCard = Cards[idx];
                    Cards[idx] = Cards[randIdx];
                    Cards[randIdx] = tempCard;
                }
            }

            public Deck Reset() {
                Deck newDeck = new Deck();
                return newDeck;
            }
        }

        public class Player
        {
            public string Name { get; set; }
            public List<Card> Hand { get; set; }
            
            public Player(string name)
            {
                Name = name;
                Hand = new List<Card>();
            }
            public Card DrawCard(Deck deck)
            {
                deck.Shuffle();
                Card drawnCard = deck.Deal();
                Hand.Add(drawnCard);
                return drawnCard;
            }

            public Card Discard(int index)
            {
                try
                {
                    Card discardedCard = Hand[index];
                    Hand.RemoveAt(index);
                    return discardedCard;
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    return null;
                }
            }
        }

        static void Main(string[] args)
        {
            // Testing my cards
            Deck firstDeck = new Deck();
            Player me = new Player("Maki");
            // System.Console.WriteLine(firstDeck.CardCount);
            Card myCard = firstDeck.Deal();
            firstDeck.Shuffle();
            Card myNewestCard = firstDeck.Deal();
            // System.Console.WriteLine(firstDeck.CardCount);
            firstDeck = firstDeck.Reset();
            // System.Console.WriteLine(firstDeck.CardCount);
            Card myREALNewestCard = me.DrawCard(firstDeck);
            me.DrawCard(firstDeck);
            me.DrawCard(firstDeck);
            me.DrawCard(firstDeck);
            // System.Console.WriteLine(myREALNewestCard.Val);
            Card discard = me.Discard(1);
            // System.Console.WriteLine(discard);
        }
    }

}
