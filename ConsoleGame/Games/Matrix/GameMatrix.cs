using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame {
    class GameMatrix : IItemsForSale {
        public string Name { get; set; }
        public string Status { get; set; } = "Buy";
        public string Description { get; } = "Some fun matrix calculation!";
        public int Price { get; set; } = 10;
        public string Currency { get; set; } = "EUR";
        public int Rating { get; set; } = 1;
        public void Execute() {
            do {
                MyUserInputType userAnswer = new MyUserInputType();

                Console.Clear();
                Console.WriteLine("*** Let's draw some magical matrix ***\n");

                userAnswer = MyUserInput.NumberOnly("Please enter column number:", true);
                int columnNumber = userAnswer.IntegerValue;
                userAnswer = MyUserInput.NumberOnly("Please enter column step:");
                int columnStep = userAnswer.IntegerValue;
                userAnswer = MyUserInput.NumberOnly("Please enter row number:", true);
                int rowNumber = userAnswer.IntegerValue;
                userAnswer = MyUserInput.NumberOnly("Please enter row step:");
                int rowStep = userAnswer.IntegerValue;

                int paddingSpace = ((columnNumber - 1) * columnStep + (rowNumber - 1) * rowStep).ToString().Length;
                string verticalLine = " | ";
                char horizontalLine = '-';

                Console.WriteLine(horizontalLine.ToString().PadRight(columnNumber * (paddingSpace + verticalLine.Length), horizontalLine));
                for (int rows = 0; rows < rowNumber; rows++) {
                    int printNumber = rows * rowStep - columnStep;
                    Console.Write(verticalLine.Trim());
                    for (int columns = 0; columns < columnNumber; columns++) {
                        printNumber += columnStep;
                        Console.Write(printNumber.ToString().PadLeft(paddingSpace) + verticalLine);
                    }
                    Console.WriteLine("\n" + horizontalLine.ToString().PadRight(columnNumber * (paddingSpace + verticalLine.Length), horizontalLine));
                }
            } while (MyMessages.DoYouWantYesNo("to play again?"));
        }
        public static void Play() {
            do {
                MyUserInputType userAnswer = new MyUserInputType();

                Console.Clear();
                Console.WriteLine("*** Let's draw some magical matrix ***\n");

                userAnswer = MyUserInput.NumberOnly("Please enter column number:", true);
                int columnNumber = userAnswer.IntegerValue;
                userAnswer = MyUserInput.NumberOnly("Please enter column step:");
                int columnStep = userAnswer.IntegerValue;
                userAnswer = MyUserInput.NumberOnly("Please enter row number:", true);
                int rowNumber = userAnswer.IntegerValue;
                userAnswer = MyUserInput.NumberOnly("Please enter row step:");
                int rowStep = userAnswer.IntegerValue;

                int paddingSpace = ((columnNumber - 1) * columnStep + (rowNumber - 1) * rowStep).ToString().Length;
                string verticalLine = " | ";
                char horizontalLine = '-';

                Console.WriteLine(horizontalLine.ToString().PadRight(columnNumber * (paddingSpace + verticalLine.Length), horizontalLine));
                for (int rows = 0; rows < rowNumber; rows++) {
                    int printNumber = rows * rowStep - columnStep;
                    Console.Write(verticalLine.Trim());
                    for (int columns = 0; columns < columnNumber; columns++) {
                        printNumber += columnStep;
                        Console.Write(printNumber.ToString().PadLeft(paddingSpace) + verticalLine);
                    }
                    Console.WriteLine("\n" + horizontalLine.ToString().PadRight(columnNumber * (paddingSpace + verticalLine.Length), horizontalLine));
                }
            } while (MyMessages.DoYouWantYesNo("to play again?"));
        }
    }
}
