using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame {
    class MainMenu {

        public static void MenuWithDetailPage(string headerText, string footerText, params IItemsForSale[] items) {
            Console.CursorVisible = false;
            var startOverAgain = true;
            var selectedItem = 0;
            while (startOverAgain) {
                Console.Clear();
                Console.WriteLine(headerText + "\n");
                ConsoleWriteItems(selectedItem, items);
                Console.WriteLine("\nUp/Down Arrows - move across the menu\nEnter - Select the item\nEsc - Exit");
                ConsoleWriteItemDescription(items.ElementAt(selectedItem));
                var userKeyPress = Console.ReadKey(true).Key;
                switch (userKeyPress) {
                    case ConsoleKey.DownArrow:
                        selectedItem = GetNewSelectedItem(selectedItem, 1, items);
                        break;
                    case ConsoleKey.UpArrow:
                        selectedItem = GetNewSelectedItem(selectedItem, -1, items);
                        break;
                    case ConsoleKey.Enter:
                        items.ElementAt(selectedItem).Execute();
                        break;
                    case ConsoleKey.Escape:
                        startOverAgain = false;
                        break;
                }
            }
            Console.CursorVisible = true;
        }

        private static void ConsoleWriteItemDescription(IItemsForSale itemsForSale) {
            var detailPageWidth = Console.WindowWidth / 2 - 2;
            var xPosition = Console.WindowWidth / 2 + 1;
            var yPosition = 1;
            var textWidth = detailPageWidth - 4;
            MyConsole.WriteAt(xPosition, yPosition++, "*".PadRight(detailPageWidth, '*'));
            MyConsole.WriteAt(xPosition, yPosition++, $"* { MyConsole.AlignCenter(itemsForSale.Name, textWidth) } *");
            MyConsole.WriteAt(xPosition, yPosition++, "*".PadRight(detailPageWidth, '*'));
            string[] lines = MyConsole.WordWrap(itemsForSale.Description, textWidth);
            foreach (var line in lines) {
                MyConsole.WriteAt(xPosition, yPosition++, $"* { MyConsole.AlignLeft(line,textWidth) } *");
            }
            MyConsole.WriteAt(xPosition, yPosition++, $"* { " ".PadRight(textWidth) } *");
            var ratingText = itemsForSale.Rating > 0
                ? MyConsole.AlignRight("Rating: " + itemsForSale.Rating.ToString() + " Stars ", textWidth / 2)
                : MyConsole.AlignRight("", textWidth / 2);
            var priceText = itemsForSale.Price > 0
                ? MyConsole.AlignLeft("Price: " + itemsForSale.Price.ToString() + " " + itemsForSale.Currency, textWidth / 2)
                : MyConsole.AlignLeft("", textWidth / 2);
            MyConsole.WriteAt(xPosition, yPosition++, $"* { priceText + ratingText } *");
            MyConsole.WriteAt(xPosition, yPosition, "*".PadRight(detailPageWidth, '*'));
        }

        private static int GetNewSelectedItem(int selectedItem, int step, params IItemsForSale[] items) {
            selectedItem = Math.Min(Math.Max(selectedItem + step, 0),items.Length-1);
            if (items.ElementAt(selectedItem).Name == "-") { selectedItem = GetNewSelectedItem(selectedItem, step, items); }
            return selectedItem;
        }
        private static void ConsoleWriteItems(int selectedItem, params IItemsForSale[] items) {
            var itemIndex = 0;
            var paddingSeparator = items.Max(item => item.Name.Length) + 3;
            foreach (var item in items) {
                var backColor = Console.BackgroundColor;
                var foreColor = Console.ForegroundColor;
                if (itemIndex == selectedItem) {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.WriteLine(item.Name == "-"
                    ? "-".PadRight(paddingSeparator, '-')
                    : $"♦ { item.Name }");
                itemIndex++;
                Console.BackgroundColor = backColor;
                Console.ForegroundColor = foreColor;
            }
        }
        public static List<IItemsForSale> Init() {
            return new List<IItemsForSale> {
                new GamePyramid {
                    ItemId=1,
                    Name="Pyramid"
                },
                new GameMatrix {
                    ItemId=2,
                    Name="Matrix"
                },
                new GameGuessMyNumber {
                    ItemId=3,
                    Name="Guess My Number"
                },
                new GameHanioTower {
                    ItemId=4,
                    Name="Hanoi Tower"
                },
                new GameMindReader {
                    ItemId=5,
                    Name="Mind Reader"
                },
                new SpecialMenuElement {
                    ItemId=0,
                    Name="-"
                },
                new SpecialMenuElement {
                    ItemId=0,
                    Name="User Info",
                    Description="Here you will find information about your account.\n\nCredit Balance\nReset a password.\nAnd much more..."
                }
            };
        }

        public static void ShowMenu(Store store, MyPerson player) {
            List<Games> listOfGames = Games.InitGames();

            bool startOverAgain = true;
            while (startOverAgain) {
                MyUserInputType userAnswer = MainMenuAnswer(store, player, listOfGames);
                if (userAnswer.ExitAnswer) {
                    store.LogedInUsers.Remove(player);
                    Console.WriteLine("Thank you for playing our games!");
                    startOverAgain = false;
                } else {
                    int gameIndex = ListIndexFromMenuOptionValue(userAnswer.IntegerValue);
                    if (gameIndex < listOfGames.Count) {
                        BuyOrPlay(player, listOfGames.ElementAt(gameIndex));
                    } else {
                        if (gameIndex == listOfGames.Count) {
                            Console.Clear();
                            player.UserInformationPage(listOfGames);
                        }
                    }
                }
            }
        }

        private static int ListIndexFromMenuOptionValue(int menuOptionValue) {
            return menuOptionValue - 1;
        }

        private static MyUserInputType MainMenuAnswer(Store store, MyPerson player, List<Games> games) {
            Console.Clear();
            Console.WriteLine($"Wellcome to { store.Name } store!\n\n");
            var optionText = new List<string>();
            optionText.Add("-");
            foreach (var game in games) {
                optionText.Add(game.GameName.ToString().PadRight(25) + 
                    (game.GameStatus.ToLower() == "buy" 
                    ? "Buy (" + game.GamePrice + " MKD)" 
                    : "Play\t\tpurchesed:" + game.GameDateTimeOfBuying));
            }
            optionText.Add("-");
            optionText.Add("User Information");
            optionText.Add("LogOut");
            return MyUserInput.ChooseFromMenu($"    { ("list of games").PadRight(28) }action", "\nSelect an option: ", "x", optionText.ToArray());
        }

        private static void BuyOrPlay(MyPerson player, Games game) {
            switch (game.GameStatus) {
                case "Buy":
                    Store.Buy(player, game);
                    break;
                case "Play":
                    game.Play();
                    break;
            }
        }
    }
}
