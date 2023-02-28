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
    public partial class frmStoreAdministration : Form {
        public Store MyStore { get; set; }

        public frmStoreAdministration() {
            InitializeComponent();
            InitDataGridView();
        }

        private void InitDataGridView() {
            dgvItems.AutoGenerateColumns = false;
            dgvItems.DefaultCellStyle.SelectionBackColor = dgvItems.DefaultCellStyle.BackColor;
            dgvItems.DefaultCellStyle.SelectionForeColor = dgvItems.DefaultCellStyle.ForeColor;
        }

        public frmStoreAdministration(Store store) : this()  {
            MyStore = store;
            txtStoreName.Text = store.Name;
            txtSlogan.Text = store.Slogan;
            txtSuperUser.Text = store.SuperUser;
            txtSuperPassword.Text = store.SuperPassword;
            txtConfirmPassword.Text = "";
            Text = $"{ MyStore.Name } - { MyStore.Slogan }";
            LoadStoreItems(MyStore);
        }

        private void LoadStoreItems(Store store) {
            var itemList = DbHelper.GetAllItemsInStore(store);
            var items= itemList.Select(item => new ItemInGridView(item)).ToList();
            dgvItems.DataSource = items;
        }

        private void btnBrowse_Click(object sender, EventArgs e) {
            using (var openFileDialog = new OpenFileDialog() { Filter="Image Files(*.BMP;*.JPG;*.PNG)| *.BMP;*.JPG;*.PNG"}) {
                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    picItemIcon.ImageLocation = openFileDialog.FileName;
                }
            }
        }

        private void btnNewItem_Click(object sender, EventArgs e) {
            ClearItemTextBoxes();
            ActiveControl = txtName;
            btnSaveItem.Text = "Save Item";
        }

        private void ClearItemTextBoxes() {
            txtItemID.Text = "0";
            txtName.Text = "";
            txtPrice.Text = "";
            txtDescription.Text = "";
            picItemIcon.ImageLocation = "";
        }

        private void btnSaveItem_Click(object sender, EventArgs e) {
            var newItem = new Items() {
                ItemID = Convert.ToInt32(txtItemID.Text),
                Name = txtName.Text,
                Price = Convert.ToInt32(txtPrice.Text),
                Description = txtDescription.Text,
                imageUrl = picItemIcon.ImageLocation,
                StoreId = MyStore.StoreID
            };
            DbHelper.SaveItem(newItem);
            LoadStoreItems(MyStore);

            var rowByItemID = dgvItems.Rows.Cast<DataGridViewRow>().FirstOrDefault(r => r.Cells[0].Value?.ToString() == newItem.ItemID.ToString());
            if (rowByItemID != null) {
                rowByItemID.Selected = true;
                dgvItems.CurrentCell = rowByItemID.Cells[0];

            }
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
                ActiveControl = txtName;
                btnSaveItem.Text = "Update Item";
            }
        }

        private void btnUpdateStoreInfo_Click(object sender, EventArgs e) {
            MyStore.Name = txtStoreName.Text;
            MyStore.Slogan = txtSlogan.Text;
            MyStore.SuperUser = txtSuperUser.Text;
            MyStore.SuperPassword = txtSuperPassword.Text;
            DbHelper.SaveStore(MyStore);
            MessageBox.Show("Information for the store is succesfuly updated!","Store Info",MessageBoxButtons.OK);
            Text = $"{ MyStore.Name } - { MyStore.Slogan }";
        }

        private void button1_Click(object sender, EventArgs e) {
            if (txtConfirmPassword.Text == MyStore.SuperPassword) {
                txtSuperPassword.Enabled = true;
                txtConfirmPassword.Text = "";
                ActiveControl = txtSuperPassword;
            } else {
                MessageBox.Show("Invalid password!\n\nPlease input correct password!", "Invalid password!", MessageBoxButtons.OK);
                ActiveControl = txtConfirmPassword;
            }
        }

        private void txtSuperPassword_Validated(object sender, EventArgs e) {
            txtSuperPassword.Enabled = false;
        }

        private void txtStoreName_KeyDown(object sender, KeyEventArgs e) {
            FormHelper.SelectNextControlOnEnter(this, sender, e);
        }

        private void txtSlogan_KeyDown(object sender, KeyEventArgs e) {
            FormHelper.SelectNextControlOnEnter(this, sender, e);
        }

        private void txtSuperUser_KeyDown(object sender, KeyEventArgs e) {
            FormHelper.SelectNextControlOnEnter(this, sender, e);
        }

        private void txtConfirmPassword_KeyDown(object sender, KeyEventArgs e) {
            FormHelper.SelectNextControlOnEnter(this, sender, e);
        }

        private void txtSuperPassword_KeyDown(object sender, KeyEventArgs e) {
            FormHelper.SelectNextControlOnEnter(this, sender, e);
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e) {
            FormHelper.SelectNextControlOnEnter(this, sender, e);
        }

        private void txtPrice_KeyDown(object sender, KeyEventArgs e) {
            FormHelper.SelectNextControlOnEnter(this, sender, e);
        }

        private void txtDescription_KeyDown(object sender, KeyEventArgs e) {
            FormHelper.SelectNextControlOnEnter(this, sender, e);
        }
    }
}
