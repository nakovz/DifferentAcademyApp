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
    public partial class FrmAdminDashBoard : Form {
        public FrmAdminDashBoard() {
            InitializeComponent();
        }

        public FrmAdminDashBoard(MyPerson user) {
            InitializeComponent();
            lblFullName.Text = user.FirstName.Trim() + " " + user.LastName.Trim();
            lblEmail.Text = user.Email.Trim();
        }

        private void btnLogOut_Click(object sender, EventArgs e) {
            this.Dispose();
        }

        private void FrmAdminDashBoard_Shown(object sender, EventArgs e) {
            UpdateDataInGridView();
        }

        private void btnSearchClear_Click(object sender, EventArgs e) {
            txtSearch.Text = "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) {
            UpdateDataInGridView();
        }

        private void UpdateDataInGridView() {
            dataGridView1.DataSource = DbPerson.GetUsersWithEmailLike(txtSearch.Text.Trim());
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
            if(e.ColumnIndex == 0) {
                // Edit User Account
                var user = DbPerson.GetPersonByEmail(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());
                var editForm = new frmSignUpNewUser(user.ElementAt(0));
                editForm.ShowDialog();
                editForm = null;
                UpdateDataInGridView();
            } else if (e.ColumnIndex == 1) {
                // Delete User Account
                if(MessageBox.Show("Do you want to delete user?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                    DbPerson.DeleteUserById(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    UpdateDataInGridView();
                }
            }
        }
    }
}
