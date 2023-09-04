using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.PageStatisticsGenerator
{
    public class StatisticFactory
    {
        public enum ButtonName
        {
            PageStatistic,
            TeamStatistic
        }
        public Statistic Create(string i_buttonName)
        {
            Enum.TryParse(i_buttonName, out ButtonName chosenStatistic);
            switch (chosenStatistic):

            return new PageStatistics(FBService.User);
        }
    }
}
