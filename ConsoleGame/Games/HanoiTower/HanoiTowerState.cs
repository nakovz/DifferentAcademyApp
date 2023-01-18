using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleGame {
    public class HanoiTowerState {
        public List<int>[] DiskListStack { get; set; }
        public HanoiTowerCursor UserCursor { get; set; }
        public int Moves { get; set; }
        
        public static HanoiTowerState InitTowerState(int level) {
            var hanoiTowerState = new HanoiTowerState {
                DiskListStack = new List<int>[3],
                Moves = 0,
                UserCursor = new HanoiTowerCursor { Position = 1, Weight = 0 }
            };
            hanoiTowerState.DiskListStack[0] = new List<int>();
            hanoiTowerState.DiskListStack[1] = new List<int>();
            hanoiTowerState.DiskListStack[2] = new List<int>();
            for (int i = level - 1; i >= 0; i--) {
                hanoiTowerState.DiskListStack[1].Add(i + 1);
            }
            return hanoiTowerState;
        }

        public static void Solution(int level) {
            var gameState = InitTowerState(level);
            Console.Clear();
            PrintSolutionState(gameState, level);
            Console.WriteLine("\nPress any key to start...");
            Console.ReadKey();
            SolutionMove(gameState, level, 1, 2, 0,level);
            Console.WriteLine("\nThat's it! Press any key to continue...");
            Console.ReadKey();
        }

        private static void PrintSolutionState(HanoiTowerState gameState, int level) {
            Console.WriteLine($"*** This is only demonstration for the solution.***\n");
            Console.WriteLine($"Minimum moves: { Math.Pow(2, level) - 1 }\tMoves: { gameState.Moves }\n");
            PrintState(gameState, level);
        }

        private static HanoiTowerState MoveDisk(HanoiTowerState gameState, int level, int fromStack, int toStack, int hanoiTowerLevel) {
            gameState.UserCursor.Position = fromStack;
            Console.Clear();
            PrintSolutionState(gameState, hanoiTowerLevel);
            Thread.Sleep(200);
            gameState.DiskListStack[fromStack].Remove(level);
            gameState.UserCursor.Weight = level;
            Console.Clear();
            PrintSolutionState(gameState, hanoiTowerLevel);
            Thread.Sleep(200);
            gameState.UserCursor.Position = toStack;
            Console.Clear();
            PrintSolutionState(gameState, hanoiTowerLevel);
            Thread.Sleep(200);
            gameState.DiskListStack[toStack].Add(level);
            gameState.UserCursor.Weight = 0;
            Console.Clear();
            PrintSolutionState(gameState, hanoiTowerLevel);
            gameState.Moves++;
            return gameState;
        }

        private static void SolutionMove(HanoiTowerState gameState, int level, int fromStack, int auxStack, int toStack, int hanoiTowerLevel) {
            if (level == 1) {
                MoveDisk(gameState, level, fromStack, toStack, hanoiTowerLevel);
            } else {
                SolutionMove(gameState, level - 1, fromStack, toStack, auxStack, hanoiTowerLevel);
                MoveDisk(gameState, level, fromStack, toStack, hanoiTowerLevel);
                SolutionMove(gameState, level - 1, auxStack, fromStack, toStack, hanoiTowerLevel);
            }
        }

        public static bool PrintState(HanoiTowerState gameState, int level) {
            PrintCursor(gameState.UserCursor, level);
            for (int i = 0; i < level; i++) {
                var printRows = "|";
                printRows += (gameState.DiskListStack[0].Count < level - i ? DiskFromWeight(0, level) : DiskFromWeight(gameState.DiskListStack[0].ElementAt(level - i - 1), level)) + "|";
                printRows += (gameState.DiskListStack[1].Count < level - i ? DiskFromWeight(0, level) : DiskFromWeight(gameState.DiskListStack[1].ElementAt(level - i - 1), level)) + "|";
                printRows += (gameState.DiskListStack[2].Count < level - i ? DiskFromWeight(0, level) : DiskFromWeight(gameState.DiskListStack[2].ElementAt(level - i - 1), level)) + "|";
                Console.WriteLine(printRows);
            }
            int solutionWeight = level * (level + 1) / 2;
            int stack0 = gameState.DiskListStack[0].Sum();
            int stack2 = gameState.DiskListStack[2].Sum();
            return stack0 == solutionWeight || stack2 == solutionWeight;
        }

        internal static HanoiTowerState KeyPress(HanoiTowerState gameState, int hanoiTowerLevel, ConsoleKey userKeyPress) {
            switch (userKeyPress) {
                case ConsoleKey.LeftArrow:
                    gameState.UserCursor.Position = --gameState.UserCursor.Position < 0 ? 2 : gameState.UserCursor.Position;
                    break;
                case ConsoleKey.RightArrow:
                    gameState.UserCursor.Position = ++gameState.UserCursor.Position > 2 ? 0 : gameState.UserCursor.Position;
                    break;
                case ConsoleKey.Spacebar:
                    gameState = SpaceBarPressed(gameState, hanoiTowerLevel);
                    break;
                default:
                    break;
            }
            return gameState;
        }

        private static HanoiTowerState DragDisk(HanoiTowerState gameState) {
            var level = gameState.DiskListStack[gameState.UserCursor.Position].Count - 1;
            var diskWeightFromStack = gameState.DiskListStack[gameState.UserCursor.Position].ElementAt(level);
            gameState.UserCursor.Weight = diskWeightFromStack;
            gameState.DiskListStack[gameState.UserCursor.Position].Remove(diskWeightFromStack);
            return gameState;
        }

        private static HanoiTowerState DropDisk(HanoiTowerState gameState) {
            gameState.DiskListStack[gameState.UserCursor.Position].Add(gameState.UserCursor.Weight);
            gameState.UserCursor.Weight = 0;
            gameState.Moves++;
            return gameState;
        }

        private static HanoiTowerState SpaceBarPressed(HanoiTowerState gameState, int hanoiTowerLevel) {
            var level = gameState.DiskListStack[gameState.UserCursor.Position].Count - 1;
            if (level >= 0) {
                var diskWeightFromStack = gameState.DiskListStack[gameState.UserCursor.Position].ElementAt(level);
                if (gameState.UserCursor.Weight == 0) {
                    gameState = DragDisk(gameState);
                } else {
                    if (gameState.UserCursor.Weight < diskWeightFromStack) {
                        gameState = DropDisk(gameState);
                    }
                }
            } else {
                if (gameState.UserCursor.Weight > 0) {
                    gameState = DropDisk(gameState);
                }
            }
            return gameState;
        }

        private static string DiskFromWeight(int weight, int level) {
            string returnValue = "";
            if (weight > 0) {
                string blankSpace = "".PadRight(level - weight + 1);
                string disk = "<" + "o".PadRight(weight * 2 - 1, 'o') + ">";
                returnValue = blankSpace + disk + blankSpace;
            } else {
                returnValue = "".PadRight((level + 1) * 2 + 1);
            }
            return returnValue;
        }

        private static void PrintCursor(HanoiTowerCursor userCursor, int level) {
            string returnValue = " ";
            for (int i = 0; i < userCursor.Position; i++) {
                returnValue += "".PadRight((level + 1) * 2 + 1);
                returnValue += " ";
            }
            if (userCursor.Weight > 0) {
                returnValue += DiskFromWeight(userCursor.Weight, level);
            } else {
                returnValue += "".PadRight(level + 1) + "V";
            }
            Console.WriteLine(returnValue + "\n");
        }
    }
}
