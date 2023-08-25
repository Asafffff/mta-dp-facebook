using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class PostSchedulerAdapter: IScheduler
    {
        PostScheduler m_PostScheduler = null;

        public int Count
        {
            get
            {
                return m_PostScheduler.Count;
            }
        }
        public int MaxPosts
        {
            get
            {
                return m_PostScheduler.MaxPosts;
            }
        }

        public PostSchedulerAdapter(PostScheduler postScheduler)
        {
            m_PostScheduler = postScheduler;
        }

        public Task Schedule(IScheduledItem i_Item)
        {
            return m_PostScheduler.Schedule((ScheduledPost)i_Item);
        }

        public void Cancel(IScheduledItem i_Item)
        {
            m_PostScheduler.Cancel((ScheduledPost)i_Item);
        }
    }
}
