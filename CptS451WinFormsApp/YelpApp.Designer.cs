
namespace CptS451WinFormsApp
{
    partial class YelpApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StateLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.BusinessDataGrid = new System.Windows.Forms.DataGridView();
            this.StateList = new System.Windows.Forms.ComboBox();
            this.CityList = new System.Windows.Forms.ComboBox();
            this.ZipcodeLabel = new System.Windows.Forms.Label();
            this.ZipcodeList = new System.Windows.Forms.ComboBox();
            this.CategoriesLabel = new System.Windows.Forms.Label();
            this.BusinessesLabel = new System.Windows.Forms.Label();
            this.SelectedCategoriesLabel = new System.Windows.Forms.Label();
            this.CategoriesList = new System.Windows.Forms.DataGridView();
            this.SelectedCategoriesList = new System.Windows.Forms.DataGridView();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowTipsButton = new System.Windows.Forms.Button();
            this.CheckInButton = new System.Windows.Forms.Button();
            this.LoadGraphButton = new System.Windows.Forms.Button();
            this.SelectedBusiness = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageUserInfo = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxLong = new System.Windows.Forms.TextBox();
            this.textBoxLat = new System.Windows.Forms.TextBox();
            this.textBoxTotalTipLikes = new System.Windows.Forms.TextBox();
            this.textBoxTipCount = new System.Windows.Forms.TextBox();
            this.textBoxUseful = new System.Windows.Forms.TextBox();
            this.textBoxCool = new System.Windows.Forms.TextBox();
            this.textBoxFunny = new System.Windows.Forms.TextBox();
            this.textBoxYelpingSince = new System.Windows.Forms.TextBox();
            this.textBoxFans = new System.Windows.Forms.TextBox();
            this.textBoxStars = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.dataGridViewLatestTips = new System.Windows.Forms.DataGridView();
            this.dataGridViewFriends = new System.Windows.Forms.DataGridView();
            this.labelLatestTips = new System.Windows.Forms.Label();
            this.labelFriends = new System.Windows.Forms.Label();
            this.labelLong = new System.Windows.Forms.Label();
            this.labelLat = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelTotalTipLikes = new System.Windows.Forms.Label();
            this.labelTipCount = new System.Windows.Forms.Label();
            this.labelUseful = new System.Windows.Forms.Label();
            this.labelCool = new System.Windows.Forms.Label();
            this.labelFunny = new System.Windows.Forms.Label();
            this.labelVotes = new System.Windows.Forms.Label();
            this.labelYelpingSince = new System.Windows.Forms.Label();
            this.labelFans = new System.Windows.Forms.Label();
            this.labelStars = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelUserInfo = new System.Windows.Forms.Label();
            this.listBoxSetCurrentUser = new System.Windows.Forms.ListBox();
            this.textBoxSetCurrentUser = new System.Windows.Forms.TextBox();
            this.labelSetCurrentUser = new System.Windows.Forms.Label();
            this.tabPageBusinesses = new System.Windows.Forms.TabPage();
            this.CheckInBuffer = new System.Windows.Forms.Label();
            this.checkedListPrices = new System.Windows.Forms.CheckedListBox();
            this.comboBoxSortBy = new System.Windows.Forms.ComboBox();
            this.labelSortBy = new System.Windows.Forms.Label();
            this.CategoriesLab = new System.Windows.Forms.Label();
            this.SelectedCategoriesBox = new System.Windows.Forms.ListBox();
            this.AttributesLab = new System.Windows.Forms.Label();
            this.SelectedAttributesBox = new System.Windows.Forms.ListBox();
            this.UserCheck = new System.Windows.Forms.Label();
            this.SelectedAttributesList = new System.Windows.Forms.DataGridView();
            this.AttributesList = new System.Windows.Forms.DataGridView();
            this.AttributesLabel = new System.Windows.Forms.Label();
            this.SelectedAtrributesLabel = new System.Windows.Forms.Label();
            this.HoursLabel = new System.Windows.Forms.Label();
            this.BusinessAddressLabel = new System.Windows.Forms.Label();
            this.BusinessNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BusinessDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedCategoriesList)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPageUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLatestTips)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFriends)).BeginInit();
            this.tabPageBusinesses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedAttributesList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttributesList)).BeginInit();
            this.SuspendLayout();
            // 
            // StateLabel
            // 
            this.StateLabel.AutoSize = true;
            this.StateLabel.Location = new System.Drawing.Point(17, 15);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(32, 13);
            this.StateLabel.TabIndex = 2;
            this.StateLabel.Tag = "StateLabel";
            this.StateLabel.Text = "State";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(25, 36);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(24, 13);
            this.CityLabel.TabIndex = 3;
            this.CityLabel.Tag = "CityLabel";
            this.CityLabel.Text = "City";
            // 
            // BusinessDataGrid
            // 
            this.BusinessDataGrid.AllowUserToAddRows = false;
            this.BusinessDataGrid.AllowUserToDeleteRows = false;
            this.BusinessDataGrid.AllowUserToResizeColumns = false;
            this.BusinessDataGrid.AllowUserToResizeRows = false;
            this.BusinessDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BusinessDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.BusinessDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BusinessDataGrid.Location = new System.Drawing.Point(41, 355);
            this.BusinessDataGrid.Margin = new System.Windows.Forms.Padding(1);
            this.BusinessDataGrid.MultiSelect = false;
            this.BusinessDataGrid.Name = "BusinessDataGrid";
            this.BusinessDataGrid.ReadOnly = true;
            this.BusinessDataGrid.RowHeadersVisible = false;
            this.BusinessDataGrid.RowHeadersWidth = 62;
            this.BusinessDataGrid.RowTemplate.Height = 28;
            this.BusinessDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BusinessDataGrid.Size = new System.Drawing.Size(628, 173);
            this.BusinessDataGrid.TabIndex = 4;
            this.BusinessDataGrid.Tag = "BusinessDataGrid";
            this.BusinessDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BusinessDataGrid_CellContentClick);
            // 
            // StateList
            // 
            this.StateList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StateList.FormattingEnabled = true;
            this.StateList.Location = new System.Drawing.Point(53, 15);
            this.StateList.Margin = new System.Windows.Forms.Padding(1);
            this.StateList.Name = "StateList";
            this.StateList.Size = new System.Drawing.Size(264, 21);
            this.StateList.TabIndex = 5;
            this.StateList.Tag = "StateList";
            this.StateList.SelectedIndexChanged += new System.EventHandler(this.StateList_SelectedIndexChanged);
            // 
            // CityList
            // 
            this.CityList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CityList.FormattingEnabled = true;
            this.CityList.Location = new System.Drawing.Point(53, 36);
            this.CityList.Margin = new System.Windows.Forms.Padding(1);
            this.CityList.Name = "CityList";
            this.CityList.Size = new System.Drawing.Size(264, 21);
            this.CityList.TabIndex = 6;
            this.CityList.Tag = "CityList";
            this.CityList.SelectedIndexChanged += new System.EventHandler(this.CityList_SelectedIndexChanged);
            // 
            // ZipcodeLabel
            // 
            this.ZipcodeLabel.AutoSize = true;
            this.ZipcodeLabel.Location = new System.Drawing.Point(6, 57);
            this.ZipcodeLabel.Name = "ZipcodeLabel";
            this.ZipcodeLabel.Size = new System.Drawing.Size(46, 13);
            this.ZipcodeLabel.TabIndex = 7;
            this.ZipcodeLabel.Tag = "ZipcodeLabel";
            this.ZipcodeLabel.Text = "Zipcode";
            this.ZipcodeLabel.Click += new System.EventHandler(this.ZipcodeLabel_Click);
            // 
            // ZipcodeList
            // 
            this.ZipcodeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ZipcodeList.FormattingEnabled = true;
            this.ZipcodeList.Location = new System.Drawing.Point(53, 57);
            this.ZipcodeList.Margin = new System.Windows.Forms.Padding(1);
            this.ZipcodeList.Name = "ZipcodeList";
            this.ZipcodeList.Size = new System.Drawing.Size(264, 21);
            this.ZipcodeList.TabIndex = 8;
            this.ZipcodeList.Tag = "ZipcodeList";
            this.ZipcodeList.SelectedIndexChanged += new System.EventHandler(this.ZipcodeList_SelectedIndexChanged);
            // 
            // CategoriesLabel
            // 
            this.CategoriesLabel.AutoSize = true;
            this.CategoriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriesLabel.Location = new System.Drawing.Point(11, 92);
            this.CategoriesLabel.Name = "CategoriesLabel";
            this.CategoriesLabel.Size = new System.Drawing.Size(74, 16);
            this.CategoriesLabel.TabIndex = 9;
            this.CategoriesLabel.Tag = "CategoriesLabel";
            this.CategoriesLabel.Text = "Categories";
            // 
            // BusinessesLabel
            // 
            this.BusinessesLabel.AutoSize = true;
            this.BusinessesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusinessesLabel.Location = new System.Drawing.Point(11, 331);
            this.BusinessesLabel.Name = "BusinessesLabel";
            this.BusinessesLabel.Size = new System.Drawing.Size(78, 16);
            this.BusinessesLabel.TabIndex = 11;
            this.BusinessesLabel.Tag = "BusinessesLabel";
            this.BusinessesLabel.Text = "Businesses";
            // 
            // SelectedCategoriesLabel
            // 
            this.SelectedCategoriesLabel.AutoSize = true;
            this.SelectedCategoriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedCategoriesLabel.Location = new System.Drawing.Point(371, 92);
            this.SelectedCategoriesLabel.Name = "SelectedCategoriesLabel";
            this.SelectedCategoriesLabel.Size = new System.Drawing.Size(131, 16);
            this.SelectedCategoriesLabel.TabIndex = 13;
            this.SelectedCategoriesLabel.Tag = "SelectedCategoriesLabel";
            this.SelectedCategoriesLabel.Text = "Selected Categories";
            // 
            // CategoriesList
            // 
            this.CategoriesList.AllowUserToAddRows = false;
            this.CategoriesList.AllowUserToDeleteRows = false;
            this.CategoriesList.AllowUserToResizeColumns = false;
            this.CategoriesList.AllowUserToResizeRows = false;
            this.CategoriesList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CategoriesList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CategoriesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoriesList.ColumnHeadersVisible = false;
            this.CategoriesList.Location = new System.Drawing.Point(42, 119);
            this.CategoriesList.Margin = new System.Windows.Forms.Padding(1);
            this.CategoriesList.MultiSelect = false;
            this.CategoriesList.Name = "CategoriesList";
            this.CategoriesList.ReadOnly = true;
            this.CategoriesList.RowHeadersVisible = false;
            this.CategoriesList.RowHeadersWidth = 62;
            this.CategoriesList.RowTemplate.Height = 28;
            this.CategoriesList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CategoriesList.Size = new System.Drawing.Size(261, 91);
            this.CategoriesList.TabIndex = 14;
            this.CategoriesList.Tag = "CategoriesList";
            this.CategoriesList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoriesList_CellContentClick);
            // 
            // SelectedCategoriesList
            // 
            this.SelectedCategoriesList.AllowUserToAddRows = false;
            this.SelectedCategoriesList.AllowUserToDeleteRows = false;
            this.SelectedCategoriesList.AllowUserToResizeColumns = false;
            this.SelectedCategoriesList.AllowUserToResizeRows = false;
            this.SelectedCategoriesList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SelectedCategoriesList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.SelectedCategoriesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectedCategoriesList.ColumnHeadersVisible = false;
            this.SelectedCategoriesList.Location = new System.Drawing.Point(409, 119);
            this.SelectedCategoriesList.Margin = new System.Windows.Forms.Padding(1);
            this.SelectedCategoriesList.MultiSelect = false;
            this.SelectedCategoriesList.Name = "SelectedCategoriesList";
            this.SelectedCategoriesList.ReadOnly = true;
            this.SelectedCategoriesList.RowHeadersVisible = false;
            this.SelectedCategoriesList.RowHeadersWidth = 62;
            this.SelectedCategoriesList.RowTemplate.Height = 28;
            this.SelectedCategoriesList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SelectedCategoriesList.Size = new System.Drawing.Size(261, 91);
            this.SelectedCategoriesList.TabIndex = 15;
            this.SelectedCategoriesList.Tag = "SelectedCategoriesList";
            this.SelectedCategoriesList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectedCategoriesList_CellContentClick);
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(806, 119);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(654, 489);
            this.cartesianChart1.TabIndex = 16;
            this.cartesianChart1.Text = "cartesianChart1";
            this.cartesianChart1.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.cartesianChart1_ChildChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(836, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "label1";
            // 
            // ShowTipsButton
            // 
            this.ShowTipsButton.Location = new System.Drawing.Point(672, 379);
            this.ShowTipsButton.Margin = new System.Windows.Forms.Padding(1);
            this.ShowTipsButton.Name = "ShowTipsButton";
            this.ShowTipsButton.Size = new System.Drawing.Size(120, 29);
            this.ShowTipsButton.TabIndex = 18;
            this.ShowTipsButton.Tag = "ShowTipsButton";
            this.ShowTipsButton.Text = "Show Tips";
            this.ShowTipsButton.UseVisualStyleBackColor = true;
            this.ShowTipsButton.Click += new System.EventHandler(this.ShowTipsButton_Click);
            // 
            // CheckInButton
            // 
            this.CheckInButton.Location = new System.Drawing.Point(672, 441);
            this.CheckInButton.Margin = new System.Windows.Forms.Padding(1);
            this.CheckInButton.Name = "CheckInButton";
            this.CheckInButton.Size = new System.Drawing.Size(120, 29);
            this.CheckInButton.TabIndex = 19;
            this.CheckInButton.Tag = "CheckInButton";
            this.CheckInButton.Text = "Check In";
            this.CheckInButton.UseVisualStyleBackColor = true;
            this.CheckInButton.Click += new System.EventHandler(this.CheckInButton_Click);
            // 
            // LoadGraphButton
            // 
            this.LoadGraphButton.Location = new System.Drawing.Point(672, 410);
            this.LoadGraphButton.Margin = new System.Windows.Forms.Padding(1);
            this.LoadGraphButton.Name = "LoadGraphButton";
            this.LoadGraphButton.Size = new System.Drawing.Size(120, 29);
            this.LoadGraphButton.TabIndex = 20;
            this.LoadGraphButton.Tag = "LoadGraphButton";
            this.LoadGraphButton.Text = "Show Checkins";
            this.LoadGraphButton.UseVisualStyleBackColor = true;
            this.LoadGraphButton.Click += new System.EventHandler(this.LoadGraphButton_Click);
            // 
            // SelectedBusiness
            // 
            this.SelectedBusiness.AutoSize = true;
            this.SelectedBusiness.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedBusiness.Location = new System.Drawing.Point(10, 546);
            this.SelectedBusiness.Name = "SelectedBusiness";
            this.SelectedBusiness.Size = new System.Drawing.Size(163, 20);
            this.SelectedBusiness.TabIndex = 21;
            this.SelectedBusiness.Text = "Selected Business:";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageUserInfo);
            this.tabControl.Controls.Add(this.tabPageBusinesses);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1491, 751);
            this.tabControl.TabIndex = 22;
            this.tabControl.Tag = "tabControl";
            // 
            // tabPageUserInfo
            // 
            this.tabPageUserInfo.Controls.Add(this.label2);
            this.tabPageUserInfo.Controls.Add(this.buttonUpdate);
            this.tabPageUserInfo.Controls.Add(this.buttonEdit);
            this.tabPageUserInfo.Controls.Add(this.textBoxLong);
            this.tabPageUserInfo.Controls.Add(this.textBoxLat);
            this.tabPageUserInfo.Controls.Add(this.textBoxTotalTipLikes);
            this.tabPageUserInfo.Controls.Add(this.textBoxTipCount);
            this.tabPageUserInfo.Controls.Add(this.textBoxUseful);
            this.tabPageUserInfo.Controls.Add(this.textBoxCool);
            this.tabPageUserInfo.Controls.Add(this.textBoxFunny);
            this.tabPageUserInfo.Controls.Add(this.textBoxYelpingSince);
            this.tabPageUserInfo.Controls.Add(this.textBoxFans);
            this.tabPageUserInfo.Controls.Add(this.textBoxStars);
            this.tabPageUserInfo.Controls.Add(this.textBoxName);
            this.tabPageUserInfo.Controls.Add(this.dataGridViewLatestTips);
            this.tabPageUserInfo.Controls.Add(this.dataGridViewFriends);
            this.tabPageUserInfo.Controls.Add(this.labelLatestTips);
            this.tabPageUserInfo.Controls.Add(this.labelFriends);
            this.tabPageUserInfo.Controls.Add(this.labelLong);
            this.tabPageUserInfo.Controls.Add(this.labelLat);
            this.tabPageUserInfo.Controls.Add(this.labelLocation);
            this.tabPageUserInfo.Controls.Add(this.labelTotalTipLikes);
            this.tabPageUserInfo.Controls.Add(this.labelTipCount);
            this.tabPageUserInfo.Controls.Add(this.labelUseful);
            this.tabPageUserInfo.Controls.Add(this.labelCool);
            this.tabPageUserInfo.Controls.Add(this.labelFunny);
            this.tabPageUserInfo.Controls.Add(this.labelVotes);
            this.tabPageUserInfo.Controls.Add(this.labelYelpingSince);
            this.tabPageUserInfo.Controls.Add(this.labelFans);
            this.tabPageUserInfo.Controls.Add(this.labelStars);
            this.tabPageUserInfo.Controls.Add(this.labelName);
            this.tabPageUserInfo.Controls.Add(this.labelUserInfo);
            this.tabPageUserInfo.Controls.Add(this.listBoxSetCurrentUser);
            this.tabPageUserInfo.Controls.Add(this.textBoxSetCurrentUser);
            this.tabPageUserInfo.Controls.Add(this.labelSetCurrentUser);
            this.tabPageUserInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPageUserInfo.Margin = new System.Windows.Forms.Padding(1);
            this.tabPageUserInfo.Name = "tabPageUserInfo";
            this.tabPageUserInfo.Padding = new System.Windows.Forms.Padding(1);
            this.tabPageUserInfo.Size = new System.Drawing.Size(1483, 725);
            this.tabPageUserInfo.TabIndex = 0;
            this.tabPageUserInfo.Tag = "tabPageUserInfo";
            this.tabPageUserInfo.Text = "User Information";
            this.tabPageUserInfo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(316, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 34;
            this.label2.Tag = "labelLocation";
            this.label2.Text = "Tips";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Enabled = false;
            this.buttonUpdate.Location = new System.Drawing.Point(460, 291);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(1);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(50, 19);
            this.buttonUpdate.TabIndex = 33;
            this.buttonUpdate.Tag = "buttonUpdate";
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(460, 266);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(1);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(50, 19);
            this.buttonEdit.TabIndex = 32;
            this.buttonEdit.Tag = "buttonEdit";
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBoxLong
            // 
            this.textBoxLong.Location = new System.Drawing.Point(350, 290);
            this.textBoxLong.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxLong.Name = "textBoxLong";
            this.textBoxLong.ReadOnly = true;
            this.textBoxLong.Size = new System.Drawing.Size(103, 20);
            this.textBoxLong.TabIndex = 31;
            this.textBoxLong.Tag = "textBoxLong";
            this.textBoxLong.TextChanged += new System.EventHandler(this.textBoxLong_TextChanged);
            // 
            // textBoxLat
            // 
            this.textBoxLat.Location = new System.Drawing.Point(350, 266);
            this.textBoxLat.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxLat.Name = "textBoxLat";
            this.textBoxLat.ReadOnly = true;
            this.textBoxLat.Size = new System.Drawing.Size(103, 20);
            this.textBoxLat.TabIndex = 30;
            this.textBoxLat.Tag = "textBoxLat";
            // 
            // textBoxTotalTipLikes
            // 
            this.textBoxTotalTipLikes.Location = new System.Drawing.Point(392, 174);
            this.textBoxTotalTipLikes.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxTotalTipLikes.Name = "textBoxTotalTipLikes";
            this.textBoxTotalTipLikes.ReadOnly = true;
            this.textBoxTotalTipLikes.Size = new System.Drawing.Size(112, 20);
            this.textBoxTotalTipLikes.TabIndex = 29;
            this.textBoxTotalTipLikes.Tag = "textBoxTotalTipLikes";
            // 
            // textBoxTipCount
            // 
            this.textBoxTipCount.Location = new System.Drawing.Point(392, 148);
            this.textBoxTipCount.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxTipCount.Name = "textBoxTipCount";
            this.textBoxTipCount.ReadOnly = true;
            this.textBoxTipCount.Size = new System.Drawing.Size(112, 20);
            this.textBoxTipCount.TabIndex = 28;
            this.textBoxTipCount.Tag = "textBoxTipCount";
            // 
            // textBoxUseful
            // 
            this.textBoxUseful.Location = new System.Drawing.Point(464, 218);
            this.textBoxUseful.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxUseful.Name = "textBoxUseful";
            this.textBoxUseful.ReadOnly = true;
            this.textBoxUseful.Size = new System.Drawing.Size(43, 20);
            this.textBoxUseful.TabIndex = 27;
            this.textBoxUseful.Tag = "textBoxUseful";
            // 
            // textBoxCool
            // 
            this.textBoxCool.Location = new System.Drawing.Point(419, 218);
            this.textBoxCool.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxCool.Name = "textBoxCool";
            this.textBoxCool.ReadOnly = true;
            this.textBoxCool.Size = new System.Drawing.Size(43, 20);
            this.textBoxCool.TabIndex = 26;
            this.textBoxCool.Tag = "textBoxCool";
            // 
            // textBoxFunny
            // 
            this.textBoxFunny.Location = new System.Drawing.Point(374, 218);
            this.textBoxFunny.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxFunny.Name = "textBoxFunny";
            this.textBoxFunny.ReadOnly = true;
            this.textBoxFunny.Size = new System.Drawing.Size(43, 20);
            this.textBoxFunny.TabIndex = 25;
            this.textBoxFunny.Tag = "textBoxFunnytextBoxFunny";
            // 
            // textBoxYelpingSince
            // 
            this.textBoxYelpingSince.Location = new System.Drawing.Point(398, 81);
            this.textBoxYelpingSince.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxYelpingSince.Name = "textBoxYelpingSince";
            this.textBoxYelpingSince.ReadOnly = true;
            this.textBoxYelpingSince.Size = new System.Drawing.Size(106, 20);
            this.textBoxYelpingSince.TabIndex = 24;
            this.textBoxYelpingSince.Tag = "textBoxYelpingSince";
            // 
            // textBoxFans
            // 
            this.textBoxFans.Location = new System.Drawing.Point(455, 60);
            this.textBoxFans.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxFans.Name = "textBoxFans";
            this.textBoxFans.ReadOnly = true;
            this.textBoxFans.Size = new System.Drawing.Size(49, 20);
            this.textBoxFans.TabIndex = 23;
            this.textBoxFans.Tag = "textBoxFans";
            // 
            // textBoxStars
            // 
            this.textBoxStars.Location = new System.Drawing.Point(350, 60);
            this.textBoxStars.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxStars.Name = "textBoxStars";
            this.textBoxStars.ReadOnly = true;
            this.textBoxStars.Size = new System.Drawing.Size(49, 20);
            this.textBoxStars.TabIndex = 22;
            this.textBoxStars.Tag = "textBoxStars";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(350, 38);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(154, 20);
            this.textBoxName.TabIndex = 21;
            this.textBoxName.Tag = "textBoxName";
            // 
            // dataGridViewLatestTips
            // 
            this.dataGridViewLatestTips.AllowUserToAddRows = false;
            this.dataGridViewLatestTips.AllowUserToDeleteRows = false;
            this.dataGridViewLatestTips.AllowUserToResizeColumns = false;
            this.dataGridViewLatestTips.AllowUserToResizeRows = false;
            this.dataGridViewLatestTips.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLatestTips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLatestTips.Location = new System.Drawing.Point(542, 38);
            this.dataGridViewLatestTips.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridViewLatestTips.MultiSelect = false;
            this.dataGridViewLatestTips.Name = "dataGridViewLatestTips";
            this.dataGridViewLatestTips.ReadOnly = true;
            this.dataGridViewLatestTips.RowHeadersWidth = 62;
            this.dataGridViewLatestTips.RowTemplate.Height = 28;
            this.dataGridViewLatestTips.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLatestTips.Size = new System.Drawing.Size(979, 675);
            this.dataGridViewLatestTips.TabIndex = 20;
            this.dataGridViewLatestTips.Tag = "dataGridViewLatestTips";
            // 
            // dataGridViewFriends
            // 
            this.dataGridViewFriends.AllowUserToAddRows = false;
            this.dataGridViewFriends.AllowUserToDeleteRows = false;
            this.dataGridViewFriends.AllowUserToResizeColumns = false;
            this.dataGridViewFriends.AllowUserToResizeRows = false;
            this.dataGridViewFriends.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFriends.ColumnHeadersHeight = 34;
            this.dataGridViewFriends.Location = new System.Drawing.Point(11, 356);
            this.dataGridViewFriends.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridViewFriends.Name = "dataGridViewFriends";
            this.dataGridViewFriends.ReadOnly = true;
            this.dataGridViewFriends.RowHeadersVisible = false;
            this.dataGridViewFriends.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewFriends.RowTemplate.Height = 28;
            this.dataGridViewFriends.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFriends.Size = new System.Drawing.Size(486, 357);
            this.dataGridViewFriends.TabIndex = 19;
            this.dataGridViewFriends.Tag = "dataGridViewFriends";
            // 
            // labelLatestTips
            // 
            this.labelLatestTips.AutoSize = true;
            this.labelLatestTips.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLatestTips.Location = new System.Drawing.Point(538, 1);
            this.labelLatestTips.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLatestTips.Name = "labelLatestTips";
            this.labelLatestTips.Size = new System.Drawing.Size(204, 20);
            this.labelLatestTips.TabIndex = 18;
            this.labelLatestTips.Tag = "labelLatestTips";
            this.labelLatestTips.Text = "Latest Tips from Friends";
            // 
            // labelFriends
            // 
            this.labelFriends.AutoSize = true;
            this.labelFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriends.Location = new System.Drawing.Point(14, 311);
            this.labelFriends.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFriends.Name = "labelFriends";
            this.labelFriends.Size = new System.Drawing.Size(69, 20);
            this.labelFriends.TabIndex = 17;
            this.labelFriends.Tag = "labelFriends";
            this.labelFriends.Text = "Friends";
            // 
            // labelLong
            // 
            this.labelLong.AutoSize = true;
            this.labelLong.Location = new System.Drawing.Point(315, 297);
            this.labelLong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLong.Name = "labelLong";
            this.labelLong.Size = new System.Drawing.Size(31, 13);
            this.labelLong.TabIndex = 16;
            this.labelLong.Tag = "labelLong";
            this.labelLong.Text = "Long";
            // 
            // labelLat
            // 
            this.labelLat.AutoSize = true;
            this.labelLat.Location = new System.Drawing.Point(316, 269);
            this.labelLat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLat.Name = "labelLat";
            this.labelLat.Size = new System.Drawing.Size(22, 13);
            this.labelLat.TabIndex = 15;
            this.labelLat.Tag = "labelLat";
            this.labelLat.Text = "Lat";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocation.Location = new System.Drawing.Point(315, 240);
            this.labelLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(67, 16);
            this.labelLocation.TabIndex = 14;
            this.labelLocation.Tag = "labelLocation";
            this.labelLocation.Text = "Location";
            // 
            // labelTotalTipLikes
            // 
            this.labelTotalTipLikes.AutoSize = true;
            this.labelTotalTipLikes.Location = new System.Drawing.Point(315, 174);
            this.labelTotalTipLikes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalTipLikes.Name = "labelTotalTipLikes";
            this.labelTotalTipLikes.Size = new System.Drawing.Size(77, 13);
            this.labelTotalTipLikes.TabIndex = 13;
            this.labelTotalTipLikes.Tag = "labelTotalTipLikes";
            this.labelTotalTipLikes.Text = "Total Tip Likes";
            // 
            // labelTipCount
            // 
            this.labelTipCount.AutoSize = true;
            this.labelTipCount.Location = new System.Drawing.Point(315, 148);
            this.labelTipCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTipCount.Name = "labelTipCount";
            this.labelTipCount.Size = new System.Drawing.Size(53, 13);
            this.labelTipCount.TabIndex = 12;
            this.labelTipCount.Tag = "labelTipCount";
            this.labelTipCount.Text = "Tip Count";
            // 
            // labelUseful
            // 
            this.labelUseful.AutoSize = true;
            this.labelUseful.Location = new System.Drawing.Point(466, 204);
            this.labelUseful.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUseful.Name = "labelUseful";
            this.labelUseful.Size = new System.Drawing.Size(37, 13);
            this.labelUseful.TabIndex = 11;
            this.labelUseful.Tag = "labelUseful";
            this.labelUseful.Text = "Useful";
            // 
            // labelCool
            // 
            this.labelCool.AutoSize = true;
            this.labelCool.Location = new System.Drawing.Point(427, 204);
            this.labelCool.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCool.Name = "labelCool";
            this.labelCool.Size = new System.Drawing.Size(28, 13);
            this.labelCool.TabIndex = 10;
            this.labelCool.Tag = "labelCool";
            this.labelCool.Text = "Cool";
            // 
            // labelFunny
            // 
            this.labelFunny.AutoSize = true;
            this.labelFunny.Location = new System.Drawing.Point(377, 204);
            this.labelFunny.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFunny.Name = "labelFunny";
            this.labelFunny.Size = new System.Drawing.Size(36, 13);
            this.labelFunny.TabIndex = 9;
            this.labelFunny.Tag = "labelFunny";
            this.labelFunny.Text = "Funny";
            // 
            // labelVotes
            // 
            this.labelVotes.AutoSize = true;
            this.labelVotes.Location = new System.Drawing.Point(315, 218);
            this.labelVotes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVotes.Name = "labelVotes";
            this.labelVotes.Size = new System.Drawing.Size(37, 13);
            this.labelVotes.TabIndex = 8;
            this.labelVotes.Tag = "labelVotes";
            this.labelVotes.Text = "Votes:";
            // 
            // labelYelpingSince
            // 
            this.labelYelpingSince.AutoSize = true;
            this.labelYelpingSince.Location = new System.Drawing.Point(316, 84);
            this.labelYelpingSince.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelYelpingSince.Name = "labelYelpingSince";
            this.labelYelpingSince.Size = new System.Drawing.Size(72, 13);
            this.labelYelpingSince.TabIndex = 7;
            this.labelYelpingSince.Tag = "labelYelpingSince";
            this.labelYelpingSince.Text = "Yelping Since";
            // 
            // labelFans
            // 
            this.labelFans.AutoSize = true;
            this.labelFans.Location = new System.Drawing.Point(416, 63);
            this.labelFans.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFans.Name = "labelFans";
            this.labelFans.Size = new System.Drawing.Size(30, 13);
            this.labelFans.TabIndex = 6;
            this.labelFans.Tag = "labelFans";
            this.labelFans.Text = "Fans";
            // 
            // labelStars
            // 
            this.labelStars.AutoSize = true;
            this.labelStars.Location = new System.Drawing.Point(315, 58);
            this.labelStars.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStars.Name = "labelStars";
            this.labelStars.Size = new System.Drawing.Size(31, 13);
            this.labelStars.TabIndex = 5;
            this.labelStars.Tag = "labelStars";
            this.labelStars.Text = "Stars";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(315, 38);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 4;
            this.labelName.Tag = "labelName";
            this.labelName.Text = "Name";
            // 
            // labelUserInfo
            // 
            this.labelUserInfo.AutoSize = true;
            this.labelUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserInfo.Location = new System.Drawing.Point(314, 1);
            this.labelUserInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUserInfo.Name = "labelUserInfo";
            this.labelUserInfo.Size = new System.Drawing.Size(144, 20);
            this.labelUserInfo.TabIndex = 3;
            this.labelUserInfo.Tag = "labelUserInfo";
            this.labelUserInfo.Text = "User Information";
            // 
            // listBoxSetCurrentUser
            // 
            this.listBoxSetCurrentUser.FormattingEnabled = true;
            this.listBoxSetCurrentUser.Location = new System.Drawing.Point(11, 59);
            this.listBoxSetCurrentUser.Margin = new System.Windows.Forms.Padding(1);
            this.listBoxSetCurrentUser.Name = "listBoxSetCurrentUser";
            this.listBoxSetCurrentUser.Size = new System.Drawing.Size(264, 251);
            this.listBoxSetCurrentUser.TabIndex = 2;
            this.listBoxSetCurrentUser.Tag = "listBoxSetCurrentUser";
            this.listBoxSetCurrentUser.SelectedIndexChanged += new System.EventHandler(this.listBoxSetCurrentUser_SelectedIndexChanged);
            // 
            // textBoxSetCurrentUser
            // 
            this.textBoxSetCurrentUser.Location = new System.Drawing.Point(11, 38);
            this.textBoxSetCurrentUser.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxSetCurrentUser.Name = "textBoxSetCurrentUser";
            this.textBoxSetCurrentUser.Size = new System.Drawing.Size(264, 20);
            this.textBoxSetCurrentUser.TabIndex = 1;
            this.textBoxSetCurrentUser.Tag = "textBoxSetCurrentUser";
            this.textBoxSetCurrentUser.TextChanged += new System.EventHandler(this.textBoxSetCurrentUser_TextChanged);
            // 
            // labelSetCurrentUser
            // 
            this.labelSetCurrentUser.AutoSize = true;
            this.labelSetCurrentUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSetCurrentUser.Location = new System.Drawing.Point(14, 1);
            this.labelSetCurrentUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSetCurrentUser.Name = "labelSetCurrentUser";
            this.labelSetCurrentUser.Size = new System.Drawing.Size(145, 20);
            this.labelSetCurrentUser.TabIndex = 0;
            this.labelSetCurrentUser.Tag = "labelSetCurrentUser";
            this.labelSetCurrentUser.Text = "Set Current User";
            // 
            // tabPageBusinesses
            // 
            this.tabPageBusinesses.Controls.Add(this.CheckInBuffer);
            this.tabPageBusinesses.Controls.Add(this.checkedListPrices);
            this.tabPageBusinesses.Controls.Add(this.comboBoxSortBy);
            this.tabPageBusinesses.Controls.Add(this.labelSortBy);
            this.tabPageBusinesses.Controls.Add(this.CategoriesLab);
            this.tabPageBusinesses.Controls.Add(this.SelectedCategoriesBox);
            this.tabPageBusinesses.Controls.Add(this.AttributesLab);
            this.tabPageBusinesses.Controls.Add(this.SelectedAttributesBox);
            this.tabPageBusinesses.Controls.Add(this.UserCheck);
            this.tabPageBusinesses.Controls.Add(this.SelectedAttributesList);
            this.tabPageBusinesses.Controls.Add(this.AttributesList);
            this.tabPageBusinesses.Controls.Add(this.AttributesLabel);
            this.tabPageBusinesses.Controls.Add(this.SelectedAtrributesLabel);
            this.tabPageBusinesses.Controls.Add(this.HoursLabel);
            this.tabPageBusinesses.Controls.Add(this.BusinessAddressLabel);
            this.tabPageBusinesses.Controls.Add(this.BusinessNameLabel);
            this.tabPageBusinesses.Controls.Add(this.StateLabel);
            this.tabPageBusinesses.Controls.Add(this.cartesianChart1);
            this.tabPageBusinesses.Controls.Add(this.LoadGraphButton);
            this.tabPageBusinesses.Controls.Add(this.StateList);
            this.tabPageBusinesses.Controls.Add(this.ShowTipsButton);
            this.tabPageBusinesses.Controls.Add(this.CheckInButton);
            this.tabPageBusinesses.Controls.Add(this.ZipcodeList);
            this.tabPageBusinesses.Controls.Add(this.SelectedBusiness);
            this.tabPageBusinesses.Controls.Add(this.label1);
            this.tabPageBusinesses.Controls.Add(this.ZipcodeLabel);
            this.tabPageBusinesses.Controls.Add(this.CityList);
            this.tabPageBusinesses.Controls.Add(this.BusinessesLabel);
            this.tabPageBusinesses.Controls.Add(this.BusinessDataGrid);
            this.tabPageBusinesses.Controls.Add(this.SelectedCategoriesList);
            this.tabPageBusinesses.Controls.Add(this.CityLabel);
            this.tabPageBusinesses.Controls.Add(this.CategoriesList);
            this.tabPageBusinesses.Controls.Add(this.CategoriesLabel);
            this.tabPageBusinesses.Controls.Add(this.SelectedCategoriesLabel);
            this.tabPageBusinesses.Location = new System.Drawing.Point(4, 22);
            this.tabPageBusinesses.Margin = new System.Windows.Forms.Padding(1);
            this.tabPageBusinesses.Name = "tabPageBusinesses";
            this.tabPageBusinesses.Padding = new System.Windows.Forms.Padding(1);
            this.tabPageBusinesses.Size = new System.Drawing.Size(1483, 725);
            this.tabPageBusinesses.TabIndex = 1;
            this.tabPageBusinesses.Tag = "tabPageBusinesses";
            this.tabPageBusinesses.Text = "Businesses";
            this.tabPageBusinesses.UseVisualStyleBackColor = true;
            // 
            // CheckInBuffer
            // 
            this.CheckInBuffer.AutoSize = true;
            this.CheckInBuffer.Location = new System.Drawing.Point(678, 471);
            this.CheckInBuffer.Name = "CheckInBuffer";
            this.CheckInBuffer.Size = new System.Drawing.Size(114, 13);
            this.CheckInBuffer.TabIndex = 34;
            this.CheckInBuffer.Text = "No business selected. ";
            // 
            // checkedListPrices
            // 
            this.checkedListPrices.CheckOnClick = true;
            this.checkedListPrices.FormattingEnabled = true;
            this.checkedListPrices.Items.AddRange(new object[] {
            "$",
            "$$",
            "$$$",
            "$$$$"});
            this.checkedListPrices.Location = new System.Drawing.Point(674, 119);
            this.checkedListPrices.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListPrices.Name = "checkedListPrices";
            this.checkedListPrices.Size = new System.Drawing.Size(118, 94);
            this.checkedListPrices.TabIndex = 33;
            this.checkedListPrices.Tag = "checkedListPrices";
            this.checkedListPrices.SelectedIndexChanged += new System.EventHandler(this.checkedListPrices_SelectedIndexChanged);
            // 
            // comboBoxSortBy
            // 
            this.comboBoxSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSortBy.FormattingEnabled = true;
            this.comboBoxSortBy.Location = new System.Drawing.Point(672, 355);
            this.comboBoxSortBy.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxSortBy.Name = "comboBoxSortBy";
            this.comboBoxSortBy.Size = new System.Drawing.Size(119, 21);
            this.comboBoxSortBy.TabIndex = 32;
            this.comboBoxSortBy.Tag = "comboBoxSortBy";
            this.comboBoxSortBy.SelectedIndexChanged += new System.EventHandler(this.comboBoxSortBy_SelectedIndexChanged);
            // 
            // labelSortBy
            // 
            this.labelSortBy.AutoSize = true;
            this.labelSortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSortBy.Location = new System.Drawing.Point(674, 331);
            this.labelSortBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSortBy.Name = "labelSortBy";
            this.labelSortBy.Size = new System.Drawing.Size(51, 16);
            this.labelSortBy.TabIndex = 31;
            this.labelSortBy.Tag = "labelSortBy";
            this.labelSortBy.Text = "Sort By";
            // 
            // CategoriesLab
            // 
            this.CategoriesLab.AutoSize = true;
            this.CategoriesLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriesLab.Location = new System.Drawing.Point(489, 548);
            this.CategoriesLab.Name = "CategoriesLab";
            this.CategoriesLab.Size = new System.Drawing.Size(74, 16);
            this.CategoriesLab.TabIndex = 30;
            this.CategoriesLab.Text = "Categories";
            // 
            // SelectedCategoriesBox
            // 
            this.SelectedCategoriesBox.FormattingEnabled = true;
            this.SelectedCategoriesBox.Location = new System.Drawing.Point(492, 567);
            this.SelectedCategoriesBox.Name = "SelectedCategoriesBox";
            this.SelectedCategoriesBox.Size = new System.Drawing.Size(177, 147);
            this.SelectedCategoriesBox.TabIndex = 29;
            // 
            // AttributesLab
            // 
            this.AttributesLab.AutoSize = true;
            this.AttributesLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttributesLab.Location = new System.Drawing.Point(232, 549);
            this.AttributesLab.Name = "AttributesLab";
            this.AttributesLab.Size = new System.Drawing.Size(63, 16);
            this.AttributesLab.TabIndex = 28;
            this.AttributesLab.Text = "Attributes";
            // 
            // SelectedAttributesBox
            // 
            this.SelectedAttributesBox.FormattingEnabled = true;
            this.SelectedAttributesBox.Location = new System.Drawing.Point(235, 567);
            this.SelectedAttributesBox.Name = "SelectedAttributesBox";
            this.SelectedAttributesBox.Size = new System.Drawing.Size(164, 147);
            this.SelectedAttributesBox.TabIndex = 27;
            // 
            // UserCheck
            // 
            this.UserCheck.AutoSize = true;
            this.UserCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserCheck.Location = new System.Drawing.Point(489, 16);
            this.UserCheck.Name = "UserCheck";
            this.UserCheck.Size = new System.Drawing.Size(328, 20);
            this.UserCheck.TabIndex = 26;
            this.UserCheck.Text = "No User Selected. Please Select a User";
            // 
            // SelectedAttributesList
            // 
            this.SelectedAttributesList.AllowUserToAddRows = false;
            this.SelectedAttributesList.AllowUserToDeleteRows = false;
            this.SelectedAttributesList.AllowUserToResizeColumns = false;
            this.SelectedAttributesList.AllowUserToResizeRows = false;
            this.SelectedAttributesList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SelectedAttributesList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.SelectedAttributesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectedAttributesList.ColumnHeadersVisible = false;
            this.SelectedAttributesList.Location = new System.Drawing.Point(408, 229);
            this.SelectedAttributesList.Margin = new System.Windows.Forms.Padding(2);
            this.SelectedAttributesList.MultiSelect = false;
            this.SelectedAttributesList.Name = "SelectedAttributesList";
            this.SelectedAttributesList.ReadOnly = true;
            this.SelectedAttributesList.RowHeadersVisible = false;
            this.SelectedAttributesList.RowHeadersWidth = 62;
            this.SelectedAttributesList.RowTemplate.Height = 28;
            this.SelectedAttributesList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SelectedAttributesList.Size = new System.Drawing.Size(261, 100);
            this.SelectedAttributesList.TabIndex = 25;
            this.SelectedAttributesList.Tag = "SelectedAttributesList";
            this.SelectedAttributesList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectedAttributesList_CellContentClick);
            // 
            // AttributesList
            // 
            this.AttributesList.AllowUserToAddRows = false;
            this.AttributesList.AllowUserToDeleteRows = false;
            this.AttributesList.AllowUserToResizeColumns = false;
            this.AttributesList.AllowUserToResizeRows = false;
            this.AttributesList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AttributesList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AttributesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AttributesList.ColumnHeadersVisible = false;
            this.AttributesList.Location = new System.Drawing.Point(41, 229);
            this.AttributesList.Margin = new System.Windows.Forms.Padding(2);
            this.AttributesList.MultiSelect = false;
            this.AttributesList.Name = "AttributesList";
            this.AttributesList.ReadOnly = true;
            this.AttributesList.RowHeadersVisible = false;
            this.AttributesList.RowHeadersWidth = 62;
            this.AttributesList.RowTemplate.Height = 28;
            this.AttributesList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AttributesList.Size = new System.Drawing.Size(261, 100);
            this.AttributesList.TabIndex = 24;
            this.AttributesList.Tag = "AttributesList";
            this.AttributesList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AttributesList_CellContentClick);
            // 
            // AttributesLabel
            // 
            this.AttributesLabel.AutoSize = true;
            this.AttributesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttributesLabel.Location = new System.Drawing.Point(11, 211);
            this.AttributesLabel.Name = "AttributesLabel";
            this.AttributesLabel.Size = new System.Drawing.Size(63, 16);
            this.AttributesLabel.TabIndex = 22;
            this.AttributesLabel.Tag = "AttributesLabel";
            this.AttributesLabel.Text = "Attributes";
            // 
            // SelectedAtrributesLabel
            // 
            this.SelectedAtrributesLabel.AutoSize = true;
            this.SelectedAtrributesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedAtrributesLabel.Location = new System.Drawing.Point(371, 211);
            this.SelectedAtrributesLabel.Name = "SelectedAtrributesLabel";
            this.SelectedAtrributesLabel.Size = new System.Drawing.Size(120, 16);
            this.SelectedAtrributesLabel.TabIndex = 23;
            this.SelectedAtrributesLabel.Tag = "SelectedAtrributesLabel";
            this.SelectedAtrributesLabel.Text = "Selected Attributes";
            // 
            // HoursLabel
            // 
            this.HoursLabel.AutoSize = true;
            this.HoursLabel.BackColor = System.Drawing.Color.Transparent;
            this.HoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursLabel.Location = new System.Drawing.Point(18, 645);
            this.HoursLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HoursLabel.Name = "HoursLabel";
            this.HoursLabel.Size = new System.Drawing.Size(44, 16);
            this.HoursLabel.TabIndex = 24;
            this.HoursLabel.Text = "Hours";
            // 
            // BusinessAddressLabel
            // 
            this.BusinessAddressLabel.AutoSize = true;
            this.BusinessAddressLabel.BackColor = System.Drawing.Color.Transparent;
            this.BusinessAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusinessAddressLabel.Location = new System.Drawing.Point(17, 609);
            this.BusinessAddressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BusinessAddressLabel.Name = "BusinessAddressLabel";
            this.BusinessAddressLabel.Size = new System.Drawing.Size(59, 16);
            this.BusinessAddressLabel.TabIndex = 23;
            this.BusinessAddressLabel.Text = "Address";
            // 
            // BusinessNameLabel
            // 
            this.BusinessNameLabel.AutoSize = true;
            this.BusinessNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.BusinessNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusinessNameLabel.Location = new System.Drawing.Point(17, 577);
            this.BusinessNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BusinessNameLabel.Name = "BusinessNameLabel";
            this.BusinessNameLabel.Size = new System.Drawing.Size(103, 16);
            this.BusinessNameLabel.TabIndex = 22;
            this.BusinessNameLabel.Text = "Business Name";
            // 
            // YelpApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 751);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "YelpApp";
            this.Text = "YelpApp";
            ((System.ComponentModel.ISupportInitialize)(this.BusinessDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedCategoriesList)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPageUserInfo.ResumeLayout(false);
            this.tabPageUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLatestTips)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFriends)).EndInit();
            this.tabPageBusinesses.ResumeLayout(false);
            this.tabPageBusinesses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedAttributesList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttributesList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.DataGridView BusinessDataGrid;
        private System.Windows.Forms.ComboBox StateList;
        private System.Windows.Forms.ComboBox CityList;
        private System.Windows.Forms.Label ZipcodeLabel;
        private System.Windows.Forms.ComboBox ZipcodeList;
        private System.Windows.Forms.Label CategoriesLabel;
        private System.Windows.Forms.Label BusinessesLabel;
        private System.Windows.Forms.Label SelectedCategoriesLabel;
        private System.Windows.Forms.DataGridView CategoriesList;
        private System.Windows.Forms.DataGridView SelectedCategoriesList;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ShowTipsButton;
        private System.Windows.Forms.Button CheckInButton;
        private System.Windows.Forms.Button LoadGraphButton;
        private System.Windows.Forms.Label SelectedBusiness;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageUserInfo;
        private System.Windows.Forms.TabPage tabPageBusinesses;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textBoxLong;
        private System.Windows.Forms.TextBox textBoxLat;
        private System.Windows.Forms.TextBox textBoxTotalTipLikes;
        private System.Windows.Forms.TextBox textBoxTipCount;
        private System.Windows.Forms.TextBox textBoxUseful;
        private System.Windows.Forms.TextBox textBoxCool;
        private System.Windows.Forms.TextBox textBoxFunny;
        private System.Windows.Forms.TextBox textBoxYelpingSince;
        private System.Windows.Forms.TextBox textBoxFans;
        private System.Windows.Forms.TextBox textBoxStars;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.DataGridView dataGridViewLatestTips;
        private System.Windows.Forms.DataGridView dataGridViewFriends;
        private System.Windows.Forms.Label labelLatestTips;
        private System.Windows.Forms.Label labelFriends;
        private System.Windows.Forms.Label labelLong;
        private System.Windows.Forms.Label labelLat;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelTotalTipLikes;
        private System.Windows.Forms.Label labelTipCount;
        private System.Windows.Forms.Label labelUseful;
        private System.Windows.Forms.Label labelCool;
        private System.Windows.Forms.Label labelFunny;
        private System.Windows.Forms.Label labelVotes;
        private System.Windows.Forms.Label labelYelpingSince;
        private System.Windows.Forms.Label labelFans;
        private System.Windows.Forms.Label labelStars;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelUserInfo;
        private System.Windows.Forms.ListBox listBoxSetCurrentUser;
        private System.Windows.Forms.TextBox textBoxSetCurrentUser;
        private System.Windows.Forms.Label labelSetCurrentUser;
        private System.Windows.Forms.DataGridView SelectedAttributesList;
        private System.Windows.Forms.DataGridView AttributesList;
        private System.Windows.Forms.Label AttributesLabel;
        private System.Windows.Forms.Label SelectedAtrributesLabel;
        private System.Windows.Forms.Label HoursLabel;
        private System.Windows.Forms.Label BusinessAddressLabel;
        private System.Windows.Forms.Label BusinessNameLabel;
        private System.Windows.Forms.Label UserCheck;
        private System.Windows.Forms.ListBox SelectedAttributesBox;
        private System.Windows.Forms.Label CategoriesLab;
        private System.Windows.Forms.ListBox SelectedCategoriesBox;
        private System.Windows.Forms.Label AttributesLab;
        private System.Windows.Forms.ComboBox comboBoxSortBy;
        private System.Windows.Forms.Label labelSortBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListPrices;
        private System.Windows.Forms.Label CheckInBuffer;
    }
}