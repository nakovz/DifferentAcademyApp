using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame {
    class CardProcessor {
        internal static bool Paying(MyPerson player, Games game) {
            bool returnValue = false;
            bool inputCardInfoAgain = true;
            string textMessage = "";
            while (inputCardInfoAgain) {
                Console.Clear();
                Console.WriteLine("Wellcome to Different Academy games store!\n");
                Console.Write($"You want to buy * { game.GameName } * game ");
                Console.WriteLine($"and it will cost You { game.GamePrice } MKD!\n");
                Console.Write("Card holder name:");
                string cardHolderName = Console.ReadLine();
                Console.Write("Card number:");
                string cardNumber = Console.ReadLine();
                Console.Write("Card CCV2:");
                string cardCCV2 = Console.ReadLine();
                Console.Write("Card valid due (GGGGMM):");
                string cardValidGGGGMM = Console.ReadLine();

                if (cardNumber.Replace(" ","") == player.CardNumber.Replace(" ","") && cardCCV2 == player.CardCCV2.ToString()) {
                    if(cardValidGGGGMM == player.CardValidGGGGMM.ToString()) {
                        if(player.CardBalance >= game.GamePrice) {
                            returnValue = true;
                            inputCardInfoAgain = false;
                        } else {
                            textMessage = "\nSorry, please check your card balance!\n";
                            returnValue = false;
                            inputCardInfoAgain = false;
                        }
                    } else {
                        Console.WriteLine("\nInvalid Expiration date!");
                        inputCardInfoAgain = MyMessages.TryAgainYesNo();
                    }
                } else {
                    Console.WriteLine("\nYou have entered incorect card info!");
                    inputCardInfoAgain = MyMessages.TryAgainYesNo();
                }
            }
            Console.Clear();
            Console.WriteLine("Wellcome to Different Academy games store!");
            if (returnValue) {
                player.CardBalance -= game.GamePrice;
                Console.WriteLine($"\nSuccessful payment!\n");
            } else {
                Console.WriteLine($"{ textMessage }\nUnsuccessful payment!\n");
            }
            MyMessages.PressAnyKeyTo("proceed");
            return returnValue;
        }
    }
}
