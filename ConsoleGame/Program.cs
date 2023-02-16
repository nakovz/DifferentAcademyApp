using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame {
    class Program {
        static void Main(string[] args) {
            //var myStore = new Store { Name = "Different Academy" };
            //myStore.WellcomeScreen();

            //MainMenu.MenuWithDetailPage("Different Academy", "G", MainMenu.Init().ToArray());

            ////exercise with using interfaces
            //List<IItemsForSale> menuList = MainMenu.Init();
            //MainMenu.MenuWithDetailPage("Different Academy", "G", menuList.ToArray());

            //This is my one-line comment (: 

            var context = new DmsEntities();
            var address = new Address {
                Street = "Test Street",
                Number = "Test Number",
                PostalCode = "Test PostalCode",
                City = "Test City",
                State = "Test State",
                Province = "Test Province",
                Country = "Test Country",
                IsActive = 1,
                IsDeleted = 0
            };
            context.Addresses.Add(address);
            context.SaveChanges();
        }
    }
}
