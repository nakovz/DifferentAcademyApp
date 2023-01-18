using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame {
    class GameMindReader : IItemsForSale {

        public string Name { get; set; }
        public string Status { get; set; } = "Buy";
        public string Description { get; } = "I will guess Your card in only 3 tries.";
        public int Price { get; set; } = 10;
        public string Currency { get; set; } = "EUR";
        public int Rating { get; set; } = 5;
        public void Execute() {
            do {
                var cardDeck = InitPlayingCardDeck();
                cardDeck = ShufflePlayingCardDeck(cardDeck);
                Console.Clear();
                Console.WriteLine("Please choose one card!");
                for (int i = 0; i < 3; i++) {
                    Console.WriteLine();
                    PrintPlayingCardStacks(cardDeck);
                    int userStack = MyUserInput.NumberOnly("\nPlease tell me in which pile is your card:", true, "", 3).IntegerValue;
                    cardDeck = ReorderPlayingCardStacks(userStack, cardDeck);
                }
                Console.Write($"\nYour card is: ");
                PrintPlayingCard(cardDeck[7]);
                Console.WriteLine("\n\nThank You for playing Mind Reader!\n");
            } while (MyMessages.DoYouWantYesNo("to play again?"));
        }

        public static void Play() {
            do {
                var cardDeck = InitPlayingCardDeck();
                cardDeck = ShufflePlayingCardDeck(cardDeck);
                Console.Clear();
                Console.WriteLine("Please choose one card!");
                for (int i = 0; i < 3; i++) {
                    Console.WriteLine();
                    PrintPlayingCardStacks(cardDeck);
                    int userStack = MyUserInput.NumberOnly("\nPlease tell me in which pile is your card:", true, "", 3).IntegerValue;
                    cardDeck = ReorderPlayingCardStacks(userStack, cardDeck);
                }
                Console.Write($"\nYour card is: ");
                PrintPlayingCard(cardDeck[7]);
                Console.WriteLine("\n\nThank You for playing Mind Reader!\n");
            } while (MyMessages.DoYouWantYesNo("to play again?"));
        }

        private static List<int> ReorderPlayingCardStacks(int userStack, List<int> cardDeck) {
            if(userStack==1 || userStack == 3) {
                for (int i = 0; i < 5; i++) {
                    cardDeck = SwitchPlayingCards((userStack - 1) * 5 + i, 5 + i, cardDeck);
                }
            }
            var tempCardDeck = new List<int>();
            tempCardDeck.AddRange(cardDeck);
            for (int i = 0; i < 5; i++) {
                cardDeck[i] = tempCardDeck[i * 3];
                cardDeck[i+5] = tempCardDeck[i * 3 + 1];
                cardDeck[i+10] = tempCardDeck[i * 3 + 2];
            }
            return cardDeck;
        }

        private static List<int> SwitchPlayingCards(int cardIndex1, int cardIndex2, List<int> cardDeck) {
            int tempCard = cardDeck[cardIndex1];
            cardDeck[cardIndex1] = cardDeck[cardIndex2];
            cardDeck[cardIndex2] = tempCard;
            return cardDeck;
        }

        private static void PrintPlayingCardStacks(List<int> cardDeck) {
            for (int i = 0; i < 15; i++) {
                if (i % 5 == 0 && i > 0) { Console.WriteLine(); }
                if (i % 5 == 0) { Console.Write($"Pile { (Convert.ToInt32(i / 5) + 1) }: "); }
                PrintPlayingCard(cardDeck[i]);
            }
            Console.WriteLine();
        }

        private static List<int> InitPlayingCardDeck() {
            var cardDeck = new List<int>();
            for (int i = 0; i < 51; i++) {
                cardDeck.Add(i);
            }
            return cardDeck;
        }

        private static List<int> ShufflePlayingCardDeck(List<int> cardDeck) {
            var myCardDeck = cardDeck;
            var shuffleCardDeck = new List<int>();
            var r = new Random();
            for (int i = 0; i < 51; i++) {
                var pickedCard = myCardDeck.ElementAt(r.Next(1, myCardDeck.Count) - 1);
                shuffleCardDeck.Add(pickedCard);
                myCardDeck.Remove(pickedCard);
            }
            return shuffleCardDeck;
        }

        private static void PrintPlayingCard(int card) {
            var tempConsoleBackColor = Console.BackgroundColor;
            var tempConsoleForeColor = Console.ForegroundColor;
            Console.BackgroundColor = ConsoleColor.White;
            if (Convert.ToInt32(card / 13) < 2) {
                Console.ForegroundColor = ConsoleColor.Black;
            } else {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.Write(PlayingCardString(card));
            Console.BackgroundColor = tempConsoleBackColor;
            Console.ForegroundColor = tempConsoleForeColor;
            Console.Write(" ");
        }

        private static string PlayingCardString(int card) {
            var playingCardSuits = "♠♣♥♦";
            var playingCardNumbers="JQK";
            var cardNumber = (card % 13 + 1) > 10 ? playingCardNumbers[(card % 13 + 1) - 10 - 1].ToString() : (card % 13 + 1).ToString();
            var cardSuits = Convert.ToInt32(card / 13);
            return cardNumber + playingCardSuits[cardSuits];
        }
    }
}
