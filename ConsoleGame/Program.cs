using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame {
    class Program {
        static void Main(string[] args) {
            //var myStore = new Store { Name = "Different Accademy" };
            //myStore.WellcomeScreen();

            // Test with implementing of an interface
            List<IItemsForSale> menuList = MainMenu.Init();
            MainMenu.MenuWithDetailPage("Different Accademy", "G", menuList.ToArray());
        }
    }
}
