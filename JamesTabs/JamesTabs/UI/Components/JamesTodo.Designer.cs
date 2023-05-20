namespace JamesTabs.UI.Components
{
    partial class JamesTodo
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
			this.dgvTasks = new System.Windows.Forms.DataGridView();
			this.cView = new System.Windows.Forms.DataGridViewButtonColumn();
			this.cEdit = new System.Windows.Forms.DataGridViewButtonColumn();
			this.cDelete = new System.Windows.Forms.DataGridViewButtonColumn();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dtpDeadline = new System.Windows.Forms.DateTimePicker();
			this.rtbDescription = new System.Windows.Forms.RichTextBox();
			this.lbDeadline = new System.Windows.Forms.Label();
			this.tbTitle = new System.Windows.Forms.TextBox();
			this.lbDescription = new System.Windows.Forms.Label();
			this.lbTitle = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvTasks
			// 
			this.dgvTasks.AllowUserToAddRows = false;
			this.dgvTasks.AllowUserToDeleteRows = false;
			this.dgvTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvTasks.BackgroundColor = System.Drawing.Color.White;
			this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cView,
            this.cEdit,
            this.cDelete});
			this.dgvTasks.Location = new System.Drawing.Point(3, 167);
			this.dgvTasks.Name = "dgvTasks";
			this.dgvTasks.ReadOnly = true;
			this.dgvTasks.RowHeadersVisible = false;
			this.dgvTasks.Size = new System.Drawing.Size(633, 282);
			this.dgvTasks.TabIndex = 6;
			this.dgvTasks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTasks_CellClick);
			// 
			// cView
			// 
			this.cView.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.cView.HeaderText = "View";
			this.cView.Name = "cView";
			this.cView.ReadOnly = true;
			this.cView.Text = "View";
			this.cView.UseColumnTextForButtonValue = true;
			this.cView.Width = 36;
			// 
			// cEdit
			// 
			this.cEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.cEdit.HeaderText = "Edit";
			this.cEdit.Name = "cEdit";
			this.cEdit.ReadOnly = true;
			this.cEdit.Text = "Edit";
			this.cEdit.UseColumnTextForButtonValue = true;
			this.cEdit.Width = 31;
			// 
			// cDelete
			// 
			this.cDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.cDelete.HeaderText = "Delete";
			this.cDelete.Name = "cDelete";
			this.cDelete.ReadOnly = true;
			this.cDelete.Text = "Delete";
			this.cDelete.UseColumnTextForButtonValue = true;
			this.cDelete.Width = 44;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.groupBox1.Controls.Add(this.dtpDeadline);
			this.groupBox1.Controls.Add(this.rtbDescription);
			this.groupBox1.Controls.Add(this.lbDeadline);
			this.groupBox1.Controls.Add(this.tbTitle);
			this.groupBox1.Controls.Add(this.lbDescription);
			this.groupBox1.Controls.Add(this.lbTitle);
			this.groupBox1.Location = new System.Drawing.Point(53, 28);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(532, 100);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Add Task";
			// 
			// dtpDeadline
			// 
			this.dtpDeadline.Location = new System.Drawing.Point(160, 37);
			this.dtpDeadline.Name = "dtpDeadline";
			this.dtpDeadline.Size = new System.Drawing.Size(161, 20);
			this.dtpDeadline.TabIndex = 3;
			// 
			// rtbDescription
			// 
			this.rtbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.rtbDescription.Location = new System.Drawing.Point(344, 32);
			this.rtbDescription.Name = "rtbDescription";
			this.rtbDescription.Size = new System.Drawing.Size(171, 53);
			this.rtbDescription.TabIndex = 2;
			this.rtbDescription.Text = "";
			// 
			// lbDeadline
			// 
			this.lbDeadline.AutoSize = true;
			this.lbDeadline.Location = new System.Drawing.Point(157, 21);
			this.lbDeadline.Name = "lbDeadline";
			this.lbDeadline.Size = new System.Drawing.Size(49, 13);
			this.lbDeadline.TabIndex = 0;
			this.lbDeadline.Text = "Deadline";
			// 
			// tbTitle
			// 
			this.tbTitle.Location = new System.Drawing.Point(20, 37);
			this.tbTitle.Name = "tbTitle";
			this.tbTitle.Size = new System.Drawing.Size(117, 20);
			this.tbTitle.TabIndex = 1;
			// 
			// lbDescription
			// 
			this.lbDescription.AutoSize = true;
			this.lbDescription.Location = new System.Drawing.Point(341, 16);
			this.lbDescription.Name = "lbDescription";
			this.lbDescription.Size = new System.Drawing.Size(60, 13);
			this.lbDescription.TabIndex = 0;
			this.lbDescription.Text = "Description";
			// 
			// lbTitle
			// 
			this.lbTitle.AutoSize = true;
			this.lbTitle.Location = new System.Drawing.Point(17, 21);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(27, 13);
			this.lbTitle.TabIndex = 0;
			this.lbTitle.Text = "Title";
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnAdd.Location = new System.Drawing.Point(483, 134);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(102, 27);
			this.btnAdd.TabIndex = 3;
			this.btnAdd.Text = "Add Task";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// JamesTodo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.dgvTasks);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnAdd);
			this.Name = "JamesTodo";
			this.Size = new System.Drawing.Size(639, 452);
			((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpDeadline;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label lbDeadline;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewButtonColumn cView;
        private System.Windows.Forms.DataGridViewButtonColumn cEdit;
        private System.Windows.Forms.DataGridViewButtonColumn cDelete;
    }
}
