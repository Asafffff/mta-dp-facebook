using FacebookWrapper.ObjectModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.Schedulers.PostScheduler
{
    public class DatePostIterator : IEnumerable<ScheduledPost>
    {
        private readonly List<ScheduledPost> m_Posts;
        private readonly DateTime m_TargetDate;

        public DatePostIterator(List<ScheduledPost> posts, DateTime targetDate)
        {
            m_Posts = posts;
            m_TargetDate = targetDate.Date;
        }
        public IEnumerator<ScheduledPost> GetEnumerator()
        {
           
            foreach (var post in m_Posts)
            {
                if ( post.ScheduledAt.Date == m_TargetDate)
                {      
                    yield return post;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
