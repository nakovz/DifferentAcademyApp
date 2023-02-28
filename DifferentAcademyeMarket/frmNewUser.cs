using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace DifferentAcademyeMarket {
    public partial class frmNewUser : Form {

        public Store MyStore { get; set; }
        private ErrorProvider errorProvider = new ErrorProvider();

        public frmNewUser() {
            InitializeComponent();
        }

        public frmNewUser(Store store) : this() {
            MyStore = store;
        }

        private void btnSignUp_Click(object sender, EventArgs e) {
            var newUser = new Users() {
                email = txtEmail.Text,
                password = txtPassword.Text,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                phone = txtPhone.Text,
                DateOfBirth = DTpicDOB.Value.Date,
                StoreID = MyStore.StoreID
            };
            if (ValidEmail(newUser.email) && 
                ValidPassword(newUser.password) &&
                ValidConfirmPassword(newUser.password, txtConfirmPassword.Text)) {
                    if (DbHelper.isEmailAlreadyRegistered(MyStore.StoreID, newUser.email) == false) {
                        DbHelper.CreateNewUser(newUser);
                        MessageBox.Show("Congratulation, your account has been succesfully created!", "SignUp New User", MessageBoxButtons.OK);
                        this.Dispose();
                    } else {
                        errorProvider.SetError(txtEmail, "The email is already registered!");
                        ActiveControl = txtEmail;
                    }
            } else {
                ActiveControl = txtEmail;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Dispose();
        }

        private void txtEmail_Validated(object sender, EventArgs e) {
            txtEmail.Text = txtEmail.Text.Trim();
            ValidEmail(txtEmail.Text);
        }

        private bool ValidEmail(string email) {
            if (email.Length == 0) {
                errorProvider.SetError(txtEmail, "Please enter email address!");
                return false;
            } else {
                try {
                    MailAddress m = new MailAddress(email);
                    if (DbHelper.isEmailAlreadyRegistered(MyStore.StoreID, email)) {
                        errorProvider.SetError(txtEmail, "The email is already registered!");
                        return false;
                    } else {
                        errorProvider.SetError(txtEmail, "");
                        return true;
                    }
                } catch (FormatException) {
                    errorProvider.SetError(txtEmail, "Please enter valid email address!");
                    return false;
                }
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

        private bool ValidConfirmPassword(string password, string confirmpassword) {
            if (password != confirmpassword) {
                errorProvider.SetError(txtConfirmPassword, "Password didn't match!");
                return false;
            } else {
                errorProvider.SetError(txtConfirmPassword, "");
                return true;
            }
        }

        private void txtPassword_Validated(object sender, EventArgs e) {
            txtPassword.Text = txtPassword.Text.Trim();
            ValidPassword(txtPassword.Text);
        }

        private void txtConfirmPassword_Validated(object sender, EventArgs e) {
            txtConfirmPassword.Text = txtConfirmPassword.Text.Trim();
            ValidConfirmPassword(txtPassword.Text, txtConfirmPassword.Text);
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e) {
            FormHelper.SelectNextControlOnEnter(this, sender, e);
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e) {
            FormHelper.SelectNextControlOnEnter(this, sender, e);
        }

        private void txtConfirmPassword_KeyDown(object sender, KeyEventArgs e) {
            FormHelper.SelectNextControlOnEnter(this, sender, e);
        }

        private void txtFirstName_KeyDown(object sender, KeyEventArgs e) {
            FormHelper.SelectNextControlOnEnter(this, sender, e);
        }

        private void txtLastName_KeyDown(object sender, KeyEventArgs e) {
            FormHelper.SelectNextControlOnEnter(this, sender, e);
        }

        private void txtPhone_KeyDown(object sender, KeyEventArgs e) {
            FormHelper.SelectNextControlOnEnter(this, sender, e);
        }

        private void DTpicDOB_KeyDown(object sender, KeyEventArgs e) {
            FormHelper.SelectNextControlOnEnter(this, sender, e);
        }
    }
}
