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
			this.btnAccountManagement = new System.Windows.Forms.Button();
			this.btnLogout = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lbVersion = new System.Windows.Forms.Label();
			this.btnJamesTodo = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnYoutubeVideoPlayer = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lbMenu = new System.Windows.Forms.Label();
			this.panel3.SuspendLayout();
			this.pnlSidebar.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.pnlContant);
			this.panel3.Controls.Add(this.pnlSidebar);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(865, 567);
			this.panel3.TabIndex = 0;
			// 
			// pnlContant
			// 
			this.pnlContant.AutoScroll = true;
			this.pnlContant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.pnlContant.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlContant.Location = new System.Drawing.Point(214, 0);
			this.pnlContant.Name = "pnlContant";
			this.pnlContant.Size = new System.Drawing.Size(651, 567);
			this.pnlContant.TabIndex = 2;
			// 
			// pnlSidebar
			// 
			this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(115)))), ((int)(((byte)(172)))));
			this.pnlSidebar.Controls.Add(this.btnYoutubeVideoPlayer);
			this.pnlSidebar.Controls.Add(this.btnAccountManagement);
			this.pnlSidebar.Controls.Add(this.btnLogout);
			this.pnlSidebar.Controls.Add(this.panel2);
			this.pnlSidebar.Controls.Add(this.btnJamesTodo);
			this.pnlSidebar.Controls.Add(this.panel1);
			this.pnlSidebar.Controls.Add(this.pictureBox1);
			this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
			this.pnlSidebar.Name = "pnlSidebar";
			this.pnlSidebar.Size = new System.Drawing.Size(214, 567);
			this.pnlSidebar.TabIndex = 1;
			// 
			// btnAccountManagement
			// 
			this.btnAccountManagement.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnAccountManagement.FlatAppearance.BorderSize = 0;
			this.btnAccountManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
			this.btnAccountManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAccountManagement.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAccountManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.btnAccountManagement.Location = new System.Drawing.Point(0, 225);
			this.btnAccountManagement.Name = "btnAccountManagement";
			this.btnAccountManagement.Size = new System.Drawing.Size(214, 40);
			this.btnAccountManagement.TabIndex = 6;
			this.btnAccountManagement.Text = "Account Management";
			this.btnAccountManagement.UseVisualStyleBackColor = true;
			this.btnAccountManagement.Click += new System.EventHandler(this.btnJamesTodo2_Click);
			// 
			// btnLogout
			// 
			this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnLogout.FlatAppearance.BorderSize = 0;
			this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
			this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogout.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.btnLogout.Location = new System.Drawing.Point(0, 493);
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
			this.panel2.Location = new System.Drawing.Point(0, 533);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(214, 34);
			this.panel2.TabIndex = 3;
			// 
			// lbVersion
			// 
			this.lbVersion.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lbVersion.AutoSize = true;
			this.lbVersion.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.lbVersion.Location = new System.Drawing.Point(43, 9);
			this.lbVersion.Name = "lbVersion";
			this.lbVersion.Size = new System.Drawing.Size(128, 23);
			this.lbVersion.TabIndex = 6;
			this.lbVersion.Text = "© James Applications v1.0";
			this.lbVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnJamesTodo
			// 
			this.btnJamesTodo.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnJamesTodo.FlatAppearance.BorderSize = 0;
			this.btnJamesTodo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
			this.btnJamesTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnJamesTodo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnJamesTodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.btnJamesTodo.Location = new System.Drawing.Point(0, 185);
			this.btnJamesTodo.Name = "btnJamesTodo";
			this.btnJamesTodo.Size = new System.Drawing.Size(214, 40);
			this.btnJamesTodo.TabIndex = 2;
			this.btnJamesTodo.Text = "James Todo";
			this.btnJamesTodo.UseVisualStyleBackColor = true;
			this.btnJamesTodo.Click += new System.EventHandler(this.btnJamesTodo_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(214, 143);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// btnYoutubeVideoPlayer
			// 
			this.btnYoutubeVideoPlayer.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnYoutubeVideoPlayer.FlatAppearance.BorderSize = 0;
			this.btnYoutubeVideoPlayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
			this.btnYoutubeVideoPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnYoutubeVideoPlayer.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnYoutubeVideoPlayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.btnYoutubeVideoPlayer.Location = new System.Drawing.Point(0, 265);
			this.btnYoutubeVideoPlayer.Name = "btnYoutubeVideoPlayer";
			this.btnYoutubeVideoPlayer.Size = new System.Drawing.Size(214, 40);
			this.btnYoutubeVideoPlayer.TabIndex = 7;
			this.btnYoutubeVideoPlayer.Text = "Youtube Video Player";
			this.btnYoutubeVideoPlayer.UseVisualStyleBackColor = true;
			this.btnYoutubeVideoPlayer.Click += new System.EventHandler(this.btnYoutubeVideoPlayer_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lbMenu);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 143);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(214, 42);
			this.panel1.TabIndex = 1;
			// 
			// lbMenu
			// 
			this.lbMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbMenu.AutoSize = true;
			this.lbMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.lbMenu.Location = new System.Drawing.Point(3, 26);
			this.lbMenu.Name = "lbMenu";
			this.lbMenu.Size = new System.Drawing.Size(40, 13);
			this.lbMenu.TabIndex = 0;
			this.lbMenu.Text = "Menu -";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(865, 567);
			this.Controls.Add(this.panel3);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "James Board";
			this.panel3.ResumeLayout(false);
			this.pnlSidebar.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlContant;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnAccountManagement;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Button btnJamesTodo;
        private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnYoutubeVideoPlayer;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lbMenu;
	}
}