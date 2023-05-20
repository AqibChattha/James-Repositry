using JamesTabs.Models;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JamesTabs.Services.ModelServices
{
    public static class AccountService
    {

        public static void AddAccount(Account account)
        {
            using (var cmd = new MySqlCommand("Insert Into Accounts (email, password) values (@email, @password)", DatabaseHelper.Instance.Connection))
            {
                cmd.Parameters.AddWithValue("@email", account.email);
                cmd.Parameters.AddWithValue("@password", account.password);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {

                }
            }
        }

        public static List<Account> GetAllAccounts()
        {
            List<Account> Accounts = new List<Account>();
            using (var cmd = new MySqlCommand("Select * from Accounts;", DatabaseHelper.Instance.Connection))
            {
                try
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Account newAccount = new Account
                            {
                                id = reader.GetInt32(0),
                                email = reader.GetString(1),
                                password = reader.GetString(2)
                            };
                            Accounts.Add(newAccount);
                        }
                    }

                }
                catch (Exception)
                {

                }
            }
            return Accounts;
        }

        public static Account GetAccountById(int id)
        {
            Account Account = new Account();
            using (var cmd = new MySqlCommand("Select * from Accounts where id = @id;", DatabaseHelper.Instance.Connection))
            {
                cmd.Parameters.AddWithValue("@id", id);
                try
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Account newAccount = new Account
                            {
                                id = reader.GetInt32(0),
                                email = reader.GetString(1),
                                password = reader.GetString(2)
                            };
                            return newAccount;
                        }
                    }

                }
                catch (Exception)
                {

                }
            }
            return null;
        }

        public static void UpdateAccount(Account Account)
        {
            using (var cmd = new MySqlCommand("Update Accounts set email = @email, password = @password where id = @id;", DatabaseHelper.Instance.Connection))
            {
                cmd.Parameters.AddWithValue("@id", Account.id);
                cmd.Parameters.AddWithValue("@email", Account.email);
                cmd.Parameters.AddWithValue("@password", Account.password);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {

                }
            }
        }

        public static void DeleteAccount(int id)
        {
            using (var cmd = new MySqlCommand("Delete from Accounts where id = @id;", DatabaseHelper.Instance.Connection))
            {
                cmd.Parameters.AddWithValue("@id", id);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {

                }
            }
        }
    }
}
