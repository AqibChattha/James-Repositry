namespace JamesTabs.UI.Components
{
    partial class Accounts
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbShowPassword = new System.Windows.Forms.CheckBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowAdd = new System.Windows.Forms.Button();
            this.dgvAccounts = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.cbShowPassword);
            this.groupBox1.Controls.Add(this.tbPassword);
            this.groupBox1.Controls.Add(this.lbPassword);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.lbEmail);
            this.groupBox1.Location = new System.Drawing.Point(8, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add new account";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(105, 118);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(49, 27);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(160, 118);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 27);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Account";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbShowPassword
            // 
            this.cbShowPassword.AutoSize = true;
            this.cbShowPassword.Location = new System.Drawing.Point(72, 88);
            this.cbShowPassword.Name = "cbShowPassword";
            this.cbShowPassword.Size = new System.Drawing.Size(102, 17);
            this.cbShowPassword.TabIndex = 11;
            this.cbShowPassword.Text = "Show Password";
            this.cbShowPassword.UseVisualStyleBackColor = true;
            this.cbShowPassword.CheckedChanged += new System.EventHandler(this.cbShowPassword_CheckedChanged);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(72, 62);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(165, 20);
            this.tbPassword.TabIndex = 1;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(13, 65);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(53, 13);
            this.lbPassword.TabIndex = 0;
            this.lbPassword.Text = "Password";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(72, 36);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(165, 20);
            this.tbEmail.TabIndex = 0;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(23, 39);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 0;
            this.lbEmail.Text = "Email";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnShowAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 483);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 38);
            this.panel1.TabIndex = 13;
            // 
            // btnShowAdd
            // 
            this.btnShowAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowAdd.Location = new System.Drawing.Point(305, 6);
            this.btnShowAdd.Name = "btnShowAdd";
            this.btnShowAdd.Size = new System.Drawing.Size(114, 27);
            this.btnShowAdd.TabIndex = 0;
            this.btnShowAdd.Text = "Add new Account";
            this.btnShowAdd.UseVisualStyleBackColor = true;
            this.btnShowAdd.Click += new System.EventHandler(this.btnShowAdd_Click);
            // 
            // dgvAccounts
            // 
            this.dgvAccounts.AllowUserToAddRows = false;
            this.dgvAccounts.AllowUserToDeleteRows = false;
            this.dgvAccounts.AllowUserToOrderColumns = true;
            this.dgvAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccounts.BackgroundColor = System.Drawing.Color.White;
            this.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccounts.Location = new System.Drawing.Point(0, 0);
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.ReadOnly = true;
            this.dgvAccounts.RowHeadersVisible = false;
            this.dgvAccounts.Size = new System.Drawing.Size(425, 483);
            this.dgvAccounts.TabIndex = 14;
            this.dgvAccounts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTasks_CellClick);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(6, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 27);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(425, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 521);
            this.panel2.TabIndex = 15;
            // 
            // Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvAccounts);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Accounts";
            this.Size = new System.Drawing.Size(691, 521);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.CheckBox cbShowPassword;
        private System.Windows.Forms.Button btnShowAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvAccounts;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
    }
}
