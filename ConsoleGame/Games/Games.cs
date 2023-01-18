using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame {
    public class Games {
        public string GameName { get; set; }
        public string GameStatus { get; set; }
        public int GamePrice { get; set; }
        public string GameDateTimeOfBuying { get; set; }

        public void Play() {
            switch (this.GameName) {
                case "Pyramid":
                    GamePyramid.Play();
                    break;
                case "Matrix":
                    GameMatrix.Play();
                    break;
                case "Guess My Number":
                    GameGuessMyNumber.Play();
                    break;
                case "Hanoi Tower":
                    GameHanioTower.Play();
                    break;
                case "Mind Reader":
                    GameMindReader.Play();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine($"\n\nPlaying { this.GameName }\n\n");
                    MyMessages.PressAnyKeyTo("return on Main menu");
                    break;
            }
        }

        public static List<Games> InitGames() {
            return new List<Games> {
                new Games {
                    GameName = "Pyramid",
                    GameStatus = "Buy",
                    GamePrice = 110,
                    GameDateTimeOfBuying = ""
                },
                new Games {
                    GameName = "Matrix",
                    GameStatus = "Buy",
                    GamePrice = 140,
                    GameDateTimeOfBuying = ""
                },
                new Games {
                    GameName = "Guess My Number",
                    GameStatus = "Buy",
                    GamePrice = 60,
                    GameDateTimeOfBuying = ""
                },
                new Games {
                    GameName = "Hanoi Tower",
                    GameStatus = "Buy",
                    GamePrice = 30,
                    GameDateTimeOfBuying = ""
                },
                new Games {
                    GameName = "Mind Reader",
                    GameStatus = "Buy",
                    GamePrice = 120,
                    GameDateTimeOfBuying = ""
                }
            };
        }
    }
}
