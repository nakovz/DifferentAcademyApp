namespace DifferentAcademyeMarket {
    partial class frmStoreAdministration {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateStoreInfo = new System.Windows.Forms.Button();
            this.txtSuperPassword = new System.Windows.Forms.TextBox();
            this.lblSuperPassword = new System.Windows.Forms.Label();
            this.txtSuperUser = new System.Windows.Forms.TextBox();
            this.lblSuperUser = new System.Windows.Forms.Label();
            this.txtSlogan = new System.Windows.Forms.TextBox();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.txtStoreName = new System.Windows.Forms.TextBox();
            this.lblStoreName = new System.Windows.Forms.Label();
            this.lblItemsInStore = new System.Windows.Forms.Label();
            this.lblItemID = new System.Windows.Forms.Label();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.picItemIcon = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSaveItem = new System.Windows.Forms.Button();
            this.btnNewItem = new System.Windows.Forms.Button();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.ItemInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItemIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtConfirmPassword);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnUpdateStoreInfo);
            this.panel1.Controls.Add(this.txtSuperPassword);
            this.panel1.Controls.Add(this.lblSuperPassword);
            this.panel1.Controls.Add(this.txtSuperUser);
            this.panel1.Controls.Add(this.lblSuperUser);
            this.panel1.Controls.Add(this.txtSlogan);
            this.panel1.Controls.Add(this.lblSlogan);
            this.panel1.Controls.Add(this.txtStoreName);
            this.panel1.Controls.Add(this.lblStoreName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 127);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Unlock to Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(212, 86);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(143, 20);
            this.txtConfirmPassword.TabIndex = 3;
            this.txtConfirmPassword.Text = "textBox1";
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            this.txtConfirmPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConfirmPassword_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Super User Password Unlock";
            // 
            // btnUpdateStoreInfo
            // 
            this.btnUpdateStoreInfo.Location = new System.Drawing.Point(583, 19);
            this.btnUpdateStoreInfo.Name = "btnUpdateStoreInfo";
            this.btnUpdateStoreInfo.Size = new System.Drawing.Size(144, 87);
            this.btnUpdateStoreInfo.TabIndex = 6;
            this.btnUpdateStoreInfo.Text = "Update Store Info";
            this.btnUpdateStoreInfo.UseVisualStyleBackColor = true;
            this.btnUpdateStoreInfo.Click += new System.EventHandler(this.btnUpdateStoreInfo_Click);
            // 
            // txtSuperPassword
            // 
            this.txtSuperPassword.Enabled = false;
            this.txtSuperPassword.Location = new System.Drawing.Point(442, 86);
            this.txtSuperPassword.Name = "txtSuperPassword";
            this.txtSuperPassword.Size = new System.Drawing.Size(135, 20);
            this.txtSuperPassword.TabIndex = 5;
            this.txtSuperPassword.Text = "txtSuperPassword";
            this.txtSuperPassword.UseSystemPasswordChar = true;
            this.txtSuperPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSuperPassword_KeyDown);
            this.txtSuperPassword.Validated += new System.EventHandler(this.txtSuperPassword_Validated);
            // 
            // lblSuperPassword
            // 
            this.lblSuperPassword.AutoSize = true;
            this.lblSuperPassword.Location = new System.Drawing.Point(439, 70);
            this.lblSuperPassword.Name = "lblSuperPassword";
            this.lblSuperPassword.Size = new System.Drawing.Size(134, 13);
            this.lblSuperPassword.TabIndex = 6;
            this.lblSuperPassword.Text = "New Super User Password";
            // 
            // txtSuperUser
            // 
            this.txtSuperUser.Location = new System.Drawing.Point(25, 86);
            this.txtSuperUser.Name = "txtSuperUser";
            this.txtSuperUser.Size = new System.Drawing.Size(176, 20);
            this.txtSuperUser.TabIndex = 2;
            this.txtSuperUser.Text = "txtSuperUser";
            this.txtSuperUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSuperUser_KeyDown);
            // 
            // lblSuperUser
            // 
            this.lblSuperUser.AutoSize = true;
            this.lblSuperUser.Location = new System.Drawing.Point(22, 70);
            this.lblSuperUser.Name = "lblSuperUser";
            this.lblSuperUser.Size = new System.Drawing.Size(60, 13);
            this.lblSuperUser.TabIndex = 4;
            this.lblSuperUser.Text = "Super User";
            // 
            // txtSlogan
            // 
            this.txtSlogan.Location = new System.Drawing.Point(212, 35);
            this.txtSlogan.Name = "txtSlogan";
            this.txtSlogan.Size = new System.Drawing.Size(365, 20);
            this.txtSlogan.TabIndex = 1;
            this.txtSlogan.Text = "txtSlogan";
            this.txtSlogan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSlogan_KeyDown);
            // 
            // lblSlogan
            // 
            this.lblSlogan.AutoSize = true;
            this.lblSlogan.Location = new System.Drawing.Point(209, 19);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(40, 13);
            this.lblSlogan.TabIndex = 2;
            this.lblSlogan.Text = "Slogan";
            // 
            // txtStoreName
            // 
            this.txtStoreName.Location = new System.Drawing.Point(25, 35);
            this.txtStoreName.Name = "txtStoreName";
            this.txtStoreName.Size = new System.Drawing.Size(176, 20);
            this.txtStoreName.TabIndex = 0;
            this.txtStoreName.Text = "txtStoreName";
            this.txtStoreName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStoreName_KeyDown);
            // 
            // lblStoreName
            // 
            this.lblStoreName.AutoSize = true;
            this.lblStoreName.Location = new System.Drawing.Point(22, 19);
            this.lblStoreName.Name = "lblStoreName";
            this.lblStoreName.Size = new System.Drawing.Size(63, 13);
            this.lblStoreName.TabIndex = 0;
            this.lblStoreName.Text = "Store Name";
            // 
            // lblItemsInStore
            // 
            this.lblItemsInStore.Location = new System.Drawing.Point(16, 149);
            this.lblItemsInStore.Name = "lblItemsInStore";
            this.lblItemsInStore.Size = new System.Drawing.Size(389, 13);
            this.lblItemsInStore.TabIndex = 2;
            this.lblItemsInStore.Text = "Items in Store";
            this.lblItemsInStore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Location = new System.Drawing.Point(433, 170);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(38, 13);
            this.lblItemID.TabIndex = 3;
            this.lblItemID.Text = "ItemID";
            // 
            // txtItemID
            // 
            this.txtItemID.Enabled = false;
            this.txtItemID.Location = new System.Drawing.Point(477, 167);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(59, 20);
            this.txtItemID.TabIndex = 4;
            this.txtItemID.Text = "txtItemID";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(477, 193);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(162, 20);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "txtName";
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(436, 196);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(477, 219);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(162, 20);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.Text = "txtPrice";
            this.txtPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrice_KeyDown);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(440, 222);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Price";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(477, 245);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(162, 60);
            this.txtDescription.TabIndex = 4;
            this.txtDescription.Text = "txtDescription";
            this.txtDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescription_KeyDown);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(411, 248);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "Description";
            // 
            // picItemIcon
            // 
            this.picItemIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picItemIcon.Location = new System.Drawing.Point(478, 311);
            this.picItemIcon.Name = "picItemIcon";
            this.picItemIcon.Size = new System.Drawing.Size(160, 160);
            this.picItemIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picItemIcon.TabIndex = 11;
            this.picItemIcon.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(477, 477);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(162, 24);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnSaveItem
            // 
            this.btnSaveItem.Location = new System.Drawing.Point(664, 311);
            this.btnSaveItem.Name = "btnSaveItem";
            this.btnSaveItem.Size = new System.Drawing.Size(80, 190);
            this.btnSaveItem.TabIndex = 6;
            this.btnSaveItem.Text = "Save";
            this.btnSaveItem.UseVisualStyleBackColor = true;
            this.btnSaveItem.Click += new System.EventHandler(this.btnSaveItem_Click);
            // 
            // btnNewItem
            // 
            this.btnNewItem.Location = new System.Drawing.Point(664, 167);
            this.btnNewItem.Name = "btnNewItem";
            this.btnNewItem.Size = new System.Drawing.Size(79, 138);
            this.btnNewItem.TabIndex = 1;
            this.btnNewItem.Text = "New Item";
            this.btnNewItem.UseVisualStyleBackColor = true;
            this.btnNewItem.Click += new System.EventHandler(this.btnNewItem_Click);
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.ColumnHeadersVisible = false;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.ItemInfo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItems.Location = new System.Drawing.Point(12, 167);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowTemplate.Height = 100;
            this.dgvItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(395, 324);
            this.dgvItems.TabIndex = 7;
            this.dgvItems.SelectionChanged += new System.EventHandler(this.dgvItems_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ItemID";
            this.Column1.HeaderText = "ItemID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "imageUrl";
            this.Column2.HeaderText = "ItemIcon";
            this.Column2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // ItemInfo
            // 
            this.ItemInfo.DataPropertyName = "ItemInfo";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemInfo.DefaultCellStyle = dataGridViewCellStyle1;
            this.ItemInfo.HeaderText = "Name and Description";
            this.ItemInfo.Name = "ItemInfo";
            this.ItemInfo.ReadOnly = true;
            this.ItemInfo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemInfo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ItemInfo.Width = 170;
            // 
            // frmStoreAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 513);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.btnNewItem);
            this.Controls.Add(this.btnSaveItem);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.picItemIcon);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtItemID);
            this.Controls.Add(this.lblItemID);
            this.Controls.Add(this.lblItemsInStore);
            this.Controls.Add(this.panel1);
            this.Name = "frmStoreAdministration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStoreAdministration";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItemIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdateStoreInfo;
        private System.Windows.Forms.TextBox txtSuperPassword;
        private System.Windows.Forms.Label lblSuperPassword;
        private System.Windows.Forms.TextBox txtSuperUser;
        private System.Windows.Forms.Label lblSuperUser;
        private System.Windows.Forms.TextBox txtSlogan;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.TextBox txtStoreName;
        private System.Windows.Forms.Label lblStoreName;
        private System.Windows.Forms.Label lblItemsInStore;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.PictureBox picItemIcon;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSaveItem;
        private System.Windows.Forms.Button btnNewItem;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemInfo;
    }
}