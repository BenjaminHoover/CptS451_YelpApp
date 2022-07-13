
namespace CptS451WinFormsApp
{
    partial class BusinessDetails
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
            this.BusinessNameLabel = new System.Windows.Forms.Label();
            this.StateLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.BusinessNameDisplay = new System.Windows.Forms.TextBox();
            this.StateDisplay = new System.Windows.Forms.TextBox();
            this.CityDisplay = new System.Windows.Forms.TextBox();
            this.NumBusinessStateLabel = new System.Windows.Forms.Label();
            this.NumBusinessCityLabel = new System.Windows.Forms.Label();
            this.NumBusinessState = new System.Windows.Forms.Label();
            this.NumBusinessCity = new System.Windows.Forms.Label();
            this.TipsDisplay = new System.Windows.Forms.DataGridView();
            this.TipsLabel = new System.Windows.Forms.Label();
            this.AddTipLabel = new System.Windows.Forms.Label();
            this.TipTextBox = new System.Windows.Forms.TextBox();
            this.SubmitTipButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TipNum = new System.Windows.Forms.Label();
            this.NumTipsLabel = new System.Windows.Forms.Label();
            this.LikeTipButton = new System.Windows.Forms.Button();
            this.FriendsTipsDisplay = new System.Windows.Forms.DataGridView();
            this.FriendsTipsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TipsDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FriendsTipsDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // BusinessNameLabel
            // 
            this.BusinessNameLabel.AutoSize = true;
            this.BusinessNameLabel.Location = new System.Drawing.Point(8, 20);
            this.BusinessNameLabel.Name = "BusinessNameLabel";
            this.BusinessNameLabel.Size = new System.Drawing.Size(120, 20);
            this.BusinessNameLabel.TabIndex = 0;
            this.BusinessNameLabel.Tag = "BusinessNameLabel";
            this.BusinessNameLabel.Text = "Business Name";
            // 
            // StateLabel
            // 
            this.StateLabel.AutoSize = true;
            this.StateLabel.Location = new System.Drawing.Point(8, 45);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(48, 20);
            this.StateLabel.TabIndex = 1;
            this.StateLabel.Tag = "StateLabel";
            this.StateLabel.Text = "State";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(8, 77);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(35, 20);
            this.CityLabel.TabIndex = 2;
            this.CityLabel.Tag = "CityLabel";
            this.CityLabel.Text = "City";
            // 
            // BusinessNameDisplay
            // 
            this.BusinessNameDisplay.Location = new System.Drawing.Point(134, 13);
            this.BusinessNameDisplay.Name = "BusinessNameDisplay";
            this.BusinessNameDisplay.ReadOnly = true;
            this.BusinessNameDisplay.Size = new System.Drawing.Size(289, 26);
            this.BusinessNameDisplay.TabIndex = 3;
            this.BusinessNameDisplay.Tag = "BusinessNameDisplay";
            // 
            // StateDisplay
            // 
            this.StateDisplay.Location = new System.Drawing.Point(134, 45);
            this.StateDisplay.Name = "StateDisplay";
            this.StateDisplay.ReadOnly = true;
            this.StateDisplay.Size = new System.Drawing.Size(289, 26);
            this.StateDisplay.TabIndex = 4;
            this.StateDisplay.Tag = "StateDisplay";
            // 
            // CityDisplay
            // 
            this.CityDisplay.Location = new System.Drawing.Point(134, 77);
            this.CityDisplay.Name = "CityDisplay";
            this.CityDisplay.ReadOnly = true;
            this.CityDisplay.Size = new System.Drawing.Size(289, 26);
            this.CityDisplay.TabIndex = 5;
            this.CityDisplay.Tag = "CityDisplay";
            // 
            // NumBusinessStateLabel
            // 
            this.NumBusinessStateLabel.AutoSize = true;
            this.NumBusinessStateLabel.Location = new System.Drawing.Point(429, 13);
            this.NumBusinessStateLabel.Name = "NumBusinessStateLabel";
            this.NumBusinessStateLabel.Size = new System.Drawing.Size(297, 20);
            this.NumBusinessStateLabel.TabIndex = 6;
            this.NumBusinessStateLabel.Tag = "NumBusinessStateLabel";
            this.NumBusinessStateLabel.Text = "Number of businesses in the same state:";
            // 
            // NumBusinessCityLabel
            // 
            this.NumBusinessCityLabel.AutoSize = true;
            this.NumBusinessCityLabel.Location = new System.Drawing.Point(429, 33);
            this.NumBusinessCityLabel.Name = "NumBusinessCityLabel";
            this.NumBusinessCityLabel.Size = new System.Drawing.Size(280, 20);
            this.NumBusinessCityLabel.TabIndex = 7;
            this.NumBusinessCityLabel.Tag = "NumBusinessCityLabel";
            this.NumBusinessCityLabel.Text = "Number of businesses in the same city";
            // 
            // NumBusinessState
            // 
            this.NumBusinessState.AutoSize = true;
            this.NumBusinessState.Location = new System.Drawing.Point(770, 13);
            this.NumBusinessState.Name = "NumBusinessState";
            this.NumBusinessState.Size = new System.Drawing.Size(18, 20);
            this.NumBusinessState.TabIndex = 8;
            this.NumBusinessState.Tag = "NumBusinessState";
            this.NumBusinessState.Text = "0";
            // 
            // NumBusinessCity
            // 
            this.NumBusinessCity.AutoSize = true;
            this.NumBusinessCity.Location = new System.Drawing.Point(770, 33);
            this.NumBusinessCity.Name = "NumBusinessCity";
            this.NumBusinessCity.Size = new System.Drawing.Size(18, 20);
            this.NumBusinessCity.TabIndex = 9;
            this.NumBusinessCity.Tag = "NumBusinessCity";
            this.NumBusinessCity.Text = "0";
            // 
            // TipsDisplay
            // 
            this.TipsDisplay.AllowUserToAddRows = false;
            this.TipsDisplay.AllowUserToDeleteRows = false;
            this.TipsDisplay.AllowUserToResizeColumns = false;
            this.TipsDisplay.AllowUserToResizeRows = false;
            this.TipsDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TipsDisplay.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TipsDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TipsDisplay.Location = new System.Drawing.Point(12, 252);
            this.TipsDisplay.MultiSelect = false;
            this.TipsDisplay.Name = "TipsDisplay";
            this.TipsDisplay.ReadOnly = true;
            this.TipsDisplay.RowHeadersVisible = false;
            this.TipsDisplay.RowHeadersWidth = 62;
            this.TipsDisplay.RowTemplate.Height = 28;
            this.TipsDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TipsDisplay.Size = new System.Drawing.Size(1019, 230);
            this.TipsDisplay.TabIndex = 10;
            this.TipsDisplay.Tag = "TipsDisplay";
            this.TipsDisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TipsDisplay_CellContentClick);
            // 
            // TipsLabel
            // 
            this.TipsLabel.AutoSize = true;
            this.TipsLabel.Location = new System.Drawing.Point(12, 229);
            this.TipsLabel.Name = "TipsLabel";
            this.TipsLabel.Size = new System.Drawing.Size(38, 20);
            this.TipsLabel.TabIndex = 11;
            this.TipsLabel.Tag = "TipsLabel";
            this.TipsLabel.Text = "Tips";
            // 
            // AddTipLabel
            // 
            this.AddTipLabel.AutoSize = true;
            this.AddTipLabel.Location = new System.Drawing.Point(8, 119);
            this.AddTipLabel.Name = "AddTipLabel";
            this.AddTipLabel.Size = new System.Drawing.Size(90, 20);
            this.AddTipLabel.TabIndex = 12;
            this.AddTipLabel.Tag = "AddTipLabel";
            this.AddTipLabel.Text = "Leave a tip:";
            // 
            // TipTextBox
            // 
            this.TipTextBox.Location = new System.Drawing.Point(12, 152);
            this.TipTextBox.Multiline = true;
            this.TipTextBox.Name = "TipTextBox";
            this.TipTextBox.Size = new System.Drawing.Size(776, 66);
            this.TipTextBox.TabIndex = 13;
            this.TipTextBox.Tag = "TipTextBox";
            // 
            // SubmitTipButton
            // 
            this.SubmitTipButton.Location = new System.Drawing.Point(104, 113);
            this.SubmitTipButton.Name = "SubmitTipButton";
            this.SubmitTipButton.Size = new System.Drawing.Size(113, 33);
            this.SubmitTipButton.TabIndex = 14;
            this.SubmitTipButton.Tag = "SubmitTipButton";
            this.SubmitTipButton.Text = "Submit";
            this.SubmitTipButton.UseVisualStyleBackColor = true;
            this.SubmitTipButton.Click += new System.EventHandler(this.SubmitTipButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(737, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 15;
            // 
            // TipNum
            // 
            this.TipNum.AutoSize = true;
            this.TipNum.Location = new System.Drawing.Point(770, 119);
            this.TipNum.Name = "TipNum";
            this.TipNum.Size = new System.Drawing.Size(18, 20);
            this.TipNum.TabIndex = 16;
            this.TipNum.Tag = "TipNum";
            this.TipNum.Text = "0";
            // 
            // NumTipsLabel
            // 
            this.NumTipsLabel.AutoSize = true;
            this.NumTipsLabel.Location = new System.Drawing.Point(621, 119);
            this.NumTipsLabel.Name = "NumTipsLabel";
            this.NumTipsLabel.Size = new System.Drawing.Size(116, 20);
            this.NumTipsLabel.TabIndex = 17;
            this.NumTipsLabel.Tag = "NumTipsLabel";
            this.NumTipsLabel.Text = "Number of Tips";
            // 
            // LikeTipButton
            // 
            this.LikeTipButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LikeTipButton.Location = new System.Drawing.Point(223, 113);
            this.LikeTipButton.Name = "LikeTipButton";
            this.LikeTipButton.Size = new System.Drawing.Size(113, 33);
            this.LikeTipButton.TabIndex = 18;
            this.LikeTipButton.Tag = "LikeTipButton";
            this.LikeTipButton.Text = "Like Tip";
            this.LikeTipButton.UseVisualStyleBackColor = false;
            this.LikeTipButton.Click += new System.EventHandler(this.LikeTipButton_Click);
            // 
            // FriendsTipsDisplay
            // 
            this.FriendsTipsDisplay.AllowUserToAddRows = false;
            this.FriendsTipsDisplay.AllowUserToDeleteRows = false;
            this.FriendsTipsDisplay.AllowUserToResizeColumns = false;
            this.FriendsTipsDisplay.AllowUserToResizeRows = false;
            this.FriendsTipsDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FriendsTipsDisplay.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.FriendsTipsDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FriendsTipsDisplay.Location = new System.Drawing.Point(12, 542);
            this.FriendsTipsDisplay.MultiSelect = false;
            this.FriendsTipsDisplay.Name = "FriendsTipsDisplay";
            this.FriendsTipsDisplay.ReadOnly = true;
            this.FriendsTipsDisplay.RowHeadersVisible = false;
            this.FriendsTipsDisplay.RowHeadersWidth = 62;
            this.FriendsTipsDisplay.RowTemplate.Height = 28;
            this.FriendsTipsDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FriendsTipsDisplay.Size = new System.Drawing.Size(1019, 146);
            this.FriendsTipsDisplay.TabIndex = 19;
            this.FriendsTipsDisplay.Tag = "FriendsTipsDisplay";
            // 
            // FriendsTipsLabel
            // 
            this.FriendsTipsLabel.AutoSize = true;
            this.FriendsTipsLabel.Location = new System.Drawing.Point(8, 519);
            this.FriendsTipsLabel.Name = "FriendsTipsLabel";
            this.FriendsTipsLabel.Size = new System.Drawing.Size(95, 20);
            this.FriendsTipsLabel.TabIndex = 20;
            this.FriendsTipsLabel.Tag = "FriendsTipsLabel";
            this.FriendsTipsLabel.Text = "Friends Tips";
            // 
            // BusinessDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1043, 700);
            this.Controls.Add(this.FriendsTipsLabel);
            this.Controls.Add(this.FriendsTipsDisplay);
            this.Controls.Add(this.LikeTipButton);
            this.Controls.Add(this.NumTipsLabel);
            this.Controls.Add(this.TipNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SubmitTipButton);
            this.Controls.Add(this.TipTextBox);
            this.Controls.Add(this.AddTipLabel);
            this.Controls.Add(this.TipsLabel);
            this.Controls.Add(this.TipsDisplay);
            this.Controls.Add(this.NumBusinessCity);
            this.Controls.Add(this.NumBusinessState);
            this.Controls.Add(this.NumBusinessCityLabel);
            this.Controls.Add(this.NumBusinessStateLabel);
            this.Controls.Add(this.CityDisplay);
            this.Controls.Add(this.StateDisplay);
            this.Controls.Add(this.BusinessNameDisplay);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.StateLabel);
            this.Controls.Add(this.BusinessNameLabel);
            this.Name = "BusinessDetails";
            this.Text = "BusinessDetails";
            ((System.ComponentModel.ISupportInitialize)(this.TipsDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FriendsTipsDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BusinessNameLabel;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.TextBox BusinessNameDisplay;
        private System.Windows.Forms.TextBox StateDisplay;
        private System.Windows.Forms.TextBox CityDisplay;
        private System.Windows.Forms.Label NumBusinessStateLabel;
        private System.Windows.Forms.Label NumBusinessCityLabel;
        private System.Windows.Forms.Label NumBusinessState;
        private System.Windows.Forms.Label NumBusinessCity;
        private System.Windows.Forms.DataGridView TipsDisplay;
        private System.Windows.Forms.Label TipsLabel;
        private System.Windows.Forms.Label AddTipLabel;
        private System.Windows.Forms.TextBox TipTextBox;
        private System.Windows.Forms.Button SubmitTipButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TipNum;
        private System.Windows.Forms.Label NumTipsLabel;
        private System.Windows.Forms.Button LikeTipButton;
        private System.Windows.Forms.DataGridView FriendsTipsDisplay;
        private System.Windows.Forms.Label FriendsTipsLabel;
    }
}