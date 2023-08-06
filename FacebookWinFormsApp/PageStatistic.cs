using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BasicFacebookFeatures
{
    public class PageStatistic
    {
        public string Message { get; private set; }
        public int NumberOfCategories { get; private set;}
        public int NumberOfPublishedPages { get; private set; }
        public int NumberOfComunityPages { get; private set; }
        public List<FacebookWrapper.ObjectModel.Page> Top4MostCheckinPages { get; private set; }
        public List<FacebookWrapper.ObjectModel.Page> Top4MostLikedPages { get; private set; }
        public Dictionary<string, int> Categories { get; private set; } 

        public PageStatistic()
        {
            Top4MostCheckinPages = new List<FacebookWrapper.ObjectModel.Page>();
            Top4MostLikedPages = new List<FacebookWrapper.ObjectModel.Page> ();
            Categories = new Dictionary<string, int>();
        }
        public PageStatistic GetPageStatistic( FacebookObjectCollection<FacebookWrapper.ObjectModel.Page> likedPages) 
        {

            foreach (FacebookWrapper.ObjectModel.Page page in likedPages)
            {
                if (page.IsPublished== true)
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

        private void updateCategories(FacebookWrapper.ObjectModel.Page page)
        {
            if (page.Category != null)
            {
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
        }

        private void updateTop4MostLikedPages(FacebookObjectCollection<FacebookWrapper.ObjectModel.Page> likedPages)
        {
            likedPages.OrderByDescending(ob => ob.LikesCount);
            for (int i=0; i < 4 && i< likedPages.Count; i++)
            {
                Top4MostLikedPages.Add(likedPages[i]);
            }
            
        }

        private void updateTop4MostCheckinPages(FacebookObjectCollection<FacebookWrapper.ObjectModel.Page> likedPages)
        {
            likedPages.OrderByDescending(ob => ob.CheckinsCount);
            for (int i = 0; i < 4 && i < likedPages.Count; i++)
            {
                Top4MostLikedPages.Add(likedPages[i]);
            }
        }

    }
}
