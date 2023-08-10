using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private PostScheduler m_PostScheduler = new PostScheduler();
        private FacebookWrapper.LoginResult m_LoginResult;
        private PageStatistic m_PagesStats = new PageStatistic();
        private List<PictureBox> m_photosNameInControl = new List<PictureBox>();
        
        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;

            listBoxScheduledPosts.DisplayMember = "Message";
        }

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
            buttonPostSchedStatus.Enabled = true;
        }

        private void disableButtons()
        {
            buttonPostStatus.Enabled = false;
            buttonPostSchedStatus.Enabled = false;
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
            try
            {
                m_LoginResult = FacebookService.Connect(accessToken);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }

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
            buttonLogout.BackColor = System.Drawing.Color.Red; ;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            try
            {
                FacebookService.LogoutWithUI();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            
            buttonLogin.Text = "Login";
            buttonLogin.BackColor = System.Drawing.Color.LightSkyBlue;
            buttonLogout.BackColor = System.Drawing.Color.Transparent;
            m_LoginResult = null;
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;

            disableFetchLinkLabels();
            disableButtons();
            clearAllDataOfAUserFromForm();

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

        private void clearAllDataOfAUserFromForm()
        {
            pictureBoxProfile.ImageLocation = null;
            labelName.Text = null;
            labelLivesIn.Text = null;
            labelBirthday.Text = null;
            clearAllDataFromLists();
        }
        private void clearAllDataFromLists()
        {
            listBoxPosts.DataSource = null;
            listBoxPosts.Items.Clear();
            listBoxNewsFeed.DataSource = null;
            listBoxNewsFeed.Items.Clear();
            listBoxComments.DataSource = null;
            listBoxComments.Items.Clear();
            clearPhotosFromControl();
        }

        private void clearPhotosFromControl()
        {
            foreach(PictureBox name in m_photosNameInControl)
            {

                this.Controls.Remove(name);
            }
            m_photosNameInControl.Clear();
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

            int i = 0, j = 0;

            int pictureBoxWidth = 77;
            int pictureBoxLength = 77;
            int spaceFromLabel = 30;


            foreach (Photo photo in m_LoginResult.LoggedInUser.Albums[0].Photos.Take(6))
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Name = photo.Name;
                pictureBox.Size = new Size(pictureBoxWidth, pictureBoxLength);
                pictureBox.ImageLocation = photo.PictureNormalURL;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                // TODO: Fix Location?
                pictureBox.Location = new Point(labelPhotos.Left + 6 + i * (pictureBoxWidth + 18), labelPhotos.Top + labelPhotos.Height + spaceFromLabel + j * (pictureBoxLength + 12));
                this.Controls.Add(pictureBox);
                m_photosNameInControl.Add(pictureBox);
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
                    m_LoginResult.LoggedInUser.PostStatus(i_Text);
                }
            }
            catch
            {
                MessageBox.Show("Error posting status. Please try again");
            }
        }

        private void buttonPostStatus_Click(object sender, EventArgs e)
        {
            postStatus(textBoxPostStatus.Text);
            textBoxPostStatus.Text = "";
        }

        private void buttonPostSchedStatus_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime selectedDateTime = dateTimePickerPostSchedStatus.Value;
                ScheduledPost post = new ScheduledPost(textBoxPostSchedStatus.Text, selectedDateTime);
                post.ScheduleTriggered += ScheduledPostTriggered;
                post.ScheduleTriggered += removePostFromScheduler;
                addPostToScheduler(post);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (TaskSchedulerException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ScheduledPostTriggered(ScheduledPost i_Post)
        {
            postStatus(i_Post.Message);
        }

        private void addPostToScheduler(ScheduledPost i_Post)
        {
            if (m_PostScheduler.Count >= m_PostScheduler.MaxPosts)
            {
                MessageBox.Show($"You can only create up to {m_PostScheduler.MaxPosts} scheduled posts");
                return;
            }

            m_PostScheduler.Schedule(i_Post);
            createScheduledPostEntry(i_Post);
        }

        private void removePostFromScheduler(ScheduledPost i_Post)
        {
            listBoxScheduledPosts.Items.Remove(i_Post);
            textBoxScheduledPostDetails.Text = "";
            buttonScheduledPostRemove.Enabled = false;

            m_PostScheduler.Cancel(i_Post);
            removeScheduledPostEntry(i_Post);
        }

        private void createScheduledPostEntry(ScheduledPost i_Post)
        {
            listBoxScheduledPosts.Items.Add(i_Post);
        }

        private void removeScheduledPostEntry(ScheduledPost i_Post)
        {
            listBoxScheduledPosts.Items.Remove(i_Post);
        }

        private void listBoxScheduledPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            ScheduledPost post = listBoxScheduledPosts.SelectedItem as ScheduledPost;

            if (post != null)
            {
                buttonScheduledPostRemove.Enabled = true;
                textBoxScheduledPostDetails.Text = $"Post ID: {post.Id}\r\n" +
                $"Scheduled At: {post.ScheduledAt}\r\n" +
                $"Message: \"{post.Message}\"";
            }
        }

        private void buttonScheduledPostRemove_Click(object sender, EventArgs e)
        {
            ScheduledPost post = listBoxScheduledPosts.SelectedItem as ScheduledPost;

            if (post != null)
            {
                removePostFromScheduler(post);
            }
            
        }

       

        private void addDataToChartCategories()
        {
            Series series = chartCategories.Series["Series1"];
            foreach (var kvp in m_PagesStats.Categories)
            {
                series.Points.AddXY(kvp.Key, kvp.Value);
            }
        }

        private void addTextToIsPublishedTextBox()
        {
            IsPublishedTextBox.Text = $@"There Are 
{m_PagesStats.NumberOfPublishedPages} Published Pages 
and {PageStatistic.PagesCollectionSize - m_PagesStats.NumberOfPublishedPages}
 unPublished Pages ";

        }

        private void addTextToCommunityTextBox()
        {
   IsCummunityTextBox.Text = $@"There Are 
{m_PagesStats.NumberOfCommunityPages} Community Pages 
and {PageStatistic.PagesCollectionSize - m_PagesStats.NumberOfPublishedPages}
 Community Pages ";
        }

        private void addItemsToListTopChecknPages()
        {
            foreach (var page in m_PagesStats.Top4MostCheckInPages)
            {
                listTopCheckinPages.Items.Add(page.Name);
            }
        }

        private void addItemsToListTopLikedPages()
        {
            foreach (var page in m_PagesStats.Top4MostLikedPages)
            {
                listViewTop4LikedPages.Items.Add(page.Name);
            }
        }

        private void tabPageStats_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl.SelectedTab.Name == "tabPageStatistic")
            {
                try
                {
                    if (m_LoginResult.LoggedInUser == null)
                    {
                        throw new InvalidOperationException(" User must log in before . ");
                    }
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tabControl.SelectedIndex = 0;
                    return;
                }

                if (listTopCheckinPages.Items.Count == 0)
                {
                    m_PagesStats = m_PagesStats.GetPageStatistic(m_LoginResult.LoggedInUser.LikedPages);
                    addItemsToListTopChecknPages();
                    addItemsToListTopLikedPages();
                    addTextToCommunityTextBox();
                    addTextToIsPublishedTextBox();
                    addDataToChartCategories();
                }
            }
        }
   
    }
}
