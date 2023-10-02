using FacebookWrapper.ObjectModel;
using System.Linq;

namespace BasicFacebookFeatures.PageStatisticsGenerator
{
    abstract class ListsUpdater
    {
        protected const int k_ListsShowSize = 4;
        protected abstract void SortPages(FacebookObjectCollection<Page> i_Pages);

        public void AddTopPages(FacebookObjectCollection<Page> i_Pages, FacebookObjectCollection<Page> i_newList)
        {
            SortPages(i_Pages);
            foreach (var page in i_Pages.Take(k_ListsShowSize))
            {
                i_newList.Add(page);
            }
        }
    }
}
