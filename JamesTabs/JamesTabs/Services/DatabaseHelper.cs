using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamesTabs.Services
{
    public class DatabaseHelper
    {
        private static string _connectionString = "Server=127.0.0.1; Database=james_todo; Uid=root; Pwd=mysql;";
        private MySqlConnection _mySqlConnection;
        private static DatabaseHelper _instance;

        private DatabaseHelper()
        {
            _mySqlConnection = new MySqlConnection(_connectionString);
            try
            {
                _mySqlConnection.Open();
            }
            catch (Exception)
            {
                throw new Exception("Connection to the database failed, Please try again later.");
            }
        }
        public static DatabaseHelper Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DatabaseHelper();
                return _instance;
            }
        }
        public MySqlConnection Connection
        {
            get
            {
                return _mySqlConnection;
            }
        }
    }
}
