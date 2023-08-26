using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class PostScheduler
    {
        private List<ScheduledPost> m_ScheduledPosts = new List<ScheduledPost>();
        private const int k_MaxPosts = 6;
        public int Count {
            get { return m_ScheduledPosts.Count; }
        }
        public int MaxPosts
        {
            get { return k_MaxPosts; }
        }

        public PostScheduler() {}

        async public Task Schedule(ScheduledPost i_Post)
        {
            TimeSpan timeToWait = i_Post.ScheduledAt - DateTime.Now;

            m_ScheduledPosts.Add(i_Post);

            await Task.Delay(timeToWait);

            if (m_ScheduledPosts.Contains(i_Post))
            {
                i_Post.OnScheduleTrigger();
            }
        }

        public void Cancel(ScheduledPost i_Post) {
            m_ScheduledPosts.RemoveAll(x => x.Id == i_Post.Id);
        }
    }
}
