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
                enableFetchLinkLabels();
            }
        }

        private void enableFetchLinkLabels()
        {
            linkLabelFetchNewsfeed.Enabled = true;
            linkLabelFetchPosts.Enabled = true;
            linkLabelFetchPhotos.Enabled = true;
        }

        private void disableFetchLinkLabels()
        {
            linkLabelFetchNewsfeed.Enabled = false;
            linkLabelFetchPosts.Enabled = false;
            linkLabelFetchPhotos.Enabled = false;
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
                labelName.Text = m_LoginResult.LoggedInUser.Name;
                labelLivesIn.Text = m_LoginResult.LoggedInUser.Location.Name;
                labelBirthday.Text = m_LoginResult.LoggedInUser.Birthday;
                buttonLogin.Enabled = false;
                buttonLogout.Enabled = true;
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            buttonLogin.Text = "Login";
            buttonLogin.BackColor = buttonLogout.BackColor;
            m_LoginResult = null;
            disableFetchLinkLabels();
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
        }

        private void fetchNewsFeed()
        {
            listBoxNewsFeed.SelectedIndexChanged -= listBoxNewsFeed_SelectedIndexChanged;
            listBoxNewsFeed.DataSource = m_LoginResult.LoggedInUser.NewsFeed;
            listBoxNewsFeed.SelectedIndexChanged += listBoxNewsFeed_SelectedIndexChanged;

            if (listBoxNewsFeed.Items.Count == 0)
            {
                MessageBox.Show("Newsfeed is empty");
            }
        }

        private void fetchPosts()
        {
            listBoxPosts.SelectedIndexChanged -= listBoxPosts_SelectedIndexChanged;
            listBoxPosts.DataSource = m_LoginResult.LoggedInUser.Posts;
            listBoxPosts.SelectedIndexChanged += listBoxPosts_SelectedIndexChanged;

            if (listBoxPosts.Items.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve");
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

        private void listBoxNewsFeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxNewsFeed.SelectedIndex != -1)
            {
                Post post = listBoxNewsFeed.SelectedItem as Post;
                fetchComments(post);
            }
        }

        private void fetchComments(Post i_Post)
        {

            listBoxComments.DataSource = i_Post.Comments;

            if (listBoxComments.Items.Count == 0)
            {
                listBoxComments.DataSource = null;
                listBoxComments.Items.Add("No comments found");
            }
        }

        private void linkLabelFetchNewsfeed_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchNewsFeed();
        }

        private void linkLabelFetchPosts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchPosts();
        }

        private void linkLabelFetchPhotos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchPhotos();
        }

        private void fetchPhotos()
        {
            FacebookObjectCollection<Album> albums = m_LoginResult.LoggedInUser.Albums;
            if (albums.Count == 0 || albums[0].Photos.Count == 0)
            {
                MessageBox.Show("There are no albums or photos");
            }

            int i = 0;

            int pictureBoxWidth = 85;
            int pictureBoxLength = 85;
            int spaceFromLabel = 27;

            Photo photo = m_LoginResult.LoggedInUser.Albums[0].Photos[0];

            // TODO: Fix this shit
            // PictureBox pictureBox = new PictureBox();
            // this.Controls.Add(pictureBox);
            pictureBox1.Enabled = true;
            pictureBox1.Visible = true;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Width = pictureBoxWidth;
            pictureBox1.Height = pictureBoxLength;
            pictureBox1.Left = labelPhotos.Left;
            pictureBox1.Top = labelPhotos.Top + spaceFromLabel;
            pictureBox1.ImageLocation = photo.PictureNormalURL;


            //foreach (Photo photo in m_LoginResult.LoggedInUser.Albums[0].Photos)
            //{
            //    PictureBox pictureBox = new PictureBox();
            //    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            //    pictureBox.Location = new Point(labelPhotos.Left, labelPhotos.Top);
            //    pictureBox.ImageLocation = photo.PictureNormalURL;
            //}
        }
    }
}
