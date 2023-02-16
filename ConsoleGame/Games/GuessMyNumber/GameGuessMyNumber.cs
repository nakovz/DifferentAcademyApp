using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame {
    class GameGuessMyNumber : IItemsForSale {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string Status { get; set; } = "Buy";
        public string Description { get; } = "You need to guess my number!";
        public int Price { get; set; } = 10;
        public string Currency { get; set; } = "EUR";
        public int Rating { get; set; } = 3;
        internal static void Play() {
            do {
                Random r = new Random();
                int randomMaxNumber = 100;
                int myNumber = r.Next(1, randomMaxNumber);
                MyUserInputType userAnswer = new MyUserInputType {
                    ExitAnswer = false
                };
                int userNumber = 0;
                int userAttempts = 0;
                string myMessage = $"\nLet's play Guess My Number\n\nMy number is between 1 and { randomMaxNumber }";
                Console.Clear();
                while (myNumber != userNumber) {
                    Console.WriteLine(myMessage);
                    userAnswer = MyUserInput.NumberOnly("Guess my number (x=Exit):", true, "x");
                    userNumber = userAnswer.IntegerValue;
                    userAttempts++;
                    if (myNumber == userNumber) {
                        Console.WriteLine($"Excellent! You guess my number after { userAttempts } attempts!\n");
                    } else if (myNumber > userNumber) {
                        myMessage = $"My number is greater than { userNumber }";
                    } else {
                        myMessage = $"My number is less than { userNumber }";
                    }
                    if (userAnswer.ExitAnswer) {
                        userNumber = myNumber;
                    }
                }
            } while (MyMessages.DoYouWantYesNo("to play again?"));
        }

        public void Execute() {
            Play();
        }
    }
}
