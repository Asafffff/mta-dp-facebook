using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
        }

        FacebookWrapper.LoginResult m_LoginResult;

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns");

            if (m_LoginResult == null)
            {
                login();
            }
        }

        private void login()
        {
            //m_LoginResult = FacebookService.Login(
            //    /// (This is Desig Patter's App ID. replace it with your own)
            //    "1380984126104335",
            //    /// requested permissions:
            //    "email",
            //    "public_profile",
            //    "user_age_range",
            //    "user_birthday",
            //    "user_events",
            //    "user_friends",
            //    "user_gender",
            //    "user_hometown",
            //    "user_likes",
            //    "user_link",
            //    "user_location",
            //    "user_photos",
            //    "user_posts",
            //    "user_videos"
            //    /// add any relevant permissions
            //    );

            string accessToken = "";
            m_LoginResult = FacebookService.Connect(accessToken);

            if (string.IsNullOrEmpty(m_LoginResult.ErrorMessage))
            {
                buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
                buttonLogin.BackColor = Color.LightGreen;
                pictureBoxProfile.ImageLocation = m_LoginResult.LoggedInUser.PictureNormalURL;
                buttonLogin.Enabled = false;
                buttonLogout.Enabled = true;

                fetchNewsFeed();
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            buttonLogin.Text = "Login";
            buttonLogin.BackColor = buttonLogout.BackColor;
            m_LoginResult = null;
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
        }

        private void fetchNewsFeed()
        {
            listBoxNewsFeed.DataSource = m_LoginResult.LoggedInUser.NewsFeed;

            if (listBoxNewsFeed.Items.Count == 0)
            {
                MessageBox.Show("News feed is empty");
            }
        }

        private void fetchPosts()
        {
            listBoxPosts.SelectedIndexChanged -= listBoxPosts_SelectedIndexChanged;
            listBoxPosts.DataSource = m_LoginResult.LoggedInUser.Posts;
            listBoxPosts.SelectedIndexChanged += listBoxPosts_SelectedIndexChanged;

            if (listBoxPosts.Items.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPosts.SelectedIndex != -1)
            {
                Post post = listBoxPosts.SelectedItem as Post;
                fetchComments(post);
            }
        }

        private void fetchComments(Post i_Post)
        {
            listBoxComments.SelectedIndexChanged -= listBoxComments_SelectedIndexChanged;
            listBoxComments.DataSource = i_Post.Comments;
            listBoxComments.SelectedIndexChanged += listBoxComments_SelectedIndexChanged;

            if (listBoxComments.Items.Count == 0)
            {
                MessageBox.Show("No Comments to retrieve :(");
            }
        }

        private void listBoxComments_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabelFetchPosts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchPosts();
        }
    }
}
