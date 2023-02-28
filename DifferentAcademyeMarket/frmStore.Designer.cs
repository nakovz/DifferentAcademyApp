namespace DifferentAcademyeMarket {
    partial class frmStore {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rbtnAllItems = new System.Windows.Forms.RadioButton();
            this.rbtnMyItems = new System.Windows.Forms.RadioButton();
            this.btnUserInfo = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserEmail = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.ItemInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCreditBalance = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.lblItemID = new System.Windows.Forms.Label();
            this.picItemIcon = new System.Windows.Forms.PictureBox();
            this.txtPurchased = new System.Windows.Forms.TextBox();
            this.lblPurchased = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItemIcon)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtnAllItems
            // 
            this.rbtnAllItems.AutoSize = true;
            this.rbtnAllItems.Checked = true;
            this.rbtnAllItems.Location = new System.Drawing.Point(12, 25);
            this.rbtnAllItems.Name = "rbtnAllItems";
            this.rbtnAllItems.Size = new System.Drawing.Size(103, 17);
            this.rbtnAllItems.TabIndex = 0;
            this.rbtnAllItems.TabStop = true;
            this.rbtnAllItems.Text = "All Items in Store";
            this.rbtnAllItems.UseVisualStyleBackColor = true;
            this.rbtnAllItems.CheckedChanged += new System.EventHandler(this.rbtnAllItems_CheckedChanged);
            // 
            // rbtnMyItems
            // 
            this.rbtnMyItems.AutoSize = true;
            this.rbtnMyItems.Location = new System.Drawing.Point(121, 25);
            this.rbtnMyItems.Name = "rbtnMyItems";
            this.rbtnMyItems.Size = new System.Drawing.Size(67, 17);
            this.rbtnMyItems.TabIndex = 0;
            this.rbtnMyItems.Text = "My Items";
            this.rbtnMyItems.UseVisualStyleBackColor = true;
            // 
            // btnUserInfo
            // 
            this.btnUserInfo.Location = new System.Drawing.Point(627, 12);
            this.btnUserInfo.Name = "btnUserInfo";
            this.btnUserInfo.Size = new System.Drawing.Size(80, 43);
            this.btnUserInfo.TabIndex = 1;
            this.btnUserInfo.Text = "Manage your account";
            this.btnUserInfo.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(713, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 43);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserName.Location = new System.Drawing.Point(231, 9);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(182, 31);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "lblUserName";
            // 
            // lblUserEmail
            // 
            this.lblUserEmail.AutoSize = true;
            this.lblUserEmail.Location = new System.Drawing.Point(234, 42);
            this.lblUserEmail.Name = "lblUserEmail";
            this.lblUserEmail.Size = new System.Drawing.Size(64, 13);
            this.lblUserEmail.TabIndex = 4;
            this.lblUserEmail.Text = "lblUserEmail";
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
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItems.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvItems.Location = new System.Drawing.Point(12, 58);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowTemplate.Height = 100;
            this.dgvItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(401, 380);
            this.dgvItems.TabIndex = 8;
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
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemInfo.DefaultCellStyle = dataGridViewCellStyle13;
            this.ItemInfo.HeaderText = "Name and Description";
            this.ItemInfo.Name = "ItemInfo";
            this.ItemInfo.ReadOnly = true;
            this.ItemInfo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemInfo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ItemInfo.Width = 170;
            // 
            // lblCreditBalance
            // 
            this.lblCreditBalance.AutoSize = true;
            this.lblCreditBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCreditBalance.Location = new System.Drawing.Point(462, 22);
            this.lblCreditBalance.Name = "lblCreditBalance";
            this.lblCreditBalance.Size = new System.Drawing.Size(124, 20);
            this.lblCreditBalance.TabIndex = 9;
            this.lblCreditBalance.Text = "lblCreditBalance";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(588, 122);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(200, 60);
            this.txtDescription.TabIndex = 14;
            this.txtDescription.TabStop = false;
            this.txtDescription.Text = "txtDescription";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(585, 106);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 18;
            this.lblDescription.Text = "Description";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(649, 188);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(139, 20);
            this.txtPrice.TabIndex = 12;
            this.txtPrice.TabStop = false;
            this.txtPrice.Text = "txtPrice";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(612, 191);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 17;
            this.lblPrice.Text = "Price";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.Location = new System.Drawing.Point(588, 74);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(200, 26);
            this.txtName.TabIndex = 11;
            this.txtName.TabStop = false;
            this.txtName.Text = "txtName";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(585, 58);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Name";
            // 
            // txtItemID
            // 
            this.txtItemID.Enabled = false;
            this.txtItemID.Location = new System.Drawing.Point(491, 224);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.ReadOnly = true;
            this.txtItemID.Size = new System.Drawing.Size(59, 20);
            this.txtItemID.TabIndex = 15;
            this.txtItemID.Text = "txtItemID";
            this.txtItemID.Visible = false;
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Location = new System.Drawing.Point(447, 227);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(38, 13);
            this.lblItemID.TabIndex = 13;
            this.lblItemID.Text = "ItemID";
            this.lblItemID.Visible = false;
            // 
            // picItemIcon
            // 
            this.picItemIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picItemIcon.Location = new System.Drawing.Point(419, 58);
            this.picItemIcon.Name = "picItemIcon";
            this.picItemIcon.Size = new System.Drawing.Size(160, 160);
            this.picItemIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picItemIcon.TabIndex = 22;
            this.picItemIcon.TabStop = false;
            // 
            // txtPurchased
            // 
            this.txtPurchased.Location = new System.Drawing.Point(649, 214);
            this.txtPurchased.Name = "txtPurchased";
            this.txtPurchased.ReadOnly = true;
            this.txtPurchased.Size = new System.Drawing.Size(139, 20);
            this.txtPurchased.TabIndex = 23;
            this.txtPurchased.TabStop = false;
            this.txtPurchased.Text = "txtPurchased";
            // 
            // lblPurchased
            // 
            this.lblPurchased.AutoSize = true;
            this.lblPurchased.Location = new System.Drawing.Point(585, 217);
            this.lblPurchased.Name = "lblPurchased";
            this.lblPurchased.Size = new System.Drawing.Size(58, 13);
            this.lblPurchased.TabIndex = 24;
            this.lblPurchased.Text = "Purchased";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnBuy);
            this.flowLayoutPanel1.Controls.Add(this.btnPlay);
            this.flowLayoutPanel1.Controls.Add(this.btnSell);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(704, 240);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(84, 198);
            this.flowLayoutPanel1.TabIndex = 25;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(3, 32);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 24;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(3, 61);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(75, 23);
            this.btnSell.TabIndex = 23;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(3, 3);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(75, 23);
            this.btnBuy.TabIndex = 22;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // frmStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.txtPurchased);
            this.Controls.Add(this.lblPurchased);
            this.Controls.Add(this.picItemIcon);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtItemID);
            this.Controls.Add(this.lblItemID);
            this.Controls.Add(this.lblCreditBalance);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.lblUserEmail);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnUserInfo);
            this.Controls.Add(this.rbtnMyItems);
            this.Controls.Add(this.rbtnAllItems);
            this.Name = "frmStore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStore";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItemIcon)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnAllItems;
        private System.Windows.Forms.RadioButton rbtnMyItems;
        private System.Windows.Forms.Button btnUserInfo;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserEmail;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Label lblCreditBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemInfo;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.PictureBox picItemIcon;
        private System.Windows.Forms.TextBox txtPurchased;
        private System.Windows.Forms.Label lblPurchased;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnSell;
    }
}