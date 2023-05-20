namespace JamesTabs.UI.Forms
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlContant = new System.Windows.Forms.Panel();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnManagement = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbVersion = new System.Windows.Forms.Label();
            this.btnJamesTodo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnlContant);
            this.panel3.Controls.Add(this.pnlSidebar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 473);
            this.panel3.TabIndex = 0;
            // 
            // pnlContant
            // 
            this.pnlContant.AutoScroll = true;
            this.pnlContant.BackColor = System.Drawing.Color.LightGray;
            this.pnlContant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContant.Location = new System.Drawing.Point(214, 0);
            this.pnlContant.Name = "pnlContant";
            this.pnlContant.Size = new System.Drawing.Size(586, 473);
            this.pnlContant.TabIndex = 2;
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlSidebar.Controls.Add(this.btnManagement);
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.panel2);
            this.pnlSidebar.Controls.Add(this.btnJamesTodo);
            this.pnlSidebar.Controls.Add(this.panel1);
            this.pnlSidebar.Controls.Add(this.pictureBox1);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(214, 473);
            this.pnlSidebar.TabIndex = 1;
            // 
            // btnManagement
            // 
            this.btnManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManagement.FlatAppearance.BorderSize = 0;
            this.btnManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagement.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagement.ForeColor = System.Drawing.Color.White;
            this.btnManagement.Location = new System.Drawing.Point(0, 200);
            this.btnManagement.Name = "btnManagement";
            this.btnManagement.Size = new System.Drawing.Size(214, 40);
            this.btnManagement.TabIndex = 6;
            this.btnManagement.Text = "Management";
            this.btnManagement.UseVisualStyleBackColor = true;
            this.btnManagement.Click += new System.EventHandler(this.btnJamesTodo2_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 399);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(214, 40);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbVersion);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 439);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 34);
            this.panel2.TabIndex = 3;
            // 
            // lbVersion
            // 
            this.lbVersion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbVersion.AutoSize = true;
            this.lbVersion.ForeColor = System.Drawing.Color.White;
            this.lbVersion.Location = new System.Drawing.Point(41, 12);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(133, 13);
            this.lbVersion.TabIndex = 6;
            this.lbVersion.Text = "© James Applications v1.0";
            this.lbVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnJamesTodo
            // 
            this.btnJamesTodo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnJamesTodo.FlatAppearance.BorderSize = 0;
            this.btnJamesTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJamesTodo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJamesTodo.ForeColor = System.Drawing.Color.White;
            this.btnJamesTodo.Location = new System.Drawing.Point(0, 160);
            this.btnJamesTodo.Name = "btnJamesTodo";
            this.btnJamesTodo.Size = new System.Drawing.Size(214, 40);
            this.btnJamesTodo.TabIndex = 2;
            this.btnJamesTodo.Text = "James Todo";
            this.btnJamesTodo.UseVisualStyleBackColor = true;
            this.btnJamesTodo.Click += new System.EventHandler(this.btnJamesTodo_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 17);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel3.ResumeLayout(false);
            this.pnlSidebar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlContant;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnManagement;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Button btnJamesTodo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}