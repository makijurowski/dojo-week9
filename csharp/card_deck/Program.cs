using System;
using System.Collections.Generic;
using System.Linq;

namespace card_decks {
    public class Card {
        // Initialize properties for Card class
        public string StringVal { get; set; }
        public string Suit { get; set; }
        public int Val { get; set; }

        // Define Card constructor with suit, val, and stringVal parameters/properties
        public Card (string suit, int val, string stringVal) {
            StringVal = stringVal;
            Suit = suit;
            Val = val;
        }

        // Method to print card properties for debugging
        public void ShowCard (string title) {
            System.Console.WriteLine ("-----CURRENT CARD: {0}-----", title);
            System.Console.WriteLine ("StringVal: {0}", StringVal);
            System.Console.WriteLine ("Suit: {0}", Suit);
            System.Console.WriteLine ("Val: {0}", Val);
        }
    }

    public class Deck {
        // Initialize properties for Deck class
        public List<Card> Cards { get; set; }
        public int CardCount { get; set; }

        // Define Deck constructor with cards and card count properties
        // Declare arguments to pass to Card class
        public Deck () {
            int cardCount = 0;
            Cards = new List<Card> ();
            string[] suits = {
                "Spades",
                "Hearts",
                "Clubs",
                "Diamonds"
            };
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
            // Declare a new dictionary to hold vals and cardVals
            Dictionary<int, string> cardVal = new Dictionary<int, string> ();
            // Add each val to dictionary with val as keys and stringVal as values
            foreach (int num in val) {
                cardVal.Add (num, stringVal[num - 1]);
            }
            // Loops to build a new Deck of 52 cards
            foreach (string suit in suits) {
                foreach (KeyValuePair<int, string> card in cardVal) {
                    Card currentCard = new Card (suit, card.Key, card.Value);
                    // currentCard.ShowCard("Card Creation");
                    cardCount += 1;
                    Cards.Add (currentCard);
                }
            }
            CardCount = cardCount;
        }

        // Method to show information about the current deck
        public void ShowDeck (string title) {
            System.Console.WriteLine ("-----CURRENT DECK: {0}-----", title);
            System.Console.WriteLine ("CardCount: {0}", CardCount);
            System.Console.WriteLine ("Cards.count: {0}", Cards.Count);
        }

        // Method used to deal a new card and remove it from the deck
        public Card Deal () {
            List<Card> currentDeck = this.Cards;
            Card currentCard = currentDeck[1];
            currentDeck.RemoveAt (1);
            this.CardCount -= 1;
            return currentCard;
        }

        // Method to shuffle the order of cards in the deck (based on Fisher-Yates)
        public void Shuffle () {
            Random random = new Random ();
            for (int index = 0; index < Cards.Count - 1; index++) {
                int randomIndex = random.Next (index + 1, Cards.Count);
                Card tempCard = Cards[index];
                Cards[index] = Cards[randomIndex];
                Cards[randomIndex] = tempCard;
            }
        }

        // Method to reset the deck back to default (52 cards, ordered)
        public Deck Reset () {
            Deck newDeck = new Deck ();
            newDeck.ShowDeck ("Reset Deck");
            return newDeck;
        }
    }

    public class Player {
        // Declare properties for Player class
        public string Name { get; set; }
        public List<Card> Hand { get; set; }

        // Constructor for Player class
        public Player (string name) {
            Name = name;
            Hand = new List<Card> ();
        }

        // Method for player to draw a new card (using Deal method from Deck class)
        public Card DrawCard (Deck deck) {
            deck.Shuffle ();
            Card drawnCard = deck.Deal ();
            drawnCard.ShowCard ("Card Drawn");
            Hand.Add (drawnCard);
            System.Console.WriteLine ("Card Count in Hand: {0}", Hand.Count);
            return drawnCard;
        }

        // Method for player to discard a card at a known index
        public Card Discard (int index) {
            try {
                Card discardedCard = Hand[index];
                discardedCard.ShowCard ("Discarded Card");
                Hand.RemoveAt (index);
                return discardedCard;
            } catch (System.ArgumentOutOfRangeException) {
                return null;
            }
        }

        // Method that shows information for the Player class for debugging
        public void ShowPlayer (string title) {
            System.Console.WriteLine ("-----CURRENT PLAYER: {0}-----", title);
            System.Console.WriteLine ("Name: {0}", Name);
            System.Console.WriteLine ("Hand.count: {0}", Hand.Count);
        }

        // Method that shows information on the Player's hand for debugging
        public void ShowHand () {
            System.Console.WriteLine ("-----CURRENT HAND: {0} ({1} Cards)-----", Name, Hand.Count);
            int handCount = 1;
            foreach (var handCard in Hand) {
                string cardNum = String.Format ("Hand Card #{0}", handCount);
                handCard.ShowCard (cardNum);
                handCount += 1;
            }
        }
    }

    class Program {
        static void Main (string[] args) {
            // Construct a new deck
            Deck myDeck = new Deck ();
            myDeck.ShowDeck ("My Deck");
            // Construct a new player
            Player me = new Player ("Maki");
            me.ShowPlayer ("Me!");
            // Deal cards to player
            for (int i = 0; i < 5; i++) {
                myDeck.Shuffle ();
                Card cardDealt = me.DrawCard (myDeck);
            }
            // Discard
            Card discard = me.Discard (1);
            // Check player and status of deck after discarding
            me.ShowPlayer ("Me after Discard!");
            me.ShowHand ();
            // Reset deck
            myDeck = myDeck.Reset ();
        }
    }
}