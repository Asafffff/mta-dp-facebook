using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
using System.Linq;

namespace BasicFacebookFeatures
{
    public class PageStatistics
    {
        public const int k_PagesCollectionSize = 25;
        public const int k_ListPagesSize = 4;

        public int NumberOfCategories { get; private set; }
        public int NumberOfPublishedPages { get; private set; }
        public int NumberOfCommunityPages { get; private set; }
        public FacebookObjectCollection<Page> TopMostCheckInPages { get; private set; }
        public FacebookObjectCollection<Page> TopMostLikedPages { get; private set; }
        public Dictionary<string, int> Categories { get; private set; }

        public PageStatistics()
        {
            TopMostCheckInPages = new FacebookObjectCollection<Page>();
            TopMostLikedPages = new FacebookObjectCollection<Page>();
            Categories = new Dictionary<string, int>();
        }

        public PageStatistics GetPageStatistics(FacebookObjectCollection<Page> i_Pages)
        {

            foreach (Page page in i_Pages)
            {
                if (page.IsPublished == true)
                {
                    NumberOfPublishedPages++;
                }
                if (page.IsCommunityPage == true)
                {
                    NumberOfCommunityPages++;
                }
                updateCategories(page);

            }
            updateTopMostLikedPages(i_Pages);
            updateTopMostCheckInPages(i_Pages);
            return this;
        }

        private void updateCategories(Page i_Page)
        {
            if (i_Page.Category != null)
                if (!Categories.ContainsKey(i_Page.Category))
                {
                    Categories.Add(i_Page.Category, 0);
                    NumberOfCategories++;
                }
                else
                {
                    Categories[i_Page.Category]++;
                }
        }

        private void updateTopMostLikedPages(FacebookObjectCollection<Page> i_Pages)
        {
            i_Pages.OrderByDescending(i_Page => i_Page.LikesCount);

            for (int i = k_PagesCollectionSize-1; i >= k_PagesCollectionSize- k_ListPagesSize && i < i_Pages.Count; i--)
            {
                TopMostLikedPages.Add(i_Pages[i]);
            }
        }

        private void updateTopMostCheckInPages(FacebookObjectCollection<Page> i_Pages)
        {
            i_Pages.OrderByDescending(i_Page => i_Page.CheckinsCount);
            for (int i = k_PagesCollectionSize - 1; i >= k_PagesCollectionSize - k_ListPagesSize && i < i_Pages.Count; i--)
            {
                TopMostCheckInPages.Add(i_Pages[i]);
            }
        }
    }
}

// functions for unreal Data!!
        /*
        public struct PageTwo
        {
            public string Name;
            public string URL;
            public string Phone;
            public string Category;
            public string Website;
            public string Description;
            public bool? IsPublished;
            public bool? IsCommunityPage;
            public bool? LoggedInUserCanPost;
            public long? LikesCount;
            public long? CheckinsCount;
            public long? TalkingAboutCount;
            public Location Location;
            public Cover Cover;
            public string AccessToken;
        }

        public class Location
        {
            public string City;
            public string Country;
            public double Latitude;
            public double Longitude;
        }

        public class Cover
        {
            public string Source;
            public int OffsetY;
        }
        public PageTwo[] create()
        {
            // Create an array of PageTwo instances
            PageTwo[] pageTwoArray = new PageTwo[25];

            string[] categories = {
            "Category A", "Category B", "Category C",
            "Category D", "Category E", "Category F", "Category G"
        };

            Random random = new Random();

            for (int i = 0; i < 25; i++)
            {
                PageTwo pageTwo = new PageTwo
                {
                    Name = $"Page {i + 1}",
                    URL = $"https://www.facebook.com/page{i + 1}",
                    Phone = $"123-456-{i:00}",
                    Category = categories[random.Next(categories.Length)],
                    Website = $"https://www.example.com/page{i + 1}",
                    Description = $"This is a sample description for Page {i + 1}",
                    IsPublished = i % 3 == 0,
                    IsCommunityPage = i % 5 == 0,
                    LoggedInUserCanPost = true,
                    LikesCount = i * 1000,
                    CheckinsCount = i * 50,
                    TalkingAboutCount = i * 200,
                    Location = new Location
                    {
                        City = $"City{i + 1}",
                        Country = $"Country{i + 1}",
                        Latitude = 12.345 + i,
                        Longitude = 67.890 + i
                    },
                    Cover = new Cover
                    {
                        Source = $"https://www.example.com/cover{i + 1}.jpg",
                        OffsetY = i * 10
                    },
                    AccessToken = $"AccessToken{i + 1}"
                };

                pageTwoArray[i] = pageTwo;
            }

            return pageTwoArray;

            // Now you have an array of PageTwo instances


        }




        public PageStatistic GetPageStatistic()
        {
            PageTwo[] likedPages = create();

            foreach (PageTwo page in likedPages)
            {
                if (page.IsPublished == true)
                {
                    NumberOfPublishedPages++;
                }
                if (page.IsCommunityPage == true)
                {
                    NumberOfComunityPages++;
                }
                updateCategories(page);

            }
            updateTop4MostLikedPages(likedPages);
            updateTop4MostCheckinPages(likedPages);
            return this;
        }

        private void updateCategories(PageTwo page)
        {
            if (page.Category != null)
                if (!Categories.ContainsKey(page.Category))
                {
                    Categories.Add(page.Category, 0);
                    NumberOfCategories++;
                }
                else
                {
                    Categories[page.Category]++;
                }
        }

        private void updateTop4MostLikedPages(PageTwo[] likedPages)
        {
            likedPages.OrderBy(ob => ob.LikesCount);
            //need to do from 25 to 21!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!
            for (int i = 0; i < 4; i++)
            {
                Top4MostLikedPages.Add(likedPages[i]);
            }

        }

        private void updateTop4MostCheckinPages(PageTwo[] likedPages)
        {
            likedPages.OrderBy(ob => ob.CheckinsCount);
            //need to do from 25 to 21
            for (int i = 0; i < 4; i++)
            {
                Top4MostCheckinPages.Add(likedPages[i]);
            }
        }

    }
}
        */