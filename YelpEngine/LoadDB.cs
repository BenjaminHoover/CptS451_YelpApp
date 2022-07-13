using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace YelpAppEngine
{
    public class LoadDB
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

        public DataSet LoadDataTable(string selection, string source)
        {
            DataSet data = new DataSet();
            StringBuilder sql = new StringBuilder();

            sql.Append("SELECT DISTINCT ");
            sql.Append(selection);
            sql.Append(" FROM ");
            sql.Append(source);

            this.dataAdapter = new NpgsqlDataAdapter(sql.ToString(), connection);
            data.Reset();
            this.dataAdapter.Fill(data);

            return data;
        }

        public DataSet LoadBusinessCity(string state)
        {
            DataSet data = new DataSet();
            StringBuilder sql = new StringBuilder();

            sql.Append("SELECT DISTINCT city FROM business WHERE state = '");
            sql.Append(state);
            sql.Append("'");

            this.dataAdapter = new NpgsqlDataAdapter(sql.ToString(), connection);
            data.Reset();
            this.dataAdapter.Fill(data);

            return data;
        }

        public DataSet LoadBusinessZip(string state, string city)
        {
            DataSet data = new DataSet();
            StringBuilder sql = new StringBuilder();

            sql.Append("SELECT DISTINCT postal_code FROM business WHERE (state = \'");
            sql.Append(state);
            sql.Append("\') AND (city = \'");
            sql.Append(city);
            sql.Append("\')");

            this.dataAdapter = new NpgsqlDataAdapter(sql.ToString(), connection);
            data.Reset();
            this.dataAdapter.Fill(data);

            return data;
        }

        public DataSet LoadBusinessCategories(string state, string city, string zipcode)
        {
            DataSet data = new DataSet();
            StringBuilder sql = new StringBuilder();

            sql.Append("SELECT DISTINCT category_name FROM business_category WHERE business_id in (");
            sql.Append("SELECT business_id FROM business WHERE (state = \'");
            sql.Append(state);
            sql.Append("\') AND (city = \'");
            sql.Append(city);
            sql.Append("\') AND (postal_code = \'");
            sql.Append(zipcode);
            sql.Append("\'))");

            this.dataAdapter = new NpgsqlDataAdapter(sql.ToString(), connection);
            data.Reset();
            this.dataAdapter.Fill(data);

            return data;
        }

        public DataSet LoadBusinessAttributes(string state, string city, string zipcode)
        {
            DataSet data = new DataSet();
            StringBuilder sql = new StringBuilder();

            sql.Append("SELECT DISTINCT attr_name FROM business_attrs, ");
            sql.Append("(SELECT business_id FROM business WHERE (state = \'");
            sql.Append(state);
            sql.Append("\') AND (city = \'");
            sql.Append(city);
            sql.Append("\') AND (postal_code = \'");
            sql.Append(zipcode);
            sql.Append("\')) as b ");
            sql.Append("WHERE business_attrs.business_id = b.business_id AND (attr_name != 'RestaurantsPriceRange2_1') AND (attr_name != 'RestaurantsPriceRange2_2')" +
                "AND (attr_name != 'RestaurantsPriceRange2_3') AND (attr_name != 'RestaurantsPriceRange2_4')");

            this.dataAdapter = new NpgsqlDataAdapter(sql.ToString(), connection);
            data.Reset();
            this.dataAdapter.Fill(data);

            return data;
        }

        public DataSet LoadBusinessPriceRanges(string state, string city, string zipcode)
        {
            DataSet data = new DataSet();
            StringBuilder sql = new StringBuilder();

            sql.Append("SELECT DISTINCT attr_name FROM business_attrs, ");
            sql.Append("(SELECT business_id FROM business WHERE (state = \'");
            sql.Append(state);
            sql.Append("\') AND (city = \'");
            sql.Append(city);
            sql.Append("\') AND (postal_code = \'");
            sql.Append(zipcode);
            sql.Append("\')) as b ");
            sql.Append("WHERE business_attrs.business_id = b.business_id AND ((attr_name = 'RestaurantsPriceRange2_1') OR (attr_name = 'RestaurantsPriceRange2_2')" +
                "OR (attr_name = 'RestaurantsPriceRange2_3') OR (attr_name = 'RestaurantsPriceRange2_4'))");

            this.dataAdapter = new NpgsqlDataAdapter(sql.ToString(), connection);
            data.Reset();
            this.dataAdapter.Fill(data);

            return data;
        }

        public DataSet LoadBusinessInfo(string userID, string state, string city, string zipcode, string[] attributes, string[] categories, string sortBy)
        {
            DataSet data = new DataSet();
            StringBuilder sql = new StringBuilder();

            sql.Append("SELECT DISTINCT b.business_id, b.name, b.address, b.state, b.city, b.num_tips, b.num_checkins, b.stars, b.distance FROM ");
            sql.Append("(SELECT DISTINCT business.business_id, business.name, business.address, business.state, business.city, business.num_tips, business.num_checkins, business.stars, " +
                "(7917.6 * ASIN(SQRT(POW(SIN((business.latitude-users.latitude)*PI()/360), 2) + COS(users.latitude * PI() / 180) * COS(business.latitude * PI() / 180) * POW(SIN((business.longitude - users.longitude) * PI() / 360), 2)))) as distance " +
                "FROM users, business WHERE users.user_id=\'");
            sql.Append(userID);
            sql.Append("\' AND business.state= \'");
            sql.Append(state);
            sql.Append("\' AND business.city= \'");
            sql.Append(city);
            sql.Append("\' AND business.postal_code= \'");
            sql.Append(zipcode);
            sql.Append("\') as b");
           
            if (attributes.Length > 0) // handle attributes
            {
                sql.Append(" NATURAL JOIN ((SELECT DISTINCT business_id FROM business_attrs WHERE attr_name = \'");
                sql.Append(attributes[0] + "\')");
                for (int attrIndex = 1; attrIndex < attributes.Length; attrIndex++)
                {
                    sql.Append(" INTERSECT (SELECT DISTINCT business_id FROM business_attrs WHERE attr_name = \'");
                    sql.Append(attributes[attrIndex]);
                    sql.Append("\')");
                }
                if (attributes.Length == 1)
                {
                    //sql.Append(")");
                }
                sql.Append(") as att");
            }

            if (categories.Length > 0) // handle categories
            {
                sql.Append(" NATURAL JOIN ((SELECT DISTINCT business_id FROM business_category  WHERE category_name = \'");
                sql.Append(categories[0] + "\')");
                for (int catIndex = 1; catIndex < categories.Length; catIndex++)
                {
                    sql.Append(" INTERSECT (SELECT DISTINCT business_id FROM business_category  WHERE category_name = \'");
                    sql.Append(categories[catIndex]);
                    sql.Append("\')");
                }
                sql.Append(") as cat");
            }

            switch (sortBy)
            {
                case "Names":
                    sql.Append(" ORDER BY b.name");
                    break;
                case "Highest Rating":
                    sql.Append(" ORDER BY b.stars DESC");
                    break;
                case "Most Tips":
                    sql.Append(" ORDER BY b.num_tips DESC");
                    break;
                case "Most Check-ins":
                    sql.Append(" ORDER BY b.num_checkins DESC");
                    break;
                case "Nearest":
                    sql.Append(" ORDER BY b.distance");
                    break;
            }

            this.dataAdapter = new NpgsqlDataAdapter(sql.ToString(), connection);
            data.Reset();
            this.dataAdapter.Fill(data);

            return data;
        }

        public DataSet LoadBusinessTips(string state, string city, string zipcode, string id)
        {
            DataSet data = new DataSet();
            StringBuilder sql = new StringBuilder();

            sql.Append("SELECT business_tip.date_time, users.name, users.user_id, business_tip.likes, business_tip.body FROM business_tip, users WHERE business_tip.business_id = \'");
            sql.Append(id);
            sql.Append("\' AND users.user_id = business_tip.user_id");

            this.dataAdapter = new NpgsqlDataAdapter(sql.ToString(), connection);
            data.Reset();
            this.dataAdapter.Fill(data);

            return data;
        }

        public DataSet LoadFriendsBusinessTips(string userID, string id)
        {
            DataSet data = new DataSet();
            StringBuilder sql = new StringBuilder();

            sql.Append(" SELECT f.name, business.name, business_tip.body, business_tip.date_time");
            sql.Append(" FROM business_tip");
            sql.Append(" INNER JOIN");
            sql.Append(" (SELECT name, user_id");
            sql.Append(" FROM friends, users");
            sql.Append(" WHERE \'");
            sql.Append(userID);
            sql.Append("\' = friends_of AND user_id = friends_with) as f ON business_tip.user_id = f.user_id");
            sql.Append(" INNER JOIN business");
            sql.Append(" ON business.business_id = business_tip.business_id");
            sql.Append(" WHERE business.business_id = \'");
            sql.Append(id);
            sql.Append("\'");

            this.dataAdapter = new NpgsqlDataAdapter(sql.ToString(), connection);
            data.Reset();
            this.dataAdapter.Fill(data);

            return data;
        }

        public DataSet LoadUserIDs(string userName)
        {
            DataSet data = new DataSet();
            StringBuilder sql = new StringBuilder();

            sql.Append("SELECT user_id FROM users WHERE name = \'");
            sql.Append(userName);
            sql.Append("\'");

            this.dataAdapter = new NpgsqlDataAdapter(sql.ToString(), connection);
            data.Reset();
            this.dataAdapter.Fill(data);

            return data;
        }

        public DataSet LoadUserInfo(string userID)
        {
            DataSet data = new DataSet();
            StringBuilder sql = new StringBuilder();

            sql.Append("SELECT * FROM users WHERE user_id = \'");
            sql.Append(userID);
            sql.Append("\'");

            this.dataAdapter = new NpgsqlDataAdapter(sql.ToString(), connection);
            data.Reset();
            this.dataAdapter.Fill(data);

            return data;
        }

        public DataSet LoadUserFriends(string userID)
        {
            DataSet data = new DataSet();
            StringBuilder sql = new StringBuilder();

            sql.Append("SELECT DISTINCT name, total_tip_like, average_stars, yelping_since FROM users, friends WHERE friends_with = \'");
            sql.Append(userID);
            sql.Append("\' AND user_id = friends_of");

            this.dataAdapter = new NpgsqlDataAdapter(sql.ToString(), connection);
            data.Reset();
            this.dataAdapter.Fill(data);

            return data;
        }

        public DataSet LoadUserFriendsLatestTips(string userID)
        {
            DataSet data = new DataSet();
            StringBuilder sql = new StringBuilder();

            sql.Append("SELECT f.name, business.name, business_tip.body, business_tip.date_time ");
            sql.Append(" FROM business_tip INNER JOIN ");
            sql.Append(" (SELECT name, user_id FROM friends, users WHERE \'");
            sql.Append(userID);       
            sql.Append("\' = friends_of AND user_id = friends_with) as f ");
            sql.Append("ON business_tip.user_id = f.user_id");
            sql.Append(" INNER JOIN business ON business.business_id = business_tip.business_id ");
            sql.Append(" WHERE (f.user_id, business_tip.date_time) IN ");
            sql.Append(" (SELECT business_tip.user_id, MAX(business_tip.date_time) as date FROM business_tip GROUP BY business_tip.user_id) ");

            this.dataAdapter = new NpgsqlDataAdapter(sql.ToString(), connection);
            data.Reset();
            this.dataAdapter.Fill(data);

            return data;
        }

        public DataSet LoadWithBusinessId(string source, string bId)
        {
            DataSet data = new DataSet();
            StringBuilder sql = new StringBuilder();

            sql.Append("SELECT DISTINCT *");
            sql.Append(" FROM ");
            sql.Append(source);
            sql.Append(" WHERE business_id = '");
            sql.Append(bId);
            sql.Append("'");

            this.dataAdapter = new NpgsqlDataAdapter(sql.ToString(), connection);
            data.Reset();
            this.dataAdapter.Fill(data);

            return data;
        }

        public void CloseDataSource()
        {
            this.connection.Close();
        }
    }
}
