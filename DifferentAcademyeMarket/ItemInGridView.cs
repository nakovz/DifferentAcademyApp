using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DifferentAcademyeMarket {
    class ItemInGridView {
        public int ItemID { get; set; }
        public Image imageUrl { get; set; }
        public string ItemInfo { get; set; }

        public ItemInGridView() {

        }
        public ItemInGridView(Items item) {
            ItemID = item.ItemID;
            imageUrl = Image.FromFile(item.imageUrl);
            ItemInfo = $"{ item.Name }\n\n{ item.Description }\nCredit: { item.Price }";
        }

    }
}
