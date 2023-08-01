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
        User m_User;

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns");

            if (m_LoginResult == null)
            {
                login();
                enableFetchLinkLabels();
                enableButtons();
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

        private void enableButtons()
        {
            buttonPostStatus.Enabled = true;
        }

        private void disableButtons()
        {
            buttonPostStatus.Enabled = false;
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

                m_User = m_LoginResult.LoggedInUser;
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

            disableFetchLinkLabels();
            disableButtons();
        }

        private void fetchNewsFeed()
        {
            listBoxNewsFeed.SelectedIndexChanged -= listBoxNewsFeed_SelectedIndexChanged;
            listBoxNewsFeed.DataSource = m_User.NewsFeed;
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
            FacebookObjectCollection<Album> albums = m_User.Albums;
            if (albums.Count == 0 || albums[0].Photos.Count == 0)
            {
                MessageBox.Show("There are no albums or photos");
            }

            int i = 0, j = 0;

            int pictureBoxWidth = 77;
            int pictureBoxLength = 77;
            int spaceFromLabel = 30;


            foreach (Photo photo in m_User.Albums[0].Photos.Take(6))
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Name = photo.Name;                
                pictureBox.Size = new Size(pictureBoxWidth, pictureBoxLength);
                pictureBox.ImageLocation = photo.PictureNormalURL;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                // TODO: Fix Location?
                pictureBox.Location = new Point(labelPhotos.Left + 6 + i * (pictureBoxWidth + 18), labelPhotos.Top + labelPhotos.Height + spaceFromLabel + j * (pictureBoxLength + 12));

                this.Controls.Add(pictureBox);

                pictureBox.BringToFront();

                i++;
                if (i % 3 == 0)
                {
                    i = 0;
                    j++;
                }
            }
        }

        private void postStatus(string i_Text)
        {
            try
            {
                if (string.IsNullOrEmpty(i_Text))
                {
                    MessageBox.Show("Can not post an empty status!");
                }
                else
                {
                    m_User.PostStatus(i_Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void buttonPostStatus_Click(object sender, EventArgs e)
        {
            postStatus(textBoxPostStatus.Text);
            textBoxPostStatus.Text = "";
        }
    }
}
