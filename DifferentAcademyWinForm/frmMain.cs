using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleGame;

namespace DifferentAcademyWinForm {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e) {
            this.Hide();
            var signUpForm = new frmSignUpNewUser(txtUsername.Text.Trim(), txtPassword.Text.Trim());
            signUpForm.ShowDialog();
            signUpForm = null;
            this.Show();
        }

        private void btnLogIn_Click(object sender, EventArgs e) {
            List<MyPerson> users = DbPerson.GetPersonByEmailAndPassword(txtUsername.Text.Trim(), txtPassword.Text.Trim());
            if (users.Count == 1) {
                this.Hide();
                if (users.ElementAt(0).AccountType == (int)DbHelper.AccountType.Admin) {
                    var adminDashBoardForm = new FrmAdminDashBoard(users.ElementAt(0));
                    adminDashBoardForm.ShowDialog();
                    adminDashBoardForm = null;
                } else {
                    var dashBoardForm = new frmDashBoard(users.ElementAt(0));
                    dashBoardForm.ShowDialog();
                    dashBoardForm = null;
                }
                ClearTextBoxes();
                this.Show();
            } else {
                MessageBox.Show("Username and Password didn't match!", "Wrong Username or password", MessageBoxButtons.OK);
            }
        }

        private void ClearTextBoxes() {
            txtPassword.Text = "";
            txtUsername.Text = "";
        }
        private void txtUsername_KeyDown(object sender, KeyEventArgs e) {
            FormHelper.SelectNextControlOnEnter(this, sender, e);
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e) {
            FormHelper.SelectNextControlOnEnter(this, sender, e);
        }
    }
}
