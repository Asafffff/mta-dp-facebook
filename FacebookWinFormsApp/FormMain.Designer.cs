﻿namespace BasicFacebookFeatures
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.tabControlForm = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.linkLabelFetchNewsfeed = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabelFetchPhotos = new System.Windows.Forms.LinkLabel();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelLivesIn = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelFriends = new System.Windows.Forms.Label();
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
            this.labelPostScheduling = new System.Windows.Forms.Label();
            this.tabPageFriendApprover = new System.Windows.Forms.TabPage();
            this.tabControlForm.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.tabPagePostScheduling.SuspendLayout();
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
            // tabControlForm
            // 
            this.tabControlForm.Controls.Add(this.tabPageMain);
            this.tabControlForm.Controls.Add(this.tabPagePostScheduling);
            this.tabControlForm.Controls.Add(this.tabPageFriendApprover);
            this.tabControlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlForm.Location = new System.Drawing.Point(0, 0);
            this.tabControlForm.Name = "tabControlForm";
            this.tabControlForm.SelectedIndex = 0;
            this.tabControlForm.Size = new System.Drawing.Size(1243, 697);
            this.tabControlForm.TabIndex = 54;
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(this.linkLabelFetchNewsfeed);
            this.tabPageMain.Controls.Add(this.pictureBox1);
            this.tabPageMain.Controls.Add(this.linkLabelFetchPhotos);
            this.tabPageMain.Controls.Add(this.labelBirthday);
            this.tabPageMain.Controls.Add(this.labelLivesIn);
            this.tabPageMain.Controls.Add(this.labelName);
            this.tabPageMain.Controls.Add(this.labelFriends);
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
            this.tabPageMain.Location = new System.Drawing.Point(4, 31);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(1235, 662);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Main";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // linkLabelFetchNewsfeed
            // 
            this.linkLabelFetchNewsfeed.AutoSize = true;
            this.linkLabelFetchNewsfeed.Enabled = false;
            this.linkLabelFetchNewsfeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelFetchNewsfeed.LinkColor = System.Drawing.Color.Blue;
            this.linkLabelFetchNewsfeed.Location = new System.Drawing.Point(432, 107);
            this.linkLabelFetchNewsfeed.Name = "linkLabelFetchNewsfeed";
            this.linkLabelFetchNewsfeed.Size = new System.Drawing.Size(40, 16);
            this.linkLabelFetchNewsfeed.TabIndex = 73;
            this.linkLabelFetchNewsfeed.TabStop = true;
            this.linkLabelFetchNewsfeed.Text = "Fetch";
            this.linkLabelFetchNewsfeed.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFetchNewsfeed_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(20, 465);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 85);
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabelFetchPhotos
            // 
            this.linkLabelFetchPhotos.AutoSize = true;
            this.linkLabelFetchPhotos.Enabled = false;
            this.linkLabelFetchPhotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelFetchPhotos.LinkColor = System.Drawing.Color.Blue;
            this.linkLabelFetchPhotos.Location = new System.Drawing.Point(96, 443);
            this.linkLabelFetchPhotos.Name = "linkLabelFetchPhotos";
            this.linkLabelFetchPhotos.Size = new System.Drawing.Size(40, 16);
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
            this.labelBirthday.Size = new System.Drawing.Size(0, 24);
            this.labelBirthday.TabIndex = 67;
            // 
            // labelLivesIn
            // 
            this.labelLivesIn.AutoSize = true;
            this.labelLivesIn.Location = new System.Drawing.Point(104, 121);
            this.labelLivesIn.Name = "labelLivesIn";
            this.labelLivesIn.Size = new System.Drawing.Size(0, 24);
            this.labelLivesIn.TabIndex = 66;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(104, 97);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 24);
            this.labelName.TabIndex = 65;
            // 
            // labelFriends
            // 
            this.labelFriends.AutoSize = true;
            this.labelFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriends.Location = new System.Drawing.Point(570, 32);
            this.labelFriends.Name = "labelFriends";
            this.labelFriends.Size = new System.Drawing.Size(370, 42);
            this.labelFriends.TabIndex = 64;
            this.labelFriends.Text = "Friends birthdays list ";
            // 
            // linkLabelFetchPosts
            // 
            this.linkLabelFetchPosts.AutoSize = true;
            this.linkLabelFetchPosts.Enabled = false;
            this.linkLabelFetchPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelFetchPosts.LinkColor = System.Drawing.Color.Blue;
            this.linkLabelFetchPosts.Location = new System.Drawing.Point(77, 220);
            this.linkLabelFetchPosts.Name = "linkLabelFetchPosts";
            this.linkLabelFetchPosts.Size = new System.Drawing.Size(40, 16);
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
            this.labelNewsFeed.Size = new System.Drawing.Size(108, 24);
            this.labelNewsFeed.TabIndex = 62;
            this.labelNewsFeed.Text = "News Feed";
            // 
            // listBoxNewsFeed
            // 
            this.listBoxNewsFeed.FormattingEnabled = true;
            this.listBoxNewsFeed.ItemHeight = 22;
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
            this.labelComments.Size = new System.Drawing.Size(101, 24);
            this.labelComments.TabIndex = 59;
            this.labelComments.Text = "Comments";
            // 
            // labelPosts
            // 
            this.labelPosts.AutoSize = true;
            this.labelPosts.Location = new System.Drawing.Point(16, 215);
            this.labelPosts.Name = "labelPosts";
            this.labelPosts.Size = new System.Drawing.Size(55, 24);
            this.labelPosts.TabIndex = 58;
            this.labelPosts.Text = "Posts";
            // 
            // listBoxComments
            // 
            this.listBoxComments.FormattingEnabled = true;
            this.listBoxComments.ItemHeight = 22;
            this.listBoxComments.Location = new System.Drawing.Point(322, 465);
            this.listBoxComments.Name = "listBoxComments";
            this.listBoxComments.Size = new System.Drawing.Size(873, 180);
            this.listBoxComments.TabIndex = 57;
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 22;
            this.listBoxPosts.Location = new System.Drawing.Point(20, 242);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(266, 180);
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
            this.tabPagePostScheduling.Controls.Add(this.labelPostScheduling);
            this.tabPagePostScheduling.Location = new System.Drawing.Point(4, 31);
            this.tabPagePostScheduling.Name = "tabPagePostScheduling";
            this.tabPagePostScheduling.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePostScheduling.Size = new System.Drawing.Size(1235, 662);
            this.tabPagePostScheduling.TabIndex = 1;
            this.tabPagePostScheduling.Text = "Post Scheduling";
            this.tabPagePostScheduling.UseVisualStyleBackColor = true;
            // 
            // labelPostScheduling
            // 
            this.labelPostScheduling.AutoSize = true;
            this.labelPostScheduling.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostScheduling.Location = new System.Drawing.Point(3, 3);
            this.labelPostScheduling.Name = "labelPostScheduling";
            this.labelPostScheduling.Size = new System.Drawing.Size(462, 69);
            this.labelPostScheduling.TabIndex = 0;
            this.labelPostScheduling.Text = "Post Scheduling";
            // 
            // tabPageFriendApprover
            // 
            this.tabPageFriendApprover.Location = new System.Drawing.Point(4, 31);
            this.tabPageFriendApprover.Name = "tabPageFriendApprover";
            this.tabPageFriendApprover.Size = new System.Drawing.Size(1235, 662);
            this.tabPageFriendApprover.TabIndex = 2;
            this.tabPageFriendApprover.Text = "Friend Approver";
            this.tabPageFriendApprover.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 697);
            this.Controls.Add(this.tabControlForm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControlForm.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.tabPageMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.tabPagePostScheduling.ResumeLayout(false);
            this.tabPagePostScheduling.PerformLayout();
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
		private System.Windows.Forms.TabControl tabControlForm;
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
        private System.Windows.Forms.Label labelFriends;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelLivesIn;
        private System.Windows.Forms.Label labelPostScheduling;
        private System.Windows.Forms.TabPage tabPageFriendApprover;
        private System.Windows.Forms.LinkLabel linkLabelFetchPhotos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabelFetchNewsfeed;
    }
}

