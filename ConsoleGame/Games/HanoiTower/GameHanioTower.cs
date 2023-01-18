using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame {
    class GameHanioTower : IItemsForSale {

        public string Name { get; set; }
        public string Status { get; set; } = "Buy";
        public string Description { get; } = "You need to move entire Hanoi Tower from one place to another!";
        public int Price { get; set; } = 10;
        public string Currency { get; set; } = "EUR";
        public int Rating { get; set; } = 4;
        public void Execute() {
            do {
                Console.Clear();
                var hanoiTowerLevel = WellcomeScreen();
                Console.WriteLine($"You want to play with { hanoiTowerLevel } disks");
                var gameState = HanoiTowerState.InitTowerState(hanoiTowerLevel);
                Console.CursorVisible = false;

                var startTime = DateTime.Now;
                var isEscapePressed = false;
                var isHanoiTowerSolved = false;
                do {
                    PrintGameInfo(gameState.Moves, hanoiTowerLevel);
                    isHanoiTowerSolved = HanoiTowerState.PrintState(gameState, hanoiTowerLevel);
                    if (isHanoiTowerSolved == false) {
                        var userKeyPress = Console.ReadKey(true).Key;
                        switch (userKeyPress) {
                            case ConsoleKey.Escape:
                                isEscapePressed = true;
                                break;
                            case ConsoleKey.S:
                                HanoiTowerState.Solution(hanoiTowerLevel);
                                gameState = HanoiTowerState.InitTowerState(hanoiTowerLevel);
                                break;
                            default:
                                gameState = HanoiTowerState.KeyPress(gameState, hanoiTowerLevel, userKeyPress);
                                break;
                        }
                    }
                } while (isEscapePressed == false && isHanoiTowerSolved == false);
                Console.CursorVisible = true;
                var endTime = DateTime.Now;
                PrintGoodbye(isHanoiTowerSolved, gameState, endTime.Subtract(startTime));
            } while (MyMessages.DoYouWantYesNo("to play again?"));
        }

        public static void Play() {
            do {
                Console.Clear();
                var hanoiTowerLevel = WellcomeScreen();
                Console.WriteLine($"You want to play with { hanoiTowerLevel } disks");
                var gameState = HanoiTowerState.InitTowerState(hanoiTowerLevel);
                Console.CursorVisible = false;

                var startTime = DateTime.Now;
                var isEscapePressed = false;
                var isHanoiTowerSolved = false;
                do {
                    PrintGameInfo(gameState.Moves, hanoiTowerLevel);
                    isHanoiTowerSolved = HanoiTowerState.PrintState(gameState, hanoiTowerLevel);
                    if (isHanoiTowerSolved == false) {
                        var userKeyPress = Console.ReadKey(true).Key;
                        switch (userKeyPress) {
                            case ConsoleKey.Escape:
                                isEscapePressed = true;
                                break;
                            case ConsoleKey.S:
                                HanoiTowerState.Solution(hanoiTowerLevel);
                                gameState = HanoiTowerState.InitTowerState(hanoiTowerLevel);
                                break;
                            default:
                                gameState = HanoiTowerState.KeyPress(gameState, hanoiTowerLevel, userKeyPress);
                                break;
                        }
                    }
                } while (isEscapePressed == false && isHanoiTowerSolved == false);
                Console.CursorVisible = true;
                var endTime = DateTime.Now;
                PrintGoodbye(isHanoiTowerSolved, gameState, endTime.Subtract(startTime));
            } while (MyMessages.DoYouWantYesNo("to play again?"));
        }

        private static void PrintGoodbye(bool isHanoiTowerSolved, HanoiTowerState gameState, TimeSpan elapsedTime) {
            if (isHanoiTowerSolved) {
                string hours = elapsedTime.Hours > 0 ? (elapsedTime.Hours + " h, ") : "";
                string minutes = elapsedTime.Minutes > 0 ? (elapsedTime.Minutes + " min and ") : "";
                string seconds = elapsedTime.Seconds > 0 ? (elapsedTime.Seconds + " sec ") : "";
                Console.WriteLine($"\n*** Excelent, You did it in { gameState.Moves } moves. ***\n*** You finished in { hours + minutes + seconds }! ***\n");
            } else {
                Console.WriteLine($"\n*** Sorry, better luck next time ***\n");
            }
        }

        private static void PrintGameInfo(int moves, int level) {
            Console.Clear();
            Console.WriteLine("Rules:\n1> Only one disk may be moved at a time.");
            Console.WriteLine("2> Each move consists of taking the upper disk from one of the stacks\n   and placing it on top of another stack or on an empty rod.");
            Console.WriteLine("3> No disk may be placed on top of a disk that is smaller than it.\n");
            Console.WriteLine("Instructions:\n Left Arrow - move your cursor to the Left\nRight Arrow - move your cursor to the Right\n   SpaceBar - drag&drop the disk\n          S - Solution\n        Esc - Exit\n");
            Console.WriteLine($"Minimum moves: { Math.Pow(2,level) - 1 }\tMoves: { moves }\n");
        }

        private static int WellcomeScreen() {
            Console.WriteLine("Wellcome to HANOI TOWER game\n");
            int returnValue = 0;
            while(returnValue < 3) { 
                returnValue = MyUserInput.NumberOnly("Please enter the level of the Hanoi Tower You want to play (3-9):", true, "", 9).IntegerValue;
                if (returnValue < 3)
                    Console.WriteLine($"Please enter valid number bigger than 2!");
            }
            return returnValue;
        }
    }
}
