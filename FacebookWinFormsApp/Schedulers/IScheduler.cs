using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public interface IScheduler
    {
        int Count {  get; }
        int MaxPosts { get; }

        Task Schedule(IScheduledItem i_Item);
        void Cancel(IScheduledItem i_Item);
    }
}
