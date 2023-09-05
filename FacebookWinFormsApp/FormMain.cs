using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;
using BasicFacebookFeatures.PageStatisticsGenerator;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private IScheduler m_PostScheduler = new PostSchedulerAdapter(new PostScheduler());
        private ProxyStatisticHandler m_Stats;
        private List<PictureBox> m_PhotosNameInControl = new List<PictureBox>();
        
        public FormMain()
        {
            InitializeComponent();

            listBoxScheduledPosts.DisplayMember = "Message";
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns");

            User user = FBService.User;

            if (user == null)
            {
                return;
            }

            buttonLogin.Text = $"Logged in as {user.Name}";
            buttonLogin.BackColor = Color.LightGreen;
            buttonLogin.Enabled = false;
            buttonLogout.Enabled = true;
            buttonLogout.BackColor = System.Drawing.Color.Red;

            pictureBoxProfile.ImageLocation = user.PictureNormalURL;

            labelName.Text = user.Name;
            labelLivesIn.Text = user.Location.Name;
            labelBirthday.Text = user.Birthday;

            enableFetchLinkLabels();
            enableButtons();

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

            FBService.Logout();

            buttonLogin.Text = "Login";
            buttonLogin.BackColor = System.Drawing.Color.LightSkyBlue;
            buttonLogout.BackColor = System.Drawing.Color.Transparent;
            
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;

            disableFetchLinkLabels();
            disableButtons();
            clearAllDataOfAUserFromForm();
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
            foreach(PictureBox name in m_PhotosNameInControl)
            {
                tabPageMain.Controls.Remove(name);
            }
            m_PhotosNameInControl.Clear();
        }
        private void linkLabelFetchNewsfeed_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Thread(fetchNewsFeed).Start();
        }
        private void linkLabelFetchPosts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Thread(fetchPosts).Start();
        }
        private void linkLabelFetchPhotos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Thread(fetchPhotos).Start();
        }
        private void fetchNewsFeed()
        {
            try
            {
                FacebookObjectCollection<Post> newsFeed = FBService.User.NewsFeed;

                listBoxNewsFeed.Invoke(new Action(() =>
                {
                    listBoxNewsFeed.SelectedIndexChanged -= listBoxNewsFeed_SelectedIndexChanged;
                    listBoxNewsFeed.DataSource = newsFeed;
                    listBoxNewsFeed.SelectedIndexChanged += listBoxNewsFeed_SelectedIndexChanged;

                    if (listBoxNewsFeed.Items.Count == 0)
                    {
                        MessageBox.Show("Newsfeed is empty");
                    }
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void fetchPosts()
        {
            try
            {
                FacebookObjectCollection<Post> posts = FBService.User.Posts;

                listBoxPosts.Invoke(new Action(() =>
                {
                    listBoxPosts.SelectedIndexChanged -= listBoxPosts_SelectedIndexChanged;
                    listBoxPosts.DataSource = posts;
                    listBoxPosts.SelectedIndexChanged += listBoxPosts_SelectedIndexChanged;

                    if (listBoxPosts.Items.Count == 0)
                    {
                        MessageBox.Show("No Posts to retrieve");
                    }
                }));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void fetchComments(Post i_Post)
        {
            try
            {
                FacebookObjectCollection<Comment> comments = i_Post.Comments;

                listBoxComments.Invoke(new Action(() =>
                {
                    listBoxComments.DataSource = comments;

                    if (listBoxComments.Items.Count == 0)
                    {
                        listBoxComments.DataSource = null;
                        listBoxComments.Items.Add("No comments found");
                    }
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void fetchPhotos()
        {
            try
            {
                int i = 0, j = 0;

                int pictureBoxWidth = 77;
                int pictureBoxLength = 77;
                int spaceFromLabel = 30;

                FacebookObjectCollection<Album> albums = FBService.User.Albums;

                tabPageMain.Invoke(new Action(() =>
                {
                    if (albums.Count == 0 || albums[0].Photos.Count == 0)
                    {
                        MessageBox.Show("There are no albums or photos");
                    }

                    FacebookObjectCollection<Photo> photos = (FacebookObjectCollection<Photo>)albums[0].Photos;

                    tabPageMain.Invoke(new Action(() =>
                    {
                        foreach (Photo photo in photos.Take(6))
                        {
                            PictureBox pictureBox = new PictureBox();
                            pictureBox.Name = photo.Name;
                            pictureBox.Size = new Size(pictureBoxWidth, pictureBoxLength);
                            pictureBox.ImageLocation = photo.PictureNormalURL;
                            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                            pictureBox.Location = new Point(
                                labelPhotos.Left + 6 + i * (pictureBoxWidth + 18),
                                labelPhotos.Top + labelPhotos.Height + spaceFromLabel + j * (pictureBoxLength + 12));
                            tabPageMain.Controls.Add(pictureBox);
                            m_PhotosNameInControl.Add(pictureBox);
                            pictureBox.BringToFront();

                            i++;
                            if (i % 3 == 0)
                            {
                                i = 0;
                                j++;
                            }
                        }
                    }));
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPosts.SelectedIndex != -1)
            {
                Post post = listBoxPosts.SelectedItem as Post;
                new Thread(() => fetchComments(post));
            }
        }
        private void listBoxNewsFeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxNewsFeed.SelectedIndex != -1)
            {
                Post post = listBoxNewsFeed.SelectedItem as Post;
                new Thread(() => fetchComments(post));
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
                    FBService.User.PostStatus(i_Text);
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
                post.ScheduleTriggered += scheduledPostTriggered;
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
        private void scheduledPostTriggered(ScheduledPost i_Post)
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
            if (listBoxScheduledPosts.SelectedItem is ScheduledPost post)
            {
                buttonScheduledPostRemove.Enabled = true;
                textBoxScheduledPostDetails.Text = $"Post ID: {post.Id}\r\n" +
                $"Scheduled At: {post.ScheduledAt}\r\n" +
                $"Message: \"{post.Message}\"";
            }
        }
        private void buttonScheduledPostRemove_Click(object sender, EventArgs e)
        {
            if (listBoxScheduledPosts.SelectedItem is ScheduledPost post)
            {
                removePostFromScheduler(post);
            }
        }
        private void addDataToChartCategories()
        {
            Series series = chartCategories.Series["Series1"];
            m_Stats.AddDataToPieChart(series);
        }
        private void addTextToLowerTextBox()
        {
            m_Stats.AddTextToSecondTextBox(TextBoxUpper);
        }
        private void addTextToUpperTextBox()
        {
            m_Stats.AddTextToFirstTextBox(TextBoxBottom);
        }
        private void addItemsToUpperListView()
        {
            m_Stats.AddDataToFirstListView(listViewTop);
        }
        private void addItemsToLowerListView()
        {
            m_Stats.AddDataToSecondListView(listViewBottom);
        }
        private void tabPageStats_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl.SelectedTab.Name == "tabPageStatistic")
            {
                try
                {
                    if (buttonLogin.Enabled == true)
                    {
                        throw new InvalidOperationException("User must be logged-in");
                    }
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tabControl.SelectedIndex = 0;
                    return;
                }

                if (m_Stats == null)
                {
                    m_Stats = new ProxyStatisticHandler("tabPageStatistic");
                    m_Stats.ProcessStatistic();
                    addItemsToUpperListView();
                    addItemsToLowerListView();
                    addTextToUpperTextBox();
                    addTextToLowerTextBox();
                    addDataToChartCategories();
                }
            }
        }
    }
}
