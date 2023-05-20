using JamesTabs.Models;
using JamesTabs.Services.ModelServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JamesTabs.UI.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = !cbShowPassword.Checked;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            List<Account> accounts = AccountService.GetAllAccounts();
            bool accountExists = false;
            foreach (var item in accounts)
            {
                if (item.email.Equals(tbEmail.Text) && item.password.Equals(tbPassword.Text))
                {
                    accountExists = true;
                }
            }
            if (accountExists)
            {
                MainForm mainForm = new MainForm();
                this.Hide();
                if (mainForm.ShowDialog() == DialogResult.OK)
                {
                    ClearFields();
                    this.Show();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Account does not exist.", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            tbEmail.Text = "";
            tbPassword.Text = "";
            cbShowPassword.Checked = false;
        }
    }
}
