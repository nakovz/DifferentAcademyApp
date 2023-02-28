using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DifferentAcademyeMarket {
    public partial class frmStore : Form {
        public Store MyStore { get; set; }
        public Users User { get; set; }
        public frmStore() {
            InitializeComponent();
            InitDataGridView();
        }

        public frmStore(Store store, Users user) : this() {
            MyStore = store;
            User = user;
            Text = $"{ MyStore.Name } - { MyStore.Slogan }";
            lblUserName.Text = $"{ user.FirstName } { user.LastName }";
            lblUserEmail.Text = $"{ user.email }";
            LoadCreditBalance(store, user);
            LoadStoreItems(MyStore, User);
        }

        private void InitDataGridView() {
            dgvItems.AutoGenerateColumns = false;
            dgvItems.DefaultCellStyle.SelectionBackColor = dgvItems.DefaultCellStyle.BackColor;
            dgvItems.DefaultCellStyle.SelectionForeColor = dgvItems.DefaultCellStyle.ForeColor;
        }

        private void LoadCreditBalance(Store store, Users user) {
            var loadUserInfo = DbHelper.GetUserByEmailAndPassword(store.StoreID, user.email, user.password);
            lblCreditBalance.Text = $"Credit: { loadUserInfo.Credit }";
        }

        private void LoadStoreItems(Store store, Users user) {
            var itemList = new List<Items>();
            if (rbtnAllItems.Checked) {
                itemList = DbHelper.GetAllItemsInStore(store);
            } else if (rbtnMyItems.Checked) { 
                itemList = DbHelper.GetItemsInStorePerUser(store, user);
            }
            var items = itemList.Select(item => new ItemInGridView(item)).ToList();
            dgvItems.DataSource = items;
            dgvItems.Refresh();
        }

        private void rbtnAllItems_CheckedChanged(object sender, EventArgs e) {
            LoadStoreItems(MyStore, User);
        }

        private void btnLogOut_Click(object sender, EventArgs e) {
            Dispose();
        }

        private void dgvItems_SelectionChanged(object sender, EventArgs e) {
            if (dgvItems.SelectedRows.Count > 0) {
                var selectedItemId = Convert.ToInt32(dgvItems.SelectedRows[0].Cells[0].Value.ToString());
                var selectedItem = DbHelper.GetItemInfoByStoreIdAndItemId(MyStore.StoreID, selectedItemId);
                txtItemID.Text = selectedItem.ItemID.ToString();
                txtName.Text = selectedItem.Name;
                txtPrice.Text = selectedItem.Price.ToString();
                txtDescription.Text = selectedItem.Description;
                picItemIcon.ImageLocation = selectedItem.imageUrl;

                LoadItemInfoPerUser(MyStore.StoreID, User.UserId, selectedItemId);
            }
        }

        private void LoadItemInfoPerUser(int storeID, int userId, int selectedItemId) {
            var itemInfoPerUser = DbHelper.GetItemPerUserInfo(MyStore.StoreID, User.UserId, selectedItemId);
            if (itemInfoPerUser != null) {
                btnBuy.Visible = false;
                btnSell.Visible = true;
                btnPlay.Visible = true;
                lblPurchased.Visible = true;
                txtPurchased.Text = itemInfoPerUser.DateTimeOfBuying.ToString();
                txtPurchased.Visible = true;
            } else {
                btnBuy.Visible = true;
                btnSell.Visible = false;
                btnPlay.Visible = false;
                lblPurchased.Visible = false;
                txtPurchased.Visible = false;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e) {
            MessageBox.Show($"Playing { txtName.Text }!", "Playing", MessageBoxButtons.OK);
        }

        private void btnBuy_Click(object sender, EventArgs e) {
            var selectedItemId = Convert.ToInt32(txtItemID.Text.ToString());
            if (User.Credit >= Convert.ToInt32(txtPrice.Text.ToString())) {
                if(MessageBox.Show($"Dou you really want to buy { txtName.Text }", "Buy", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    DbHelper.BuyItemFromStore(MyStore.StoreID, User.UserId, selectedItemId);
                    LoadCreditBalance(MyStore, User);
                    LoadItemInfoPerUser(MyStore.StoreID, User.UserId, selectedItemId);
                }
            } else {
                MessageBox.Show("You don't have enough credit!", "Buy Item", MessageBoxButtons.OK);
            }
        }

        private void btnSell_Click(object sender, EventArgs e) {
            MessageBox.Show($"Sell { txtName.Text }!", "Selling", MessageBoxButtons.OK);
        }
    }
}
