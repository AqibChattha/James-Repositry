using JamesTabs.Models;
using JamesTabs.Services.ModelServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JamesTabs.UI.Components
{
    public partial class Accounts : UserControl
    {
        private int _rowUpdateDelete = -1;

        private static Accounts _instance;
        public static Accounts Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Accounts();
                }
                return _instance;
            }
        }

        private Accounts()
        {
            InitializeComponent();
            tbPassword.UseSystemPasswordChar = true;
            LoadDataInDataGridView();
            panel2.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                MessageBox.Show("Please enter an email.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsValidEmail(tbEmail.Text))
            {
                MessageBox.Show("Invalid email please enter a valid email, try again.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                MessageBox.Show("Please enter an password.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tbPassword.Text.Length < 8)
            {
                MessageBox.Show("The length of the password should be 8 or more.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (_rowUpdateDelete > 0)
                {
                    Account update = AccountService.GetAccountById(_rowUpdateDelete);
                    update.email = tbEmail.Text;
                    update.password = tbPassword.Text;
                    AccountService.UpdateAccount(update);

                    MessageBox.Show("Account updated successfully.", "Account Updated", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    Account account = new Account
                    {
                        email = tbEmail.Text,
                        password = tbPassword.Text
                    };
                    AccountService.AddAccount(account);

                    MessageBox.Show("Account created successfully.", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                ClearFields();
            }
        }

        private void LoadDataInDataGridView()
        {
            List<Account> tasks = AccountService.GetAllAccounts();
            dgvAccounts.DataSource = tasks;
            //dgvAccounts.Columns["cDelete"].DisplayIndex = dgvAccounts.Columns.Count - 1;
            //dgvAccounts.Columns["cEdit"].DisplayIndex = dgvAccounts.Columns.Count - 2;
            //dgvAccounts.Columns["cView"].DisplayIndex = dgvAccounts.Columns.Count - 3;
        }

        private void ClearFields()
        {
            _rowUpdateDelete = -1;
            tbEmail.Text = "";
            tbPassword.Text = "";
            btnAdd.Text = "Add Account";
            LoadDataInDataGridView();
            panel2.Visible = false;
            btnDelete.Visible = true;
        }

        private void dgvTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                _rowUpdateDelete = Convert.ToInt32(dgvAccounts.Rows[e.RowIndex].Cells["id"].Value);
                tbEmail.Text = dgvAccounts.Rows[e.RowIndex].Cells["email"].Value.ToString();
                tbPassword.Text = dgvAccounts.Rows[e.RowIndex].Cells["password"].Value.ToString();
                btnAdd.Text = "Edit Accounts";
                panel2.Visible = true;

                //if (e.ColumnIndex == 0)
                //{
                //    string details = "Email : " + dgvAccounts.Rows[e.RowIndex].Cells["email"].Value.ToString() + Environment.NewLine;
                //    details += "Password : " + dgvAccounts.Rows[e.RowIndex].Cells["password"].Value.ToString() + Environment.NewLine;

                //    MessageBox.Show(details, "Account Details", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //}

                //if (e.ColumnIndex == 1)
                //{
                //    tbEmail.Text = dgvAccounts.Rows[e.RowIndex].Cells["email"].Value.ToString();
                //    tbPassword.Text = dgvAccounts.Rows[e.RowIndex].Cells["password"].Value.ToString();
                //    _rowUpdate = Convert.ToInt32(dgvAccounts.Rows[e.RowIndex].Cells["id"].Value);
                //    btnAdd.Text = "Edit Accounts";
                //}

                //if (e.ColumnIndex == 2)
                //{
                //    if (MessageBox.Show("Do you really want to delete this account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                //    {
                //        try
                //        {
                //            AccountService.DeleteAccount(Convert.ToInt32(dgvAccounts.Rows[e.RowIndex].Cells["id"].Value));
                //            LoadDataInDataGridView();
                //        }
                //        catch (Exception)
                //        {

                //        }
                //    }
                //}
            }
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = !cbShowPassword.Checked;
        }

        private bool IsValidEmail(string email)
        {
            string trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var address = new MailAddress(email);
                return address.Address == trimmedEmail;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void btnShowAdd_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            btnDelete.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_rowUpdateDelete > 0)
            {
                if (MessageBox.Show("Do you really want to delete this account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        AccountService.DeleteAccount(_rowUpdateDelete);
                        ClearFields();
                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
