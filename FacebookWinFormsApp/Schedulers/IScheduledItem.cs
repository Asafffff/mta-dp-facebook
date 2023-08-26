using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public interface IScheduledItem
    {
        int Id { get; }
        string Message { get;  }
        DateTime ScheduledAt { get; }

        event Action<ScheduledPost> ScheduleTriggered;
    }
}
