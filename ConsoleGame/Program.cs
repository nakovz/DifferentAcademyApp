using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame {
    class Program {
        static void Main(string[] args) {
            var myStore = new Store { Name = "Different Academy" };
            myStore.WellcomeScreen();

            ////exercise with using interfaces
            //List<IItemsForSale> menuList = MainMenu.Init();
            //MainMenu.MenuWithDetailPage("Different Academy", "G", menuList.ToArray());

            //This is my one-line comment (: 
        }
    }
}
