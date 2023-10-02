using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.PageStatisticsGenerator
{
    internal class MostLikedPagesUpdater:ListsUpdater
    {
        protected override void SortPages(FacebookObjectCollection<Page> i_Pages)
        {
            i_Pages.OrderBy(page => page.LikesCount);
        }
        }
    }
