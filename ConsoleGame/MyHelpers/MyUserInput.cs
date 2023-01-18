using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame {
    class MyUserInput {

        public static MyUserInputType NumberOnly(string myText, bool onlyPositiveNumber = false, string exitString = "", int maxInputNumber = 0) {
            MyUserInputType returnValue = new MyUserInputType {
                IntegerValue = 1,
                ExitAnswer = false
            };
            int returnNumber=1;
            bool validUserInput;

            do {
                validUserInput = true;
                Console.Write(myText);
                string userInput = Console.ReadLine();
                if (exitString.Length > 0 && userInput.ToLower() == exitString.ToLower()) {
                    validUserInput = true;
                    returnValue.ExitAnswer = true;
                } else { 
                    if (Int32.TryParse(userInput, out returnNumber) == false) {
                        Console.WriteLine("Please don't enter charcters, enter only numbers!" + (exitString.Length > 0 ? " (" + exitString + "-Exit) " : ""));
                        validUserInput = false;
                    }
                    if (validUserInput) {
                        if (returnNumber <= 0 && onlyPositiveNumber) {
                            Console.WriteLine("Please enter positive number!");
                            validUserInput = false;
                        }
                        if(returnNumber>maxInputNumber && maxInputNumber > 0) {
                            Console.WriteLine($"Please enter valid number smaller and equal than { maxInputNumber }!");
                            validUserInput = false;
                        }
                    }
                    returnValue.IntegerValue = returnNumber;
                }
            } while (validUserInput == false);

            return returnValue;
        }

        public static MyUserInputType ChooseFromMenu(string headerText, string footerText, string exitString, params string[] items) {
            int itemIndex = 0;
            int separatorCounter = 0;
            int exitStringItem = 1;
            int paddingSeparatorNumber = items.Max(item => item.Length) + 3;
            int paddingSpace = Math.Max(exitString.Length, items.Length.ToString().Length) + 1;
            if (headerText.Length > 0) {
                Console.WriteLine(headerText);
            }
            foreach (var item in items) {
                if (item == "-") {
                    Console.WriteLine(("-").PadRight(paddingSeparatorNumber + paddingSpace, '-'));
                    separatorCounter++;
                } else {
                    string positionNumber = ++itemIndex + separatorCounter == items.Length ? exitString.PadLeft(paddingSpace) : (itemIndex).ToString().PadLeft(paddingSpace);
                    Console.WriteLine(positionNumber + ") " + item.Trim());
                }
            }
            return MyUserInput.NumberOnly(footerText, true, exitString, items.Length - separatorCounter - exitStringItem);
        }

    }
}
