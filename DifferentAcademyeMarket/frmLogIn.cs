using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DifferentAcademyeMarket {
    public partial class frmLogIn : Form {
        private Store MyStore = new Store();
        private ErrorProvider errorProvider = new ErrorProvider();

        public frmLogIn() {
            InitializeComponent();
        }

        public frmLogIn(Store store) : this() {
            MyStore = store;
            this.Text = $"{MyStore.Name} - {MyStore.Slogan}";
            lblStoreName.Text = MyStore.Name;
            lblSlogan.Text = MyStore.Slogan;
        }
        private void btnCreateNewUser_Click(object sender, EventArgs e) {
            this.Hide();
            var newUserForm = new frmNewUser(MyStore);
            newUserForm.ShowDialog();
            newUserForm = null;
            this.Show();
            ActiveControl = txtEmail;
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e) {
            FormHelper.SelectNextControlOnEnter(this, sender, e);
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e) {
            FormHelper.SelectNextControlOnEnter(this, sender, e);
        }

        private void btnLogIn_Click(object sender, EventArgs e) {
            if (txtEmail.Text == MyStore.SuperUser && txtPassword.Text == MyStore.SuperPassword) {
                this.Hide();
                txtPassword.Text = "";
                var storeAdminForm = new frmStoreAdministration(MyStore);
                storeAdminForm.ShowDialog();
                storeAdminForm = null;
                this.Show();
                ActiveControl = txtEmail;
            } else if (ValidEmail(txtEmail.Text) && ValidPassword(txtPassword.Text)) {
                var user = DbHelper.GetUserByEmailAndPassword(MyStore.StoreID, txtEmail.Text, txtPassword.Text);
                if (user == null) {
                    MessageBox.Show("Invalid e-mail or password!", "Invalid input", MessageBoxButtons.OK);
                    ActiveControl = txtEmail;
                } else {
                    this.Hide();
                    txtPassword.Text = "";
                    var frmStore = new frmStore(MyStore, user);
                    frmStore.ShowDialog();
                    frmStore = null;
                    this.Show();
                    ActiveControl = txtEmail;
                }
            } else {
                ActiveControl = txtEmail;
            }
        }

        private bool ValidPassword(string password) {
            if (password.Length == 0) {
                errorProvider.SetError(txtPassword, "Please enter password!");
                return false;
            } else {
                errorProvider.SetError(txtPassword, "");
                return true;
            }
        }
        private bool ValidEmail(string email) {
            if (email.Length == 0) {
                errorProvider.SetError(txtEmail, "Please enter email address!");
                return false;
            } else {
                try {
                    MailAddress m = new MailAddress(email);
                    errorProvider.SetError(txtEmail, "");
                    return true;
                } catch (FormatException) {
                    errorProvider.SetError(txtEmail, "Please enter valid email address!");
                    return false;
                }
            }
        }

        private void txtEmail_Validated(object sender, EventArgs e) {
            txtEmail.Text = txtEmail.Text.Trim();
            if (MyStore.SuperUser == txtEmail.Text) {
                btnLogIn.Text = "LogIn as Administrator";
            } else {
                btnLogIn.Text = "LogIn";
            }
        }

        private void frmLogIn_Load(object sender, EventArgs e) {

        }
    }
}
