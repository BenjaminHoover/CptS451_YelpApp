using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YelpAppEngine;
using Npgsql;

namespace CptS451WinFormsApp
{
    public partial class BusinessDetails : Form
    {
        string userID;
        string businessID;
        string businessName;
        string state;
        string city;
        LoadDB loader;
        string selectedUserId;

        public BusinessDetails(string businessName, string state, string city, int numBusinessState, 
            int numBusinessCity, ref LoadDB loader, string id, string userID)
        {
            InitializeComponent();
            this.loader = loader;

            this.BusinessNameDisplay.Text = businessName;
            this.businessName = businessName;
            this.StateDisplay.Text = state;
            this.state = state;
            this.CityDisplay.Text = city;
            this.city = city;
            this.NumBusinessState.Text = numBusinessState.ToString();
            this.NumBusinessCity.Text = numBusinessCity.ToString();
            this.TipsDisplay.DataSource = loader.LoadBusinessTips(businessName, state, city, id).Tables[0];
            this.TipsDisplay.Columns["user_id"].Visible = false;
            this.TipNum.Text = this.TipsDisplay.Rows.Count.ToString();
            this.businessID = id;
            this.userID = userID;
            this.FriendsTipsDisplay.DataSource = loader.LoadFriendsBusinessTips(userID, id).Tables[0];
        }

        private void SubmitTipButton_Click(object sender, EventArgs e)
        {
            StringBuilder sql = new StringBuilder();

            DateTime dateTime = DateTime.Now;
            string dt = dateTime.ToString("yyyy-MM-dd HH:mm:ss");

            sql.Append("INSERT INTO business_tip (business_id, date_time, user_id, body, likes) VALUES (\'");
            sql.Append(this.businessID);
            sql.Append("\', \'");
            sql.Append(dt);
            sql.Append("\', \'" + this.userID + "\', \'");
            sql.Append(this.TipTextBox.Text);
            sql.Append("\', 0);");

            NpgsqlCommand adapter = new NpgsqlCommand(sql.ToString(), this.loader.getConnection());
            adapter.ExecuteNonQuery();

            this.TipsDisplay.DataSource = loader.LoadBusinessTips(businessName, state, city, businessID).Tables[0];
            this.TipsDisplay.Columns["user_id"].Visible = false;
            this.TipNum.Text = this.TipsDisplay.Rows.Count.ToString();
        }

        private void TipsDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LikeTipButton_Click(object sender, EventArgs e)
        {
            StringBuilder sql = new StringBuilder();

            DataGridViewRow row = this.TipsDisplay.Rows[this.TipsDisplay.SelectedCells[0].RowIndex];
            string dt = row.Cells["date_time"].Value.ToString();
            string id = row.Cells["user_id"].Value.ToString();

            sql.Append("UPDATE business_tip SET likes = likes + 1 WHERE business_id = \'");
            sql.Append(this.businessID);
            sql.Append("\' AND user_id = \'");
            sql.Append(id);
            sql.Append("\' AND date_time =  \'");
            sql.Append(dt);
            sql.Append("\'");

            NpgsqlCommand adapter = new NpgsqlCommand(sql.ToString(), this.loader.getConnection());
            adapter.ExecuteNonQuery();

            this.TipsDisplay.DataSource = loader.LoadBusinessTips(businessName, state, city, businessID).Tables[0];
            this.TipsDisplay.Columns["user_id"].Visible = false;
            this.TipNum.Text = this.TipsDisplay.Rows.Count.ToString();
        }
    }
}
