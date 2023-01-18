using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame {
    class MyConsole {
        public static string AlignCenter(string text, int width) {
            return text.PadLeft(width / 2 + text.Length / 2).PadRight(width);
        }
        public static string AlignLeft(string text, int width) {
            return text.PadRight(width);
        }
        public static string AlignRight(string text, int width) {
            return text.PadLeft(width);
        }
        public static void WriteAt(int x, int y, string text) {
            Console.SetCursorPosition(x, y);
            Console.Write(text);
        }
        public static void WriteMultipleLineInBox(int xPosition, int yPosition, int boxWidth, params string[] text) {
            var boxChar = '*';
            var paddingChar = " ";
            var textWidth = boxWidth - (boxChar.ToString().Length + paddingChar.Length) * 2;
            WriteAt(xPosition, yPosition++, boxChar.ToString().PadRight(boxWidth, boxChar));
            List<string> lines = new List<string>();
            foreach (var line in text) {
                lines.AddRange(WordWrap(line, textWidth));
            }
            foreach (var line in lines) {
                WriteAt(xPosition, yPosition++, boxChar + paddingChar + AlignLeft(line, textWidth) + paddingChar + boxChar);
            }
            WriteAt(xPosition, yPosition++, boxChar.ToString().PadRight(boxWidth, boxChar));
        }

        public static string ReadLineEmail(string text) {
            var returnValue = "";
            var startOverAgain = true;
            while (startOverAgain) {
                Console.Write(text);
                var userInput = Console.ReadLine();
                if (ValidEmailFormat(userInput)) {
                    returnValue = userInput;
                    startOverAgain = false;
                } else {
                    Console.WriteLine("You have entered invalid e-mail format! Please try again!");
                }
            }
            return returnValue;
        }

        private static bool ValidEmailFormat(string email) {
            try {
                MailAddress m = new MailAddress(email);
                return true;
            } catch (FormatException) {
                return false;
            }
        }

        public static string ReadLineInputMask(char maskCharacter) {
            var returnValue = "";
            while (true) {
                var keyPressed = Console.ReadKey(true);
                if (keyPressed.Key == ConsoleKey.Enter) {
                    Console.WriteLine("");
                    return returnValue;
                }
                if (keyPressed.Key == ConsoleKey.Backspace && returnValue.Length>0) {
                    Console.Write("\b \b");
                    returnValue = returnValue.Substring(0, returnValue.Length - 1);
                } else {
                    Console.Write(maskCharacter);
                    returnValue += keyPressed.KeyChar;
                }
            }
        }

        public static string[] WordWrap(string text, int width) {
            List<string> returnValue = new List<string>();
            string[] lines = text.Split(new string[] { "\n", Environment.NewLine }, StringSplitOptions.None);
            for (int i = 0; i < lines.Length; i++) {
                string process = lines[i];
                List<String> wrapped = new List<string>();

                while (process.Length > width) {
                    int wrapAt = process.LastIndexOf(' ', Math.Min(width - 1, process.Length));
                    if (wrapAt <= 0)
                        break;

                    wrapped.Add(process.Substring(0, wrapAt));
                    process = process.Remove(0, wrapAt + 1);
                }

                foreach (string wrap in wrapped) {
                    returnValue.Add(wrap);
                }

                returnValue.Add(process);
            }
            return returnValue.ToArray();
        }
    }
}
