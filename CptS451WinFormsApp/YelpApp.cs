using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Defaults;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YelpAppEngine;
using Npgsql;

namespace CptS451WinFormsApp
{
    public partial class YelpApp : Form
    {
        private LoadDB loader = new LoadDB();
        private UpdateDB updater = new UpdateDB();
        private DataSet DataSet = new DataSet();
        private DataSet GraphSet = new DataSet();
        private List<string> selectedCategories = new List<string>();
        private List<string> selectedAttributes = new List<string>();
        BusinessDetails businessDetails;
        private Business currentSelected = new Business();
        private string currentUserID = string.Empty;
        private double userLat = 0.0;
        private double userLong = 0.0;

        public YelpApp()
        {
            InitializeComponent();
            bool dataLoaded = loader.LoadDataSource("localhost", 5432, "postgres", "jkls", "milestone2db");
            updater.LoadDataSource("localhost", 5432, "postgres", "jkls", "milestone2db");
            this.DataSet = loader.LoadDataTable("state", "business");
            this.StateList.DataSource = DataSet.Tables[0];
            this.BusinessDataGrid.DataSource = DataSet.Tables[0];
            this.StateList.DisplayMember = "state";
            label1.Text = "";

            this.InitializeSortByList();
        }

        public void InitializeSortByList()
        {
            this.comboBoxSortBy.Items.Add("Names");
            this.comboBoxSortBy.Items.Add("Highest Rating");
            this.comboBoxSortBy.Items.Add("Most Tips");
            this.comboBoxSortBy.Items.Add("Most Check-ins");
            this.comboBoxSortBy.Items.Add("Nearest");
            this.comboBoxSortBy.SelectedItem = this.comboBoxSortBy.Items[0];
        }

        private void BusinessDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            DataGridView selected = (DataGridView)sender;

            // Fill up businessDetails object with cell content.
            this.businessDetails = new BusinessDetails(
                selected.CurrentRow.Cells[1].Value.ToString(),  // Business name
                selected.CurrentRow.Cells[2].Value.ToString(),  // state
                selected.CurrentRow.Cells[3].Value.ToString(),  // city
                loader.LoadBusinessCity(this.StateList.Text).Tables[0].Rows.Count, // Count of businesses in state
                this.BusinessDataGrid.Rows.Count, // Count of Businesses in city
                ref loader, // loader pass in
                selected.CurrentRow.Cells[0].Value.ToString(), // bussiness_id
                this.currentUserID); // userID

            
            currentSelected.Name = selected.CurrentRow.Cells[1].Value.ToString();
            currentSelected.id = selected.CurrentRow.Cells[0].Value.ToString();
            currentSelected.address = selected.CurrentRow.Cells[2].Value.ToString();
            SelectedBusiness.Text = "Selected Business: ";
            BusinessNameLabel.Text = currentSelected.Name;
            BusinessAddressLabel.Text = currentSelected.address;
            HoursLabel.Text = GetHours();
            SelectedAttributesBox.DataSource = GetAttributes();
            SelectedCategoriesBox.DataSource = GetCategories();
            CheckInBuffer.Text = "";
        }

        private string GetHours()
        {
            DateTime dateTime = DateTime.Now;
            string dayOfWeekLong = dateTime.DayOfWeek.ToString();
            string dow = "";  //DateTime returns day of week in "Monday" etc form but business_hours has it in Mo, Tu, etc. form
            if (dayOfWeekLong == "Monday")
                dow = "Mo";
            if (dayOfWeekLong == "Tuesday")
                dow = "Tu";
            if (dayOfWeekLong == "Wednesday")
                dow = "We";
            if (dayOfWeekLong == "Thursday")
                dow = "Th";
            if (dayOfWeekLong == "Friday")
                dow = "Fr";
            if (dayOfWeekLong == "Saturday")
                dow = "Sa";
            if (dayOfWeekLong == "Sunday")
                dow = "Su";

            string open = "";
            string close = "";

            DataSet HoursSet = loader.LoadWithBusinessId("business_hours", currentSelected.id);
            foreach (DataRow dr in HoursSet.Tables[0].Rows)
            {
                if (dr["day_of_week"].ToString() == dow)
                {
                    open = dr["open_time"].ToString();
                    close = dr["close_time"].ToString();
                }
            } //Load the hours for that day of week

            //Convert hour.5 to hour:minute
            string[] openHours = { }; //There is most definitely a better way to do this but this is how I decided to do it and I will die on this hill
            string[] closeHours = { };
            try
            {
                openHours = open.Split('.');
            }
            catch { openHours[0] = open; }
            try
            {
                closeHours = close.Split('.');
            }
            catch { closeHours[0] = close; }

            string openHour = openHours[0];
            string openMinute = "00";
            string closeHour = closeHours[0];
            string closeMinute = "00";
            
            try
            {
                if (Int32.Parse(openHours[1]) == 5)
                {
                    openMinute = "30";
                }
            }
            catch { }
            try
            {
                if (Int32.Parse(openHours[0]) > 12)
                {
                    openHour = (Int32.Parse(openHours[0]) - 12).ToString();
                    openMinute = openMinute + " PM";
                }
                else
                {
                    openMinute = openMinute + " AM";
                }
            }
            catch { }

            try
            {
                if (Int32.Parse(closeHours[1]) == 5)
                {
                    closeMinute = "30";
                }
            }
            catch { }
            try
            {
                if (Int32.Parse(closeHours[0]) > 12)
                {
                    closeHour = (Int32.Parse(closeHours[0]) - 12).ToString();
                    closeMinute = closeMinute + " PM";
                }
                else
                {
                    closeMinute = closeMinute + " AM";
                }
            }
            catch { }            
            string r = "Today (" + dayOfWeekLong + "): \n   Open: " + openHour + ":" + openMinute + " \n   Close: " + closeHour + ":" + closeMinute;
            if (openHour == "")
                r = currentSelected.Name + " \nis not open on " + dayOfWeekLong;
            return r;
        }

        private List<string> GetAttributes()
        {
            DataSet AttributesSet = loader.LoadWithBusinessId("business_attrs", currentSelected.id);
            List<string> attrs = new List<string>();
            foreach(DataRow dr in AttributesSet.Tables[0].Rows)
            {
                if (dr["attr_value"].ToString() == "True")
                    attrs.Add(dr["attr_name"].ToString());
                else if(dr["attr_value"].ToString() != "False")
                {
                    string attrString = dr["attr_name"].ToString() + ":" + dr["attr_value"].ToString();
                    attrs.Add(attrString);
                }
            }
            return attrs;
        }

        private List<string> GetCategories()
        {
            DataSet CategoriesSet = loader.LoadWithBusinessId("business_category", currentSelected.id);
            List<string> cats = new List<string>();
            foreach (DataRow dr in CategoriesSet.Tables[0].Rows)
            {
                cats.Add(dr["category_name"].ToString());
            }
            return cats;
        }

        private void ShowTipsButton_Click(object sender, EventArgs e)
        {
            if (currentSelected.Name != "\0") //Check that a businesss is selected
                businessDetails.Show();
            else
                CheckInBuffer.Text = "No business selected. \nSelect a business before \nShowing Tips.";          
            
        }

        private void StateList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CityList.DataSource = loader.LoadBusinessCity(this.StateList.Text).Tables[0];
            this.CityList.DisplayMember = "city";
            LoadGraph(this.StateList.Text);
        }

        private void CityList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ZipcodeList.DataSource = loader.LoadBusinessZip(this.StateList.Text, this.CityList.Text).Tables[0];
            this.ZipcodeList.DisplayMember = "postal_code";
            LoadGraph(this.StateList.Text, this.CityList.Text);
        }

        private void ZipcodeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CategoriesList.DataSource = loader.LoadBusinessCategories(this.StateList.Text, this.CityList.Text, this.ZipcodeList.Text).Tables[0];
            this.AttributesList.DataSource = loader.LoadBusinessAttributes(this.StateList.Text, this.CityList.Text, this.ZipcodeList.Text).Tables[0];
            this.BusinessDataGrid.DataSource = loader.LoadBusinessInfo(this.currentUserID, this.StateList.Text, this.CityList.Text, this.ZipcodeList.Text, this.selectedAttributes.ToArray(), this.selectedCategories.ToArray(), this.comboBoxSortBy.SelectedItem.ToString()).Tables[0];
            this.BusinessDataGrid.Columns["business_id"].Visible = false;            
        }

        private void CategoriesList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView selected = (DataGridView)sender;
            string s = selected.CurrentRow.Cells[0].Value.ToString();
            if (!this.selectedCategories.Contains(s))
            {
                this.selectedCategories.Add(s);
                this.SelectedCategoriesList.DataSource = this.selectedCategories.Select(x => new { Value = x }).ToList();
                this.BusinessDataGrid.DataSource = loader.LoadBusinessInfo(this.currentUserID, this.StateList.Text, this.CityList.Text, this.ZipcodeList.Text, this.selectedAttributes.ToArray(), this.selectedCategories.ToArray(), this.comboBoxSortBy.SelectedItem.ToString()).Tables[0];
                this.BusinessDataGrid.Columns["business_id"].Visible = false;
            }
        }

        private void SelectedCategoriesList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView selected = (DataGridView)sender;
            string s = selected.CurrentRow.Cells[0].Value.ToString();
            this.selectedCategories.Remove(s);
            this.SelectedCategoriesList.DataSource = this.selectedCategories.Select(x => new { Value = x }).ToList();
            this.BusinessDataGrid.DataSource = loader.LoadBusinessInfo(this.currentUserID, this.StateList.Text, this.CityList.Text, this.ZipcodeList.Text, this.selectedAttributes.ToArray(), this.selectedCategories.ToArray(), this.comboBoxSortBy.SelectedItem.ToString()).Tables[0];
            this.BusinessDataGrid.Columns["business_id"].Visible = false;
        }

        private void AttributesList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView selected = (DataGridView)sender;
            string s = selected.CurrentRow.Cells[0].Value.ToString();
            if (!this.selectedAttributes.Contains(s))
            {
                this.selectedAttributes.Add(s);
                this.SelectedAttributesList.DataSource = this.selectedAttributes.Select(x => new { Value = x }).ToList();
                this.BusinessDataGrid.DataSource = loader.LoadBusinessInfo(this.currentUserID, this.StateList.Text, this.CityList.Text, this.ZipcodeList.Text, this.selectedAttributes.ToArray(), this.selectedCategories.ToArray(), this.comboBoxSortBy.SelectedItem.ToString()).Tables[0];
                this.BusinessDataGrid.Columns["business_id"].Visible = false;
            }
        }

        private void SelectedAttributesList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView selected = (DataGridView)sender;
            string s = selected.CurrentRow.Cells[0].Value.ToString();
            this.selectedAttributes.Remove(s);
            this.SelectedAttributesList.DataSource = this.selectedAttributes.Select(x => new { Value = x }).ToList();
            this.BusinessDataGrid.DataSource = loader.LoadBusinessInfo(this.currentUserID, this.StateList.Text, this.CityList.Text, this.ZipcodeList.Text, this.selectedAttributes.ToArray(), this.selectedCategories.ToArray(), this.comboBoxSortBy.SelectedItem.ToString()).Tables[0];
            this.BusinessDataGrid.Columns["business_id"].Visible = false;
        }

        private void LoadGraph(string s)
        {
            List<Business> businesses = new List<Business>();
            this.GraphSet = loader.LoadDataTable("*", "business");
            foreach (DataRow dr in GraphSet.Tables[0].Rows)
            {
                businesses.Add(new Business { Name = Convert.ToString(dr["name"]), city = Convert.ToString(dr["city"]), state = Convert.ToString(dr["state"]), isOpen = (bool)dr["is_open"], num_tips = dr.Field<int>("num_tips"), num_checkins = dr.Field<int>("num_checkins") });
            }

            //Sort, Filter, and Apply Max(Currently only showing top 10)
            List<Business> businessesSorted = businesses.OrderBy(o => o.num_tips).ToList();
            List<Business> businessesFiltered = businessesSorted.Where(item => item.state == s).ToList();
            List<Business> businessesMaxed = new List<Business>();
            if (businessesFiltered.Count() > 10)
            {
                for (int i = 1; i < 11; i++)
                {
                    businessesMaxed.Add(businessesFiltered[businessesFiltered.Count() - i]);
                }
                businessesFiltered = businessesMaxed;
            }
            label1.Text = "Top " + businessesFiltered.Count() + " Businesses in " + s + ", Sorted by Number of Tips";
            
            cartesianChart1.Name = "Chart 1";
            cartesianChart1.LegendLocation = LegendLocation.Bottom;
            cartesianChart1.Series.Clear();
            int x = 0;
            int barSize = 90;
            //Prototype algorithm to determine barSize - inversely proportional to length of list
            try
            {
                barSize = (businessesFiltered.Count() * 50) / (businessesFiltered.Count() * 2);
            }
            catch { }
            foreach (Business B in businessesFiltered)
            {

                LineSeries series = new LineSeries
                {
                    //Stroke = System.Windows.Media.Brushes.Red,
                    Title = B.Name,
                    DataLabels = true,
                    StrokeThickness = barSize,
                    PointGeometrySize = barSize,
                    Values = new ChartValues<ObservablePoint> //Because bar graphs are not included in LiveCharts WinForms, I have approximated them with Lines extending from (x, 0) to (x, #tips)
                                    {
                                        new ObservablePoint(x, 0),
                                        new ObservablePoint(x, B.num_tips),
                                    }
                };
                cartesianChart1.Series.Add(series);
                x++;
            }
        }

        private void LoadGraph(string s, string c)
        {
            List<Business> businesses = new List<Business>();
            this.GraphSet = loader.LoadDataTable("*", "business");
            foreach (DataRow dr in GraphSet.Tables[0].Rows)
            {
                businesses.Add(new Business { Name = Convert.ToString(dr["name"]), city = Convert.ToString(dr["city"]), state = Convert.ToString(dr["state"]), isOpen = (bool)dr["is_open"], num_tips = dr.Field<int>("num_tips"), num_checkins = dr.Field<int>("num_checkins") });
            }

            //Sort, Filter, and Apply Max(Currently only showing top 10)
            List<Business> businessesSorted = businesses.OrderBy(o => o.num_tips).ToList();
            List<Business> businessesState = businessesSorted.Where(item => item.state == s).ToList();
            List<Business> businessesFiltered = businessesState.Where(item => item.city == c).ToList();
            List<Business> businessesMaxed = new List<Business>();
            if (businessesFiltered.Count() > 10)
            {
                for (int i = 1; i < 11; i++)
                {
                    businessesMaxed.Add(businessesFiltered[businessesFiltered.Count() - i]);
                }
                businessesFiltered = businessesMaxed;
            }

            label1.Text = "Top " + businessesFiltered.Count() + " Businesses in " + c + ", " + s + ", Sorted by Number of Tips";

            cartesianChart1.Name = "Chart 1";
            cartesianChart1.LegendLocation = LegendLocation.Bottom;
            cartesianChart1.Series.Clear();
            int x = 0;
            int barSize = 90;
            //Prototype algorithm to determine barSize - inversely proportional to length of list
            try
            {
                barSize = (businessesFiltered.Count() * 50) / (businessesFiltered.Count() * 2);
            }
            catch { }
            foreach (Business B in businessesFiltered)
            {

                LineSeries series = new LineSeries
                {
                    //Stroke = System.Windows.Media.Brushes.Red,
                    Title = B.Name,
                    DataLabels = true,
                    StrokeThickness = barSize,
                    PointGeometrySize = barSize,
                    Values = new ChartValues<ObservablePoint> //Because bar graphs are not included in LiveCharts WinForms, I have approximated them with Lines extending from (x, 0) to (x, #tips)
                                    {
                                        new ObservablePoint(x, 0),
                                        new ObservablePoint(x, B.num_tips),
                                    }
                };
                cartesianChart1.Series.Add(series);
                x++;
            }
        }

        private void LoadCheckinChart(string bId, string bName)
        {

            int barSize = 20;
            this.GraphSet = loader.LoadWithBusinessId("business_checkin", bId);
            int jan = 0, feb = 0, mar = 0, apr = 0, may = 0, june = 0, july = 0, aug = 0, sep = 0, oct = 0, nov = 0, dec = 0;
            foreach (DataRow dr in GraphSet.Tables[0].Rows)
            {
                    string[] words = Convert.ToString(dr["date_time"]).Split('/');
                    string month = words[0];
                    if (month == "1")
                        jan += 1;
                    else if (month == "2")
                        feb += 1;
                    else if (month == "3")
                        mar += 1;
                    else if (month == "4")
                        apr += 1;
                    else if (month == "5")
                        may += 1;
                    else if (month == "6")
                        june += 1;
                    else if (month == "7")
                        july += 1;
                    else if (month == "8")
                        aug += 1;
                    else if (month == "9")
                        sep += 1;
                    else if (month == "10")
                        oct += 1;
                    else if (month == "11")
                        nov += 1;
                    else if (month == "12")
                        dec += 1;                
            }

            label1.Text = "Number of Check-ins per Month for " + bName;
            cartesianChart1.Name = "Chart 1";
            cartesianChart1.LegendLocation = LegendLocation.Bottom;
            cartesianChart1.Series.Clear();

            LineSeries janS = new LineSeries
            {
                Title = "January",
                DataLabels = true,
                StrokeThickness = barSize,
                PointGeometrySize = barSize,
                Values = new ChartValues<ObservablePoint> 
                                    {
                                        new ObservablePoint(1, 0),
                                        new ObservablePoint(1, jan),
                                    }
            };
            cartesianChart1.Series.Add(janS);

            LineSeries febS = new LineSeries
            {
                Title = "February",
                DataLabels = true,
                StrokeThickness = barSize,
                PointGeometrySize = barSize,
                Values = new ChartValues<ObservablePoint>
                                    {
                                        new ObservablePoint(2, 0),
                                        new ObservablePoint(2, feb),
                                    }
            };
            cartesianChart1.Series.Add(febS);

            LineSeries marS = new LineSeries
            {
                Title = "March",
                DataLabels = true,
                StrokeThickness = barSize,
                PointGeometrySize = barSize,
                Values = new ChartValues<ObservablePoint>
                                    {
                                        new ObservablePoint(3, 0),
                                        new ObservablePoint(3, mar),
                                    }
            };
            cartesianChart1.Series.Add(marS);

            LineSeries aprS = new LineSeries
            {
                Title = "April",
                DataLabels = true,
                StrokeThickness = barSize,
                PointGeometrySize = barSize,
                Values = new ChartValues<ObservablePoint>
                                    {
                                        new ObservablePoint(4, 0),
                                        new ObservablePoint(4, apr),
                                    }
            };
            cartesianChart1.Series.Add(aprS);

            LineSeries mayS = new LineSeries
            {
                Title = "May",
                DataLabels = true,
                StrokeThickness = barSize,
                PointGeometrySize = barSize,
                Values = new ChartValues<ObservablePoint>
                                    {
                                        new ObservablePoint(5, 0),
                                        new ObservablePoint(5, may),
                                    }
            };
            cartesianChart1.Series.Add(mayS);

            LineSeries juneS = new LineSeries
            {
                Title = "June",
                DataLabels = true,
                StrokeThickness = barSize,
                PointGeometrySize = barSize,
                Values = new ChartValues<ObservablePoint>
                                    {
                                        new ObservablePoint(6, 0),
                                        new ObservablePoint(6, june),
                                    }
            };
            cartesianChart1.Series.Add(juneS);

            LineSeries julyS = new LineSeries
            {
                Title = "July",
                DataLabels = true,
                StrokeThickness = barSize,
                PointGeometrySize = barSize,
                Values = new ChartValues<ObservablePoint>
                                    {
                                        new ObservablePoint(7, 0),
                                        new ObservablePoint(7, july),
                                    }
            };
            cartesianChart1.Series.Add(julyS);

            LineSeries augS = new LineSeries
            {
                Title = "August",
                DataLabels = true,
                StrokeThickness = barSize,
                PointGeometrySize = barSize,
                Values = new ChartValues<ObservablePoint>
                                    {
                                        new ObservablePoint(8, 0),
                                        new ObservablePoint(8, aug),
                                    }
            };
            cartesianChart1.Series.Add(augS);

            LineSeries sepS = new LineSeries
            {
                Title = "September",
                DataLabels = true,
                StrokeThickness = barSize,
                PointGeometrySize = barSize,
                Values = new ChartValues<ObservablePoint>
                                    {
                                        new ObservablePoint(9, 0),
                                        new ObservablePoint(9, sep),
                                    }
            };
            cartesianChart1.Series.Add(sepS);

            LineSeries octS = new LineSeries
            {
                Title = "October",
                DataLabels = true,
                StrokeThickness = barSize,
                PointGeometrySize = barSize,
                Values = new ChartValues<ObservablePoint>
                                    {
                                        new ObservablePoint(10, 0),
                                        new ObservablePoint(10, oct),
                                    }
            };
            cartesianChart1.Series.Add(octS);

            LineSeries novS = new LineSeries
            {
                Title = "November",
                DataLabels = true,
                StrokeThickness = barSize,
                PointGeometrySize = barSize,
                Values = new ChartValues<ObservablePoint>
                                    {
                                        new ObservablePoint(11, 0),
                                        new ObservablePoint(11, nov),
                                    }
            };
            cartesianChart1.Series.Add(novS);

            LineSeries decS = new LineSeries
            {
                Title = "December",
                DataLabels = true,
                StrokeThickness = barSize,
                PointGeometrySize = barSize,
                Values = new ChartValues<ObservablePoint>
                                    {
                                        new ObservablePoint(12, 0),
                                        new ObservablePoint(12, dec),
                                    }
            };
            cartesianChart1.Series.Add(decS);
        }

        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        private void CheckInButton_Click(object sender, EventArgs e) //Check In Button
        {
            if (currentSelected.Name != "\0") //Check for business selected
            {
                StringBuilder sql = new StringBuilder();
                DateTime dateTime = DateTime.Now;
                string dt = dateTime.ToString("yyyy-MM-dd HH:mm:ss");

                sql.Append("INSERT INTO business_checkin (business_id, date_time) VALUES (\'");
                sql.Append(currentSelected.id);
                sql.Append("\', \'");
                sql.Append(dt);
                sql.Append("\');");

                NpgsqlCommand adapter = new NpgsqlCommand(sql.ToString(), this.loader.getConnection());
                adapter.ExecuteNonQuery();

                CheckInBuffer.Text = "Checked in! \nLoad Graph to update";           

                this.CityList.DataSource = loader.LoadBusinessCity(this.StateList.Text).Tables[0]; //Update list


            }
            else
                CheckInBuffer.Text = "No business selected. \nSelect a business before \nChecking In";
        }

        private void LoadGraphButton_Click(object sender, EventArgs e)
        {
            
            
            if (currentSelected.Name != "\0")
            {
                label1.Text = "Loading Check-in Chart...";
                wait(10); //This needs to be here, or else the business details will not show until the graph is done loading                
                LoadCheckinChart(currentSelected.id, currentSelected.Name); //Load checkin chart with business details
            }
            else
                CheckInBuffer.Text = "No business selected. \nSelect a business before \nLoading Graph";
        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            this.textBoxLat.ReadOnly = false;
            this.textBoxLong.ReadOnly = false;
            this.buttonEdit.Enabled = false;
            this.buttonUpdate.Enabled = true;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string oldLat = this.textBoxLat.Text;
            string oldLong = this.textBoxLong.Text;

            this.textBoxLat.ReadOnly = true;
            this.textBoxLong.ReadOnly = true;
            this.buttonEdit.Enabled = true;
            this.buttonUpdate.Enabled = false;

            double newLat;
            double newLong;

            if (double.TryParse(this.textBoxLat.Text, out newLat) &&
                double.TryParse(this.textBoxLong.Text, out newLong))
            {
                this.userLat = newLat;
                this.userLong = newLong;

                updater.UpdateLatitude(this.currentUserID, newLat.ToString());
                updater.UpdateLongitude(this.currentUserID, newLong.ToString());
            }
            else
            {
                this.textBoxLat.Text = oldLat;
                this.textBoxLong.Text = oldLong;
            }
        }

        private void textBoxSetCurrentUser_TextChanged(object sender, EventArgs e)
        {
            this.listBoxSetCurrentUser.DataSource = loader.LoadUserIDs(this.textBoxSetCurrentUser.Text).Tables[0];
            this.listBoxSetCurrentUser.DisplayMember = "user_id";
        }

        private void listBoxSetCurrentUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            // User information
            DataRowView row = (DataRowView)this.listBoxSetCurrentUser.SelectedItem;
            this.currentUserID = row[0].ToString();
            this.textBoxName.Text = loader.LoadUserInfo(this.currentUserID).Tables[0].Rows[0].ItemArray[1].ToString();
            this.textBoxStars.Text = loader.LoadUserInfo(this.currentUserID).Tables[0].Rows[0].ItemArray[2].ToString();
            string[] yelpingSinceTemp = loader.LoadUserInfo(this.currentUserID).Tables[0].Rows[0].ItemArray[3].ToString().Split(' ');
            this.textBoxYelpingSince.Text = yelpingSinceTemp[0];
            this.textBoxTipCount.Text = loader.LoadUserInfo(this.currentUserID).Tables[0].Rows[0].ItemArray[4].ToString();
            this.textBoxTotalTipLikes.Text = loader.LoadUserInfo(this.currentUserID).Tables[0].Rows[0].ItemArray[5].ToString();
            this.textBoxLong.Text = loader.LoadUserInfo(this.currentUserID).Tables[0].Rows[0].ItemArray[6].ToString();
            this.textBoxLat.Text = loader.LoadUserInfo(this.currentUserID).Tables[0].Rows[0].ItemArray[7].ToString();
            this.textBoxUseful.Text = loader.LoadUserInfo(this.currentUserID).Tables[0].Rows[0].ItemArray[8].ToString();
            this.textBoxFunny.Text = loader.LoadUserInfo(this.currentUserID).Tables[0].Rows[0].ItemArray[9].ToString();
            this.textBoxCool.Text = loader.LoadUserInfo(this.currentUserID).Tables[0].Rows[0].ItemArray[10].ToString();
            this.textBoxFans.Text = loader.LoadUserInfo(this.currentUserID).Tables[0].Rows[0].ItemArray[11].ToString();

            // User friends list
            this.dataGridViewFriends.DataSource = loader.LoadUserFriends(this.currentUserID).Tables[0];
            UserCheck.Visible = false;
            wait(10);
            // user friend's tips
            this.dataGridViewLatestTips.DataSource = loader.LoadUserFriendsLatestTips(this.currentUserID).Tables[0];
        }

        private void ZipcodeLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBoxLong_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            this.BusinessDataGrid.DataSource = loader.LoadBusinessInfo(this.currentUserID, this.StateList.Text, this.CityList.Text, this.ZipcodeList.Text, this.selectedAttributes.ToArray(), this.selectedCategories.ToArray(), this.comboBoxSortBy.SelectedItem.ToString()).Tables[0];
        }

        private void checkedListPrices_SelectedIndexChanged(object sender, EventArgs e)
        {
            wait(100);
            foreach (object item in this.checkedListPrices.CheckedItems)
            {
                switch (item.ToString())
                {
                    case "$":
                        if (!this.selectedAttributes.Contains("RestaurantsPriceRange2_1"))
                            this.selectedAttributes.Add("RestaurantsPriceRange2_1");
                        break;
                    case "$$":
                        if (!this.selectedAttributes.Contains("RestaurantsPriceRange2_2"))
                            this.selectedAttributes.Add("RestaurantsPriceRange2_2");
                        break;
                    case "$$$":
                        if (!this.selectedAttributes.Contains("RestaurantsPriceRange2_3"))
                            this.selectedAttributes.Add("RestaurantsPriceRange2_3");
                        break;
                    case "$$$$":
                        if (!this.selectedAttributes.Contains("RestaurantsPriceRange2_4"))
                            this.selectedAttributes.Add("RestaurantsPriceRange2_4");
                        break;
                }
                
            }

            if (!this.checkedListPrices.CheckedItems.Contains("$"))           
                this.selectedAttributes.Remove("RestaurantsPriceRange2_1");
            if (!this.checkedListPrices.CheckedItems.Contains("$$"))
                this.selectedAttributes.Remove("RestaurantsPriceRange2_2");
            if (!this.checkedListPrices.CheckedItems.Contains("$$$"))
                this.selectedAttributes.Remove("RestaurantsPriceRange2_3");
            if (!this.checkedListPrices.CheckedItems.Contains("$$$$"))
                this.selectedAttributes.Remove("RestaurantsPriceRange2_4");

            this.SelectedAttributesList.DataSource = this.selectedAttributes.Select(x => new { Value = x }).ToList();
            this.BusinessDataGrid.DataSource = loader.LoadBusinessInfo(this.currentUserID, this.StateList.Text, this.CityList.Text, this.ZipcodeList.Text, this.selectedAttributes.ToArray(), this.selectedCategories.ToArray(), this.comboBoxSortBy.SelectedItem.ToString()).Tables[0];
            this.BusinessDataGrid.Columns["business_id"].Visible = false;
        }
    }
}
