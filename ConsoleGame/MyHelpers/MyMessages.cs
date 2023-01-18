using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame {
    public class MyMessages {
        public static void PressAnyKeyTo(string doSomething) {
            Console.Write($"Press any key to { doSomething }...");
            Console.ReadKey();
        }
        public static void TryAgain() {
            Console.WriteLine("Ooopsss, please enter valid option!");
            PressAnyKeyTo("try again");
        }

        public static void MissingCoin(int coinValue) {
            Console.WriteLine($"Ooopsss, you don't have { coinValue } MKD coin!");
            PressAnyKeyTo("insert another one");
        }

        public static bool TryAgainYesNo() {
            string userInput = "";
            do {
                Console.Write("Do You want to try again (y/n):");
                userInput = Console.ReadLine().ToLower();
            } while (Array.IndexOf(new string[] { "y", "n" }, userInput)<0);
            return userInput == "y";
        }

        public static bool DoYouWantYesNo(string text) {
            string userInput = "";
            do {
                Console.Write($"Do You want { text } (y/n):");
                userInput = Console.ReadLine().ToLower();
            } while (Array.IndexOf(new string[] { "y", "n" }, userInput) < 0);
            return userInput == "y";
        }

        public static bool QuestionYesNo(string question) {
            string userInput = "";
            do {
                Console.Write($"{ question } (y/n):");
                userInput = Console.ReadLine().ToLower();
            } while (Array.IndexOf(new string[] { "y", "n" }, userInput) < 0);
            return userInput == "y";
        }
    }
}
