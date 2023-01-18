using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame {
    class SpecialMenuElement : IItemsForSale {

        public string Name { get; set; }
        public string Status { get; set; } = "Buy";
        public string Description { get; set; } = "";
        public int Price { get; set; } = 0;
        public string Currency { get; set; } = "";
        public int Rating { get; set; } = 0;

        public void Execute() { }
    }
}
