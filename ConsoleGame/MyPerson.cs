using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame {
    public class MyPerson {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PersonId { get; set; }
        public string  Phone { get; set; }
        public int AccountType { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string UserPassword { get; set; }
        public string CardNumber { get; set; }
        public int CardCCV2 { get; set; }
        public int CardValidGGGGMM { get; set; }
        public int CardBalance { get; set; }
        public int CashBalance { get; set; }
        public int CreditBalance { get; set; }

        public MyPerson() {
            CashBalance = 1000;
            CardBalance = 1000;
            CreditBalance = 200;
        }

        public void UserInformationPage(List<Games> games) {
            var userAnswer = new MyUserInputType { ExitAnswer = false };
            while (userAnswer.ExitAnswer == false) {
                Console.Clear();
                List<string> text = new List<string>();
                var textWidth = Console.WindowWidth / 2;
                text.Add($"\nusername: { Email }");
                text.Add($"    Name: { Name }");
                text.Add($"     DOB: { DateOfBirth.ToShortDateString()  }");
                text.Add($"  Gender: { Gender }\n");
                text.Add($"Credit Balance: { CreditBalance.ToString() }\n");
                var numberOfPurchasedGames = games.Count(game => game.GameStatus.ToLower() == "play");
                if (numberOfPurchasedGames > 0) {
                    text.Add($"Games List:");
                    foreach (var game in games) {
                        if (game.GameStatus.ToLower() == "play") {
                            text.Add($"{ game.GameName } (purchesed on: { game.GameDateTimeOfBuying.Substring(0, 10) })");
                        }
                    }
                    text[text.Count - 1] += "\n";
                }
                text.ForEach(t => Console.WriteLine(t));
                userAnswer = UserInformationPageMenu(games);
            }
        }

        private MyUserInputType UserInformationPageMenu(List<Games> games) {
            List<string> text = new List<string>();
            var isEmptyGameList = games.Count(game => game.GameStatus.ToLower() == "play") == 0;
            text.Add("-");
            text.Add("Update your data");
            text.Add("Reset password");
            text.Add("-");
            if (isEmptyGameList == false) {
                text.Add("Sell your games");
            }
            text.Add("Back to Main Menu");
            var userAnswer = MyUserInput.ChooseFromMenu("", "\nPlease enter your choice:", "x", text.ToArray());
            var sellingGameIndex = text.Count - 4;
            if (userAnswer.ExitAnswer == false) {
                switch (userAnswer.IntegerValue) {
                    case 1:
                        UpdatePersonData();
                        break;
                    case 2:
                        ResetUserPassword();
                        break;
                }
                if (userAnswer.IntegerValue == sellingGameIndex && isEmptyGameList == false) {
                    SellingGame(games);
                }
            }
            return userAnswer;
        }

        private void UpdatePersonData() {
            bool startOverAgain = false;
            while (startOverAgain == false) {
                var nameTemp = Name;
                var dobTemp = DateOfBirth;
                var genderTemp = Gender;
                Console.Clear();
                Console.WriteLine("UPDATE YOUR DATA\n");
                Console.Write("Please enter Your name:");
                nameTemp = Console.ReadLine();
                Console.Write("Please enter Your date of birth:");
                dobTemp = Convert.ToDateTime(Console.ReadLine());
                //var userAnswer = new MyUserInputType { ExitAnswer = false };
                var userAnswer = MyUserInput.ChooseFromMenu("Gender info", "please enter option:", "x", "-", "Female", "Male", "-", "I don't want to answer!");
                if (userAnswer.ExitAnswer == false) {
                    genderTemp = userAnswer.IntegerValue == 1
                        ? "Female"
                        : "Male";
                }
                startOverAgain = MyMessages.QuestionYesNo("\nDo you want to save this information?");
                if (startOverAgain) {
                    Name = nameTemp;
                    DateOfBirth = dobTemp;
                    Gender = genderTemp;
                }
            }

        }

        private void ResetUserPassword() {
            var startOverAgain = true;
            while (startOverAgain) {
                Console.Clear();
                Console.Write("RESETING PASSWORD\n\nCurrent password:");
                var currentPassword = MyConsole.ReadLineInputMask('*');
                if (UserPassword != currentPassword) {
                    Console.WriteLine("\nInvalid password!");
                    startOverAgain = MyMessages.QuestionYesNo("Do you want to try again?");
                } else {
                    Console.Write("new password:");
                    var newPassword = MyConsole.ReadLineInputMask('*');
                    Console.Write("confirm password:");
                    var confirmPassword = MyConsole.ReadLineInputMask('*');
                    if (newPassword != confirmPassword) {
                        Console.WriteLine("\nYour password don't match!!");
                        startOverAgain = MyMessages.QuestionYesNo("Do you want to try again?");
                    } else {
                        UserPassword = newPassword;
                        Console.WriteLine("Succesfully reset password!");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadLine();
                        startOverAgain = false;
                    }
                }
            }
        }

        private void SellingGame(List<Games> games) {
            throw new NotImplementedException();
        }

        public string UserBalanceInfo() {
            return $"username: { Email }\nCredit Balance: { CreditBalance }";
        }
        public static MyPerson Init() {
            MyPerson player = new MyPerson {
                Name = "John Doe",
                CardNumber = "1234 1234 1234 1234",
                CardCCV2 = 123,
                CardValidGGGGMM = 202405,
                CardBalance = 2000,
                CashBalance = 1000
            };
            return player;
        }
        public void PrintWalletInfo() {
            Console.WriteLine($"{ ("-").PadRight(12, '-') } Wallet info { ("-").PadRight(12, '-') }");
            Console.WriteLine($"Card holder name: { this.Name }");
            Console.WriteLine($"     Card number: { this.CardNumber }");
            Console.WriteLine($"      Valid thru: { this.CardValidGGGGMM }");
            Console.WriteLine($"            CCV2: { this.CardCCV2 }");
            Console.WriteLine($"    Card Balance: { this.CardBalance } MKD\n");
            Console.WriteLine($"    Cash Balance: { this.CashBalance } MKD");
            Console.WriteLine($"  Credit Balance: { this.CreditBalance } MKD");
            Console.WriteLine($"{ ("-").PadRight(37, '-') }\n");
        }

    }
}