using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace YelpAppEngine
{
    public class UpdateDB
    {
        private NpgsqlDataAdapter dataAdapter;
        private NpgsqlConnection connection;

        public NpgsqlDataAdapter getAdapter()
        {
            return this.dataAdapter;
        }

        public NpgsqlConnection getConnection()
        {
            return this.connection;
        }

        public bool LoadDataSource(string serverName, int portNum, string userID, string password, string dbName)
        {
            try
            {
                string connstring = String.Format("Server={0};Port={1};" +
                    "User Id={2};Password={3};Database={4};",
                    serverName, portNum, userID, password, dbName);
                this.connection = new NpgsqlConnection(connstring);
                this.connection.Open();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public void UpdateLatitude(string userID, string newLat)
        {
            StringBuilder sql = new StringBuilder();

            sql.Append("UPDATE users SET latitude = \'");
            sql.Append(newLat);
            sql.Append("\'");
            sql.Append("WHERE user_id = \'");
            sql.Append(userID);
            sql.Append("\'");

            NpgsqlCommand adapter = new NpgsqlCommand(sql.ToString(), this.connection);
            adapter.ExecuteNonQuery();
        }

        public void UpdateLongitude(string userID, string newLong)
        {
            StringBuilder sql = new StringBuilder();

            sql.Append("UPDATE users SET longitude = \'");
            sql.Append(newLong);
            sql.Append("\'");
            sql.Append("WHERE user_id = \'");
            sql.Append(userID);
            sql.Append("\'");

            NpgsqlCommand adapter = new NpgsqlCommand(sql.ToString(), this.connection);
            adapter.ExecuteNonQuery();
        }
    }
}
