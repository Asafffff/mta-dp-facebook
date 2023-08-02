using System;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class ScheduledPost
    {
        private static int s_Id = 0;
        public int Id { get; set; }
        public string Message { get; private set; }
        public DateTime ScheduledAt { get; private set; }
        public event Action<ScheduledPost> ScheduleTriggered;

        public ScheduledPost(string i_Message, DateTime i_ScheduledAt)
        {
            validateScheduledTime(i_ScheduledAt);

            if (i_Message == "")
            {
                throw new ArgumentNullException("Message can not be empty");
            }

            Id = ++s_Id;
            Message = i_Message;
            ScheduledAt = i_ScheduledAt;
        }

        private void validateScheduledTime(DateTime i_ScheduledAt)
        {
            TimeSpan timeToWait = i_ScheduledAt - DateTime.Now;
            if (timeToWait.TotalMilliseconds <= 0)
            {
                throw new TaskSchedulerException("Selected time is in the past. Please choose a future time");
            }
        }

        public void OnScheduleTrigger()
        {
            ScheduleTriggered?.Invoke(this);
        }
    }
}
