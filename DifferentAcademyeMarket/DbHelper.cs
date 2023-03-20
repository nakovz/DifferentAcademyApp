using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DifferentAcademyeMarket {
    public class DbHelper {
        public static bool isEmailAlreadyRegistered(int storeId, string email) {
            using (var context = new DAeMarketEntities()) {
                var userWithThisEmail = context.Users.FirstOrDefault(u => u.StoreID == storeId && u.email == email);
                if (userWithThisEmail == null) {
                    return false;
                } else {
                    userWithThisEmail = null;
                    return true;
                }
            }
        }

        public static List<Store> GetAllStores() {
            using (var context = new DAeMarketEntities()) {
                return context.Store.OrderBy(store => store.StoreID).ToList();
            }
        }

        public static Store GetStoreByID(int storeID) {
            using (var context = new DAeMarketEntities()) {
                return context.Store.FirstOrDefault(s => s.StoreID == storeID);
            }
        }

        internal static List<Items> GetAllItemsInStore(Store myStore) {
            using (var context = new DAeMarketEntities()) {
                return context.Items.Where(i => i.StoreId == myStore.StoreID).ToList();
            }
        }

        internal static List<Items> GetItemsInStorePerUser(Store myStore, Users user) {
            using (var context = new DAeMarketEntities()) {
                return (from items in context.Items
                        join users in context.ItemsPerUser on items.ItemID equals users.ItemId
                        where users.UserId == user.UserId
                        select items).ToList();
            }
        }

        public static Users GetUserByEmailAndPassword(int storeId, string email, string password) {
            using (var context = new DAeMarketEntities()) {
                return context.Users.FirstOrDefault(u => (u.StoreID==storeId && u.email == email && u.password == password));
            }
        }

        internal static void CreateNewUser(Users newUser) {
            using (var context = new DAeMarketEntities()) {
                context.Users.Add(newUser);
                context.SaveChanges();
            }
        }

        internal static void SaveItem(Items newItem) {
            using (var context = new DAeMarketEntities()) {
                if (context.Entry(newItem).State == EntityState.Detached) {
                    context.Set<Items>().Attach(newItem);
                }
                context.Entry(newItem).State = newItem.ItemID == 0 ? EntityState.Added : EntityState.Modified;
                context.SaveChanges();
            }
        }

        internal static Items GetItemInfoByStoreIdAndItemId(int storeID, int itemID) {
            using (var context = new DAeMarketEntities()) {
                return context.Items.FirstOrDefault(i => i.StoreId == storeID && i.ItemID == itemID);
            }
        }

        internal static ItemsPerUser GetItemPerUserInfo(int storeID, int userId, int selectedItemId) {
            using (var context = new DAeMarketEntities()) {
                return (from itemperuser in context.ItemsPerUser
                        where (itemperuser.StoreId == storeID &&
                                itemperuser.UserId == userId &&
                                itemperuser.ItemId == selectedItemId)
                        select itemperuser).FirstOrDefault();
            }
        }

        internal static void SaveStore(Store store2update) {
            using (var context = new DAeMarketEntities()) {
                if (context.Entry(store2update).State == EntityState.Detached) {
                    context.Set<Store>().Attach(store2update);
                }
                context.Entry(store2update).State = store2update.StoreID == 0 ? EntityState.Added : EntityState.Modified;
                context.SaveChanges();
            }
        }

        internal static void BuyItemFromStore(int storeID, int userId, int itemID) {
            using (var context = new DAeMarketEntities()) {
                var user = context.Users.FirstOrDefault(u => u.StoreID == storeID && u.UserId == userId);
                var item = context.Items.FirstOrDefault(i => i.StoreId == storeID && i.ItemID == itemID);

                if (user.Credit >= item.Price) {
                    user.Credit -= item.Price;
                    if (context.Entry(user).State == EntityState.Detached) {
                        context.Set<Users>().Attach(user);
                    }
                    context.Entry(user).State = EntityState.Modified;

                    var itemPerUser = new ItemsPerUser {
                        DateTimeOfBuying = DateTime.Now,
                        StoreId = storeID,
                        UserId = userId,
                        ItemId = itemID
                    };
                    context.ItemsPerUser.Add(itemPerUser);

                    context.SaveChanges();
                }
            }
        }
    }
}
