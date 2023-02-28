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
    public partial class frmSignUpNewUser : Form {
        public frmSignUpNewUser() {
            InitializeComponent();
        }

        public MyPerson PersonForUpdating { get; set; }

        public frmSignUpNewUser(string username, string password) {
            InitializeComponent();
            txtEmail.Text = username;
            txtPassword.Text = password;
            PersonForUpdating = new MyPerson();
            groupAccountType.Visible = false;
            InitGenderTypeGrouBox(groupGenderType);
            InitAccountTypeGrouBox(groupAccountType);
            SelectRadioButtonInGroupBoxByValue(groupAccountType, DbHelper.AccountType.User.ToString());
        }

        public frmSignUpNewUser(MyPerson user, Boolean isAdmin) {
            InitializeComponent();
            PersonForUpdating = user;
            this.Text = "Update User information";
            btnSignUp.Text = "Update";

            txtEmail.ReadOnly = true;
            txtEmail.Text = user.Email;
            txtPassword.Text = user.UserPassword;
            txtConfirmPassword.Text = txtPassword.Text;
            txtFirstName.Text = user.FirstName;
            txtLastName.Text = user.LastName;
            txtPhone.Text = user.Phone;
            pickerDOB.Value = new DateTime(Math.Max(pickerDOB.MinDate.Ticks, user.DateOfBirth.Ticks));

            InitGenderTypeGrouBox(groupGenderType);
            SelectRadioButtonInGroupBoxByValue(groupGenderType,user.Gender);

            InitAccountTypeGrouBox(groupAccountType);
            SelectRadioButtonInGroupBoxByValue(groupAccountType, ((DbHelper.AccountType)user.AccountType).ToString());
            groupAccountType.Visible = isAdmin;
        }

        private void InitAccountTypeGrouBox(GroupBox groupBox) {
            var index = 0;
            foreach (var radioBtn in groupBox.Controls.OfType<RadioButton>().OrderBy(c => c.TabIndex)) {
                radioBtn.Text = ((DbHelper.AccountType)index++).ToString();
            }
        }

        private void InitGenderTypeGrouBox(GroupBox groupBox) {
            var index = 0;
            foreach (var radioBtn in groupBox.Controls.OfType<RadioButton>().OrderBy(c => c.TabIndex)) {
                radioBtn.Text = ((DbHelper.GenderType)index++).ToString();
            }
        }

        private void SelectRadioButtonInGroupBoxByValue(GroupBox groupBox, string value) {
            groupBox.Controls.OfType<RadioButton>().FirstOrDefault(c => c.Text == value).Checked = true;
        }

        private void btnSignUp_Click(object sender, EventArgs e) {
            if (btnSignUp.Text == "Update") {
                var userType = GetSelectedValueFromGroupBoxOfRadioButtons(groupAccountType);
                var newUser = new MyPerson {
                    Email = txtEmail.Text.Trim(),
                    FirstName = txtFirstName.Text.Trim(),
                    LastName = txtLastName.Text.Trim(),
                    UserPassword = txtPassword.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Gender = GetSelectedValueFromGroupBoxOfRadioButtons(groupGenderType),
                    DateOfBirth = pickerDOB.Value.Date,
                    AccountType = (int)Enum.Parse(typeof(DbHelper.AccountType), userType),
                    PersonId = PersonForUpdating.PersonId
                };
                DbPerson.UpdateUserInfo(newUser);
                MessageBox.Show("Succesfully updated info!", "Update User Info", MessageBoxButtons.OK);
                this.Dispose();
            } else if (DbPerson.GetPersonByEmail(this.txtEmail.Text.Trim()).Count() > 0) {
                MessageBox.Show("User already exist! Please use another email!");
            } else {
                var newUser = new MyPerson {
                    Email = txtEmail.Text.Trim(),
                    FirstName = txtFirstName.Text.Trim(),
                    LastName = txtLastName.Text.Trim(),
                    UserPassword = txtPassword.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Gender = GetSelectedValueFromGroupBoxOfRadioButtons(groupGenderType),
                    DateOfBirth = pickerDOB.Value.Date,
                    AccountType = (int)DbHelper.AccountType.User
                };
                
                DbPerson.AddNewUser(newUser);
                MessageBox.Show("Congratulation, your account has been succesfully created!", "SignUp New User", MessageBoxButtons.OK);
                this.Dispose();
            }
        }

        private string GetSelectedValueFromGroupBoxOfRadioButtons(GroupBox groupBox) {
            var checkedRadioButton = groupBox.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
            return checkedRadioButton == null ? "" : checkedRadioButton.Text;
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

        private void pickerDOB_KeyDown(object sender, KeyEventArgs e) {
            FormHelper.SelectNextControlOnEnter(this, sender, e);
        }
    }
}
