using JamesTabs.Models;
using JamesTabs.Services.ModelServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JamesTabs.UI.Components
{
    public partial class JamesTodo : UserControl
    {
        private int _rowUpdate = -1;

        private static JamesTodo _instance;
        public static JamesTodo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new JamesTodo();
                }
                return _instance;
            }
        }

        private JamesTodo()
        {
            InitializeComponent();
            LoadDataInDataGridView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbTitle.Text) || string.IsNullOrWhiteSpace(rtbDescription.Text) || dtpDeadline.Value <= DateTime.Now)
            {
                MessageBox.Show("Invalid Fields, try again.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (_rowUpdate > -1)
                {
                    //dgvTasks.Rows[_rowUpdate].Cells[0].Value = tbTitle.Text;
                    //dgvTasks.Rows[_rowUpdate].Cells[2].Value = rtbDescription.Text;
                    //dgvTasks.Rows[_rowUpdate].Cells[1].Value = dtpDeadline.Value;
                    Task update = TaskService.GetTaskById(_rowUpdate);
                    update.title = tbTitle.Text;
                    update.description = rtbDescription.Text;
                    update.deadline = dtpDeadline.Value;
                    TaskService.UpdateTask(update);
                    //_rowUpdate = -1;
                    //btnAdd.Text = "Add";
                }
                else
                {
                    //dgvTasks.Rows.Add(tbTitle.Text, dtpDeadline.Value, rtbDescription.Text);
                    Task task = new Models.Task
                    {
                        title = tbTitle.Text,
                        deadline = dtpDeadline.Value,
                        description = rtbDescription.Text
                    };
                    TaskService.AddTask(task);
                }
                ClearFields();
            }
        }

        private void LoadDataInDataGridView()
        {
            List<Task> tasks = TaskService.GetAllTask();
            dgvTasks.DataSource = tasks;
            dgvTasks.Columns["cDelete"].DisplayIndex = dgvTasks.Columns.Count - 1;
            dgvTasks.Columns["cEdit"].DisplayIndex = dgvTasks.Columns.Count - 2;
            dgvTasks.Columns["cView"].DisplayIndex = dgvTasks.Columns.Count - 3;
        }

        private void ClearFields()
        {
            tbTitle.Text = "";
            rtbDescription.Text = "";
            dtpDeadline.Value = DateTime.Now;
            LoadDataInDataGridView();
        }

        private void dgvTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == 0)
                {
                    string details = "Tile : " + dgvTasks.Rows[e.RowIndex].Cells["title"].Value.ToString() + Environment.NewLine;
                    details += "Deadline : " + dgvTasks.Rows[e.RowIndex].Cells["deadline"].Value.ToString() + Environment.NewLine;
                    details += "Description : " + dgvTasks.Rows[e.RowIndex].Cells["description"].Value.ToString();

                    MessageBox.Show(details, "Task Details", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

                if (e.ColumnIndex == 1)
                {
                    tbTitle.Text = dgvTasks.Rows[e.RowIndex].Cells["title"].Value.ToString();
                    dtpDeadline.Value = Convert.ToDateTime(dgvTasks.Rows[e.RowIndex].Cells["deadline"].Value.ToString());
                    rtbDescription.Text = dgvTasks.Rows[e.RowIndex].Cells["description"].Value.ToString();
                    _rowUpdate = Convert.ToInt32(dgvTasks.Rows[e.RowIndex].Cells["id"].Value);
                    btnAdd.Text = "Edit";
                }

                if (e.ColumnIndex == 2)
                {
                    if (MessageBox.Show("Do you really want to delete this task?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        //dgvTasks.Rows.RemoveAt(e.RowIndex);
                        try
                        {
                            TaskService.DeleteTask(Convert.ToInt32(dgvTasks.Rows[e.RowIndex].Cells["id"].Value));
                            LoadDataInDataGridView();
                        }
                        catch (Exception)
                        {

                        }
                    }
                }
            }
        }
    }
}
