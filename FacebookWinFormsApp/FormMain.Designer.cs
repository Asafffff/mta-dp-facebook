using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.buttonPostStatus = new System.Windows.Forms.Button();
            this.textBoxPostStatus = new System.Windows.Forms.TextBox();
            this.labelPostStatus = new System.Windows.Forms.Label();
            this.linkLabelFetchNewsfeed = new System.Windows.Forms.LinkLabel();
            this.linkLabelFetchPhotos = new System.Windows.Forms.LinkLabel();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelLivesIn = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.linkLabelFetchPosts = new System.Windows.Forms.LinkLabel();
            this.labelNewsFeed = new System.Windows.Forms.Label();
            this.listBoxNewsFeed = new System.Windows.Forms.ListBox();
            this.labelPhotos = new System.Windows.Forms.Label();
            this.labelComments = new System.Windows.Forms.Label();
            this.labelPosts = new System.Windows.Forms.Label();
            this.listBoxComments = new System.Windows.Forms.ListBox();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.tabPagePostScheduling = new System.Windows.Forms.TabPage();
            this.buttonScheduledPostRemove = new System.Windows.Forms.Button();
            this.textBoxScheduledPostDetails = new System.Windows.Forms.TextBox();
            this.listBoxScheduledPosts = new System.Windows.Forms.ListBox();
            this.labelScheduledPosts = new System.Windows.Forms.Label();
            this.buttonPostSchedStatus = new System.Windows.Forms.Button();
            this.textBoxPostSchedStatus = new System.Windows.Forms.TextBox();
            this.dateTimePickerPostSchedStatus = new System.Windows.Forms.DateTimePicker();
            this.labelPostScheduling = new System.Windows.Forms.Label();
            this.tabPageStatistic = new System.Windows.Forms.TabPage();
            this.tabPageStatistic.Hide();
            this.labelTop4LikedPages = new System.Windows.Forms.Label();
            this.listViewTop4LikedPages = new System.Windows.Forms.ListView();
            this.labelTop4CheckinsPages = new System.Windows.Forms.Label();
            this.listTopCheckinPages = new System.Windows.Forms.ListView();
            this.IsCummunityTextBox = new System.Windows.Forms.RichTextBox();
            this.IsPublishedTextBox = new System.Windows.Forms.RichTextBox();
            this.chartCategories = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.tabPagePostScheduling.SuspendLayout();
            this.tabPageStatistic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(18, 17);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(268, 32);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Enabled = false;
            this.buttonLogout.Location = new System.Drawing.Point(18, 57);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(268, 32);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageMain);
            this.tabControl.Controls.Add(this.tabPagePostScheduling);
            this.tabControl.Controls.Add(this.tabPageStatistic);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1243, 697);
            this.tabControl.TabIndex = 54;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabPageStats_Selected);
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(this.buttonPostStatus);
            this.tabPageMain.Controls.Add(this.textBoxPostStatus);
            this.tabPageMain.Controls.Add(this.labelPostStatus);
            this.tabPageMain.Controls.Add(this.linkLabelFetchNewsfeed);
            this.tabPageMain.Controls.Add(this.linkLabelFetchPhotos);
            this.tabPageMain.Controls.Add(this.labelBirthday);
            this.tabPageMain.Controls.Add(this.labelLivesIn);
            this.tabPageMain.Controls.Add(this.labelName);
            this.tabPageMain.Controls.Add(this.linkLabelFetchPosts);
            this.tabPageMain.Controls.Add(this.labelNewsFeed);
            this.tabPageMain.Controls.Add(this.listBoxNewsFeed);
            this.tabPageMain.Controls.Add(this.labelPhotos);
            this.tabPageMain.Controls.Add(this.labelComments);
            this.tabPageMain.Controls.Add(this.labelPosts);
            this.tabPageMain.Controls.Add(this.listBoxComments);
            this.tabPageMain.Controls.Add(this.listBoxPosts);
            this.tabPageMain.Controls.Add(this.pictureBoxProfile);
            this.tabPageMain.Controls.Add(this.buttonLogout);
            this.tabPageMain.Controls.Add(this.buttonLogin);
            this.tabPageMain.Location = new System.Drawing.Point(4, 35);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(1235, 658);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Main";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // buttonPostStatus
            // 
            this.buttonPostStatus.Enabled = false;
            this.buttonPostStatus.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPostStatus.Location = new System.Drawing.Point(1054, 55);
            this.buttonPostStatus.Name = "buttonPostStatus";
            this.buttonPostStatus.Size = new System.Drawing.Size(141, 28);
            this.buttonPostStatus.TabIndex = 76;
            this.buttonPostStatus.Text = "Post";
            this.buttonPostStatus.UseVisualStyleBackColor = true;
            this.buttonPostStatus.Click += new System.EventHandler(this.buttonPostStatus_Click);
            // 
            // textBoxPostStatus
            // 
            this.textBoxPostStatus.Location = new System.Drawing.Point(325, 55);
            this.textBoxPostStatus.Name = "textBoxPostStatus";
            this.textBoxPostStatus.Size = new System.Drawing.Size(714, 32);
            this.textBoxPostStatus.TabIndex = 75;
            // 
            // labelPostStatus
            // 
            this.labelPostStatus.AutoSize = true;
            this.labelPostStatus.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostStatus.Location = new System.Drawing.Point(325, 17);
            this.labelPostStatus.Name = "labelPostStatus";
            this.labelPostStatus.Size = new System.Drawing.Size(320, 40);
            this.labelPostStatus.TabIndex = 74;
            this.labelPostStatus.Text = "What\'s on your mind?";
            // 
            // linkLabelFetchNewsfeed
            // 
            this.linkLabelFetchNewsfeed.AutoSize = true;
            this.linkLabelFetchNewsfeed.Enabled = false;
            this.linkLabelFetchNewsfeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelFetchNewsfeed.LinkColor = System.Drawing.Color.Blue;
            this.linkLabelFetchNewsfeed.Location = new System.Drawing.Point(432, 107);
            this.linkLabelFetchNewsfeed.Name = "linkLabelFetchNewsfeed";
            this.linkLabelFetchNewsfeed.Size = new System.Drawing.Size(50, 20);
            this.linkLabelFetchNewsfeed.TabIndex = 73;
            this.linkLabelFetchNewsfeed.TabStop = true;
            this.linkLabelFetchNewsfeed.Text = "Fetch";
            this.linkLabelFetchNewsfeed.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFetchNewsfeed_LinkClicked);
            // 
            // linkLabelFetchPhotos
            // 
            this.linkLabelFetchPhotos.AutoSize = true;
            this.linkLabelFetchPhotos.Enabled = false;
            this.linkLabelFetchPhotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelFetchPhotos.LinkColor = System.Drawing.Color.Blue;
            this.linkLabelFetchPhotos.Location = new System.Drawing.Point(96, 443);
            this.linkLabelFetchPhotos.Name = "linkLabelFetchPhotos";
            this.linkLabelFetchPhotos.Size = new System.Drawing.Size(50, 20);
            this.linkLabelFetchPhotos.TabIndex = 68;
            this.linkLabelFetchPhotos.TabStop = true;
            this.linkLabelFetchPhotos.Text = "Fetch";
            this.linkLabelFetchPhotos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFetchPhotos_LinkClicked);
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Location = new System.Drawing.Point(104, 145);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(0, 26);
            this.labelBirthday.TabIndex = 67;
            // 
            // labelLivesIn
            // 
            this.labelLivesIn.AutoSize = true;
            this.labelLivesIn.Location = new System.Drawing.Point(104, 121);
            this.labelLivesIn.Name = "labelLivesIn";
            this.labelLivesIn.Size = new System.Drawing.Size(0, 26);
            this.labelLivesIn.TabIndex = 66;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(104, 97);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 26);
            this.labelName.TabIndex = 65;
            // 
            // linkLabelFetchPosts
            // 
            this.linkLabelFetchPosts.AutoSize = true;
            this.linkLabelFetchPosts.Enabled = false;
            this.linkLabelFetchPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelFetchPosts.LinkColor = System.Drawing.Color.Blue;
            this.linkLabelFetchPosts.Location = new System.Drawing.Point(77, 220);
            this.linkLabelFetchPosts.Name = "linkLabelFetchPosts";
            this.linkLabelFetchPosts.Size = new System.Drawing.Size(50, 20);
            this.linkLabelFetchPosts.TabIndex = 63;
            this.linkLabelFetchPosts.TabStop = true;
            this.linkLabelFetchPosts.Text = "Fetch";
            this.linkLabelFetchPosts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFetchPosts_LinkClicked);
            // 
            // labelNewsFeed
            // 
            this.labelNewsFeed.AutoSize = true;
            this.labelNewsFeed.Location = new System.Drawing.Point(318, 102);
            this.labelNewsFeed.Name = "labelNewsFeed";
            this.labelNewsFeed.Size = new System.Drawing.Size(122, 26);
            this.labelNewsFeed.TabIndex = 62;
            this.labelNewsFeed.Text = "News Feed";
            // 
            // listBoxNewsFeed
            // 
            this.listBoxNewsFeed.FormattingEnabled = true;
            this.listBoxNewsFeed.ItemHeight = 26;
            this.listBoxNewsFeed.Location = new System.Drawing.Point(322, 132);
            this.listBoxNewsFeed.Name = "listBoxNewsFeed";
            this.listBoxNewsFeed.Size = new System.Drawing.Size(873, 290);
            this.listBoxNewsFeed.TabIndex = 61;
            this.listBoxNewsFeed.SelectedIndexChanged += new System.EventHandler(this.listBoxNewsFeed_SelectedIndexChanged);
            // 
            // labelPhotos
            // 
            this.labelPhotos.Location = new System.Drawing.Point(16, 438);
            this.labelPhotos.Name = "labelPhotos";
            this.labelPhotos.Size = new System.Drawing.Size(68, 24);
            this.labelPhotos.TabIndex = 60;
            this.labelPhotos.Text = "Photos";
            // 
            // labelComments
            // 
            this.labelComments.AutoSize = true;
            this.labelComments.Location = new System.Drawing.Point(318, 438);
            this.labelComments.Name = "labelComments";
            this.labelComments.Size = new System.Drawing.Size(119, 26);
            this.labelComments.TabIndex = 59;
            this.labelComments.Text = "Comments";
            // 
            // labelPosts
            // 
            this.labelPosts.AutoSize = true;
            this.labelPosts.Location = new System.Drawing.Point(16, 215);
            this.labelPosts.Name = "labelPosts";
            this.labelPosts.Size = new System.Drawing.Size(67, 26);
            this.labelPosts.TabIndex = 58;
            this.labelPosts.Text = "Posts";
            // 
            // listBoxComments
            // 
            this.listBoxComments.FormattingEnabled = true;
            this.listBoxComments.ItemHeight = 26;
            this.listBoxComments.Location = new System.Drawing.Point(322, 465);
            this.listBoxComments.Name = "listBoxComments";
            this.listBoxComments.Size = new System.Drawing.Size(873, 160);
            this.listBoxComments.TabIndex = 57;
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 26;
            this.listBoxPosts.Location = new System.Drawing.Point(20, 242);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(266, 160);
            this.listBoxPosts.TabIndex = 56;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxProfile.Location = new System.Drawing.Point(18, 96);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(79, 78);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 55;
            this.pictureBoxProfile.TabStop = false;
            // 
            // tabPagePostScheduling
            // 
            this.tabPagePostScheduling.Controls.Add(this.buttonScheduledPostRemove);
            this.tabPagePostScheduling.Controls.Add(this.textBoxScheduledPostDetails);
            this.tabPagePostScheduling.Controls.Add(this.listBoxScheduledPosts);
            this.tabPagePostScheduling.Controls.Add(this.labelScheduledPosts);
            this.tabPagePostScheduling.Controls.Add(this.buttonPostSchedStatus);
            this.tabPagePostScheduling.Controls.Add(this.textBoxPostSchedStatus);
            this.tabPagePostScheduling.Controls.Add(this.dateTimePickerPostSchedStatus);
            this.tabPagePostScheduling.Controls.Add(this.labelPostScheduling);
            this.tabPagePostScheduling.Enabled = false;
            this.tabPagePostScheduling.Location = new System.Drawing.Point(4, 35);
            this.tabPagePostScheduling.Name = "tabPagePostScheduling";
            this.tabPagePostScheduling.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePostScheduling.Size = new System.Drawing.Size(1235, 658);
            this.tabPagePostScheduling.TabIndex = 1;
            this.tabPagePostScheduling.Text = "Post Scheduling";
            this.tabPagePostScheduling.UseVisualStyleBackColor = true;
            // 
            // buttonScheduledPostRemove
            // 
            this.buttonScheduledPostRemove.Enabled = false;
            this.buttonScheduledPostRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonScheduledPostRemove.Location = new System.Drawing.Point(996, 246);
            this.buttonScheduledPostRemove.Name = "buttonScheduledPostRemove";
            this.buttonScheduledPostRemove.Size = new System.Drawing.Size(141, 29);
            this.buttonScheduledPostRemove.TabIndex = 82;
            this.buttonScheduledPostRemove.Text = "Remove";
            this.buttonScheduledPostRemove.UseVisualStyleBackColor = true;
            this.buttonScheduledPostRemove.Click += new System.EventHandler(this.buttonScheduledPostRemove_Click);
            // 
            // textBoxScheduledPostDetails
            // 
            this.textBoxScheduledPostDetails.Location = new System.Drawing.Point(501, 246);
            this.textBoxScheduledPostDetails.Multiline = true;
            this.textBoxScheduledPostDetails.Name = "textBoxScheduledPostDetails";
            this.textBoxScheduledPostDetails.ReadOnly = true;
            this.textBoxScheduledPostDetails.Size = new System.Drawing.Size(480, 224);
            this.textBoxScheduledPostDetails.TabIndex = 81;
            // 
            // listBoxScheduledPosts
            // 
            this.listBoxScheduledPosts.FormattingEnabled = true;
            this.listBoxScheduledPosts.ItemHeight = 26;
            this.listBoxScheduledPosts.Location = new System.Drawing.Point(18, 246);
            this.listBoxScheduledPosts.Name = "listBoxScheduledPosts";
            this.listBoxScheduledPosts.Size = new System.Drawing.Size(447, 212);
            this.listBoxScheduledPosts.TabIndex = 80;
            this.listBoxScheduledPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxScheduledPosts_SelectedIndexChanged);
            // 
            // labelScheduledPosts
            // 
            this.labelScheduledPosts.AutoSize = true;
            this.labelScheduledPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScheduledPosts.Location = new System.Drawing.Point(11, 180);
            this.labelScheduledPosts.Name = "labelScheduledPosts";
            this.labelScheduledPosts.Size = new System.Drawing.Size(361, 52);
            this.labelScheduledPosts.TabIndex = 79;
            this.labelScheduledPosts.Text = "Scheduled Posts";
            // 
            // buttonPostSchedStatus
            // 
            this.buttonPostSchedStatus.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPostSchedStatus.Location = new System.Drawing.Point(996, 94);
            this.buttonPostSchedStatus.Name = "buttonPostSchedStatus";
            this.buttonPostSchedStatus.Size = new System.Drawing.Size(141, 28);
            this.buttonPostSchedStatus.TabIndex = 78;
            this.buttonPostSchedStatus.Text = "Post";
            this.buttonPostSchedStatus.UseVisualStyleBackColor = true;
            this.buttonPostSchedStatus.Click += new System.EventHandler(this.buttonPostSchedStatus_Click);
            // 
            // textBoxPostSchedStatus
            // 
            this.textBoxPostSchedStatus.Location = new System.Drawing.Point(15, 94);
            this.textBoxPostSchedStatus.Name = "textBoxPostSchedStatus";
            this.textBoxPostSchedStatus.Size = new System.Drawing.Size(714, 32);
            this.textBoxPostSchedStatus.TabIndex = 77;
            // 
            // dateTimePickerPostSchedStatus
            // 
            this.dateTimePickerPostSchedStatus.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
            this.dateTimePickerPostSchedStatus.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerPostSchedStatus.Location = new System.Drawing.Point(744, 94);
            this.dateTimePickerPostSchedStatus.Name = "dateTimePickerPostSchedStatus";
            this.dateTimePickerPostSchedStatus.Size = new System.Drawing.Size(237, 32);
            this.dateTimePickerPostSchedStatus.TabIndex = 1;
            this.dateTimePickerPostSchedStatus.Value = new System.DateTime(2023, 8, 1, 0, 0, 0, 0);
            // 
            // labelPostScheduling
            // 
            this.labelPostScheduling.AutoSize = true;
            this.labelPostScheduling.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostScheduling.Location = new System.Drawing.Point(3, 13);
            this.labelPostScheduling.Name = "labelPostScheduling";
            this.labelPostScheduling.Size = new System.Drawing.Size(556, 82);
            this.labelPostScheduling.TabIndex = 0;
            this.labelPostScheduling.Text = "Post Scheduling";
            // 
            // tabPageStatistic
            // 
            this.tabPageStatistic.Controls.Add(this.labelTop4LikedPages);
            this.tabPageStatistic.Controls.Add(this.listViewTop4LikedPages);
            this.tabPageStatistic.Controls.Add(this.labelTop4CheckinsPages);
            this.tabPageStatistic.Controls.Add(this.listTopCheckinPages);
            this.tabPageStatistic.Controls.Add(this.IsCummunityTextBox);
            this.tabPageStatistic.Controls.Add(this.IsPublishedTextBox);
            this.tabPageStatistic.Controls.Add(this.chartCategories);
            this.tabPageStatistic.Location = new System.Drawing.Point(4, 35);
            this.tabPageStatistic.Name = "tabPageStatistic";
            this.tabPageStatistic.Size = new System.Drawing.Size(1235, 658);
            this.tabPageStatistic.TabIndex = 2;
            this.tabPageStatistic.Text = "GetPageStats";
            this.tabPageStatistic.UseVisualStyleBackColor = true;
            // 
            // labelTop4LikedPages
            // 
            this.labelTop4LikedPages.AutoSize = true;
            this.labelTop4LikedPages.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.labelTop4LikedPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTop4LikedPages.Location = new System.Drawing.Point(-6, 289);
            this.labelTop4LikedPages.Name = "labelTop4LikedPages";
            this.labelTop4LikedPages.Size = new System.Drawing.Size(250, 32);
            this.labelTop4LikedPages.TabIndex = 44;
            this.labelTop4LikedPages.Text = "Top 4 Liked Pages";
            // 
            // listViewTop4LikedPages
            // 
            this.listViewTop4LikedPages.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listViewTop4LikedPages.HideSelection = false;
            this.listViewTop4LikedPages.Location = new System.Drawing.Point(0, 324);
            this.listViewTop4LikedPages.Name = "listViewTop4LikedPages";
            this.listViewTop4LikedPages.Size = new System.Drawing.Size(342, 191);
            this.listViewTop4LikedPages.TabIndex = 43;
            this.listViewTop4LikedPages.UseCompatibleStateImageBehavior = false;
            this.listViewTop4LikedPages.View = System.Windows.Forms.View.List;
            // 
            // labelTop4CheckinsPages
            // 
            this.labelTop4CheckinsPages.AutoSize = true;
            this.labelTop4CheckinsPages.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.labelTop4CheckinsPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTop4CheckinsPages.Location = new System.Drawing.Point(-6, 40);
            this.labelTop4CheckinsPages.Name = "labelTop4CheckinsPages";
            this.labelTop4CheckinsPages.Size = new System.Drawing.Size(307, 32);
            this.labelTop4CheckinsPages.TabIndex = 42;
            this.labelTop4CheckinsPages.Text = "Top 4 Check-Ins Pages";
            // 
            // listTopCheckinPages
            // 
            this.listTopCheckinPages.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listTopCheckinPages.HideSelection = false;
            this.listTopCheckinPages.Location = new System.Drawing.Point(-4, 75);
            this.listTopCheckinPages.Name = "listTopCheckinPages";
            this.listTopCheckinPages.Size = new System.Drawing.Size(342, 191);
            this.listTopCheckinPages.TabIndex = 41;
            this.listTopCheckinPages.UseCompatibleStateImageBehavior = false;
            this.listTopCheckinPages.View = System.Windows.Forms.View.List;
            // 
            // IsCummunityTextBox
            // 
            this.IsCummunityTextBox.BackColor = System.Drawing.Color.Coral;
            this.IsCummunityTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsCummunityTextBox.Location = new System.Drawing.Point(858, 324);
            this.IsCummunityTextBox.Name = "IsCummunityTextBox";
            this.IsCummunityTextBox.Size = new System.Drawing.Size(346, 191);
            this.IsCummunityTextBox.TabIndex = 40;
            this.IsCummunityTextBox.Text = "";
            // 
            // IsPublishedTextBox
            // 
            this.IsPublishedTextBox.BackColor = System.Drawing.Color.IndianRed;
            this.IsPublishedTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsPublishedTextBox.Location = new System.Drawing.Point(858, 74);
            this.IsPublishedTextBox.Name = "IsPublishedTextBox";
            this.IsPublishedTextBox.Size = new System.Drawing.Size(346, 192);
            this.IsPublishedTextBox.TabIndex = 39;
            this.IsPublishedTextBox.Text = "";
            // 
            // chartCategories
            // 
            chartArea4.Name = "ChartArea1";
            this.chartCategories.ChartAreas.Add(chartArea4);
            legend4.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipX;
            legend4.IsDockedInsideChartArea = false;
            legend4.Name = "Legend1";
            this.chartCategories.Legends.Add(legend4);
            this.chartCategories.Location = new System.Drawing.Point(388, 74);
            this.chartCategories.Name = "chartCategories";
            this.chartCategories.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartCategories.Series.Add(series4);
            this.chartCategories.Size = new System.Drawing.Size(426, 403);
            this.chartCategories.TabIndex = 38;
            this.chartCategories.Text = "Categories";
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            title4.Name = "Title1";
            title4.Text = "Page\'s Categories Devision";
            this.chartCategories.Titles.Add(title4);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 697);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.tabPageMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.tabPagePostScheduling.ResumeLayout(false);
            this.tabPagePostScheduling.PerformLayout();
            this.tabPageStatistic.ResumeLayout(false);
            this.tabPageStatistic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCategories)).EndInit();
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageMain;
		private System.Windows.Forms.TabPage tabPagePostScheduling;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Label labelComments;
        private System.Windows.Forms.Label labelPosts;
        private System.Windows.Forms.ListBox listBoxComments;
        private System.Windows.Forms.Label labelPhotos;
        private System.Windows.Forms.Label labelNewsFeed;
        private System.Windows.Forms.ListBox listBoxNewsFeed;
        private System.Windows.Forms.LinkLabel linkLabelFetchPosts;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelLivesIn;
        private System.Windows.Forms.Label labelPostScheduling;
        private System.Windows.Forms.TabPage tabPageStatistic;
        private System.Windows.Forms.LinkLabel linkLabelFetchPhotos;
        private System.Windows.Forms.LinkLabel linkLabelFetchNewsfeed;
        private System.Windows.Forms.TextBox textBoxPostStatus;
        private System.Windows.Forms.Label labelPostStatus;
        private System.Windows.Forms.Button buttonPostStatus;
        private System.Windows.Forms.DateTimePicker dateTimePickerPostSchedStatus;
        private System.Windows.Forms.Button buttonPostSchedStatus;
        private System.Windows.Forms.TextBox textBoxPostSchedStatus;
        private System.Windows.Forms.Label labelScheduledPosts;
        private System.Windows.Forms.ListBox listBoxScheduledPosts;
        private System.Windows.Forms.TextBox textBoxScheduledPostDetails;
        private System.Windows.Forms.Button buttonScheduledPostRemove;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCategories;
        private System.Windows.Forms.RichTextBox IsPublishedTextBox;
        private System.Windows.Forms.RichTextBox IsCummunityTextBox;
        private System.Windows.Forms.ListView listTopCheckinPages;
        private Label labelTop4CheckinsPages;
        private Label labelTop4LikedPages;
        private ListView listViewTop4LikedPages;
    }
}

