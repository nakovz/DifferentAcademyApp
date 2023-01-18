using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame {
    class CashProcessor {
        internal static bool Paying(Person player, Games game) {
            bool returnValue = false;
            int insertedCoinBalance = 0;
            bool insertCoinAgain = true;
            while (insertCoinAgain) {
                MyUserInputType userChoice = InsertCoin(game, insertedCoinBalance, player);
                if (userChoice.ExitAnswer) {
                    returnValue = false;
                    insertCoinAgain = false;
                } else {
                    insertedCoinBalance += AddCoin(userChoice.IntegerValue, player);
                    int balance = game.GamePrice - insertedCoinBalance;
                    if (balance <= 0) {
                        insertedCoinBalance = -balance;
                        insertCoinAgain = false;
                        returnValue = true;
                    }
                }
            }
            PaymentAnswer(player, returnValue, insertedCoinBalance);
            MyMessages.PressAnyKeyTo("proceed");
            return returnValue;
        }

        private static void PaymentAnswer(Person player, bool paymentState, int returnChangeCoin) {
            Console.Clear();
            Console.WriteLine("Wellcome to Different Academy games store!\n");
            if (paymentState) {
                Console.WriteLine($"Successful payment!\n");
            } else {
                Console.WriteLine($"Unsuccessful payment!\n");
            }
            if (returnChangeCoin > 0) {
                Console.WriteLine($"You have a change of { returnChangeCoin } MKD\n");
                player.CashBalance += returnChangeCoin;
            }
        }

        private static MyUserInputType InsertCoin(Games game, int insertedCoinBalance, Person player) {
            Console.Clear();
            Console.WriteLine("Wellcome to Different Academy games store!\n");
            Console.WriteLine($"You want to buy * { game.GameName } * game and it will cost You { game.GamePrice } MKD!\n");
            Console.WriteLine($"You have inserted { insertedCoinBalance } MKD\nYou need to insert { game.GamePrice - insertedCoinBalance } MKD more\n");

            return MyUserInput.ChooseFromMenu("Please insert a coin\n", "\nSelect an option: ", "x", "-", "10 MKD", "50 MKD", "100 MKD", "500 MKD", "-", "Cancel");
        }

        private static int AddCoin(int coinIndex, Person player) {
            int returnValue = 0;
            int coinValue = 0;
            switch (coinIndex) {
                case 1:
                    coinValue = 10;
                    break;
                case 2:
                    coinValue = 50;
                    break;
                case 3:
                    coinValue = 100;
                    break;
                case 4:
                    coinValue = 500;
                    break;
            }
            if(coinValue > 0) {
                if (player.CashBalance >= coinValue) {
                    returnValue = coinValue;
                } else {
                    MyMessages.MissingCoin(coinValue);
                }
            } else {
                MyMessages.TryAgain();
            }
            player.CashBalance -= returnValue;
            return returnValue;
        }
    }
}
