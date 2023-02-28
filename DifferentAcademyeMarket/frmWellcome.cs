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
    public partial class frmWellcome : Form {
        public Store MyStore { get; set; }
        public frmWellcome() {
            InitializeComponent();
            MyStore = new Store();
        }

        private void frmWellcome_Load(object sender, EventArgs e) {
            dgvStores.AutoGenerateColumns = false;
            dgvStores.DataSource = DbHelper.GetAllStores();

        }

        private void dgvStores_SelectionChanged(object sender, EventArgs e) {
            if (dgvStores.SelectedRows.Count > 0) {
                MyStore = (Store)dgvStores.SelectedRows[0].DataBoundItem;
                lblStoreName.Text = MyStore.Name;
                lblSlogan.Text = MyStore.Slogan;
            }
        }

        private void btnEnter_Click(object sender, EventArgs e) {
            EnterInTheStore();
        }

        private void dgvStores_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                e.IsInputKey = true;
                EnterInTheStore();
            }
        }

        private void EnterInTheStore() {
            if (MyStore.StoreID == 0) {
                MessageBox.Show("Please select your store!", "Select eStore", MessageBoxButtons.OK);
            } else {
                this.Hide();
                var frmLogIn = new frmLogIn(MyStore);
                frmLogIn.ShowDialog();
                frmLogIn = null;
                this.Show();
            }
        }
    }
}
