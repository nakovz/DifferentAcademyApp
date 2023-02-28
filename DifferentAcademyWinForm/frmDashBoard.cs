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
    public partial class frmDashBoard : Form {

        public MyPerson LoggedUser { get; set; }

        public frmDashBoard() {
            InitializeComponent();
        }

        public frmDashBoard(MyPerson user) {
            InitializeComponent();
            LoggedUser = user;
            lblFullName.Text = user.FirstName.Trim() + " " + user.LastName.Trim();
            lblEmail.Text = user.Email.Trim();
        }

        private void btnLogOut_Click(object sender, EventArgs e) {
            this.Dispose();
        }

        private void frmDashBoard_FormClosed(object sender, FormClosedEventArgs e) {
            
        }

        private void btnManageAccount_Click(object sender, EventArgs e) {
            this.Hide();
            var frmUpdateInfo = new frmSignUpNewUser(LoggedUser, LoggedUser.AccountType == (int)DbHelper.AccountType.Admin);
            frmUpdateInfo.ShowDialog();
            frmUpdateInfo = null;
            this.Show();
        }
    }
}
