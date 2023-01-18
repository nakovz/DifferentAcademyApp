using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame {
    class GamePyramid : IItemsForSale {

        public string Name { get; set; }
        public string Status { get; set; } = "Buy";
        public string Description { get; } = "I will draw an Pyramid with the desire height!";
        public int Price { get; set; } = 10;
        public string Currency { get; set; } = "EUR";
        public int Rating { get; set; } = 1;
        public void Execute() {
            do {
                MyUserInputType userAnswer = new MyUserInputType();

                Console.Clear();
                Console.Write("*** Let's draw some pyramids ***\n\n");

                userAnswer = MyUserInput.NumberOnly("Please enter the level of the pyramid:", true);
                int pyramidLevel = userAnswer.IntegerValue;

                for (int i = 0; i < pyramidLevel; i++) {
                    string blankSpaces = ("").PadRight(pyramidLevel - i - 1);
                    string starString = ("*").PadRight((i) * 2 + 1, '*');
                    Console.WriteLine(blankSpaces + starString);
                }
            } while (MyMessages.DoYouWantYesNo("to play again?"));
        }
        public static void Play() {
            do {
                MyUserInputType userAnswer = new MyUserInputType();

                Console.Clear();
                Console.Write("*** Let's draw some pyramids ***\n\n");

                userAnswer = MyUserInput.NumberOnly("Please enter the level of the pyramid:", true);
                int pyramidLevel = userAnswer.IntegerValue;

                for (int i = 0; i < pyramidLevel; i++) {
                    string blankSpaces = ("").PadRight(pyramidLevel - i - 1);
                    string starString = ("*").PadRight((i) * 2 + 1, '*');
                    Console.WriteLine(blankSpaces + starString);
                }
            } while (MyMessages.DoYouWantYesNo("to play again?"));
        }
    }
}
