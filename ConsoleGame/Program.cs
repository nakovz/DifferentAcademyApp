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

            //Only a little comment from Ljupka Ilieska. Have a good day and night! 

            // Test with implementing of an interface
            List<IItemsForSale> menuList = MainMenu.Init();
            MainMenu.MenuWithDetailPage("Different Accademy", "G", menuList.ToArray());
        }
    }
}
