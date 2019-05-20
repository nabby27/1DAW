using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Comensales
{
    class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public DBConnect()
        {
            server = "localhost";
            database = "COMENSALES";
            uid = "root";
            password = "";
            string connectionString =   "SERVER=" + server + ";" + 
                                        "UID=" + uid + ";" + 
                                        "PASSWORD=" + password + ";" +
                                        "DATABASE=" + database + ";";
            connection = new MySqlConnection(connectionString);
        }

        private bool openConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException)
            {
                return false;
            }
        }
 
        private bool closeConn() {
            try {
                connection.Close();
                return true;
            }
            catch (MySqlException) {
                return false;
            }
        }

        public void insert(String query) {
            if (this.openConnection()) {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.closeConnection();
            }
        }

        public void update(String query) {
            if (this.openConnection()) {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.closeConn();
            }
        }

        public void delete(String query) {
            if (this.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.closeConn();
            }
        }

        public MySqlDataReader select(String query) {
            if (this.openConnection()) 
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                return cmd.ExecuteReader();
            } else {
                return null;
            }
        }

        public void closeConnection()
        {
            closeConn();
        }

    }

}
