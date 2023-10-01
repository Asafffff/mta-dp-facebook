using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.PageStatisticsGenerator
{
    internal class MostCheckInUpdater:ListsUpdater
    {
        protected override void SortPages(FacebookObjectCollection<Page> pages)
        {
            pages.OrderBy(page => page.CheckinsCount);
        }

    }
}
