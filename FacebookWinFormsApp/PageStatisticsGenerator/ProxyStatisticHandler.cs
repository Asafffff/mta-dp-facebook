using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BasicFacebookFeatures.PageStatisticsGenerator
{
    public class ProxyStatisticHandler : IStatisticHandler
    {
        private IStatisticHandler m_RealHandler;

        public enum eStatisticTypesStr
        {
            tabPageStatistic,
            tabTeamsStatistic
        }
        public ProxyStatisticHandler(string i_StatisticTypeStr)
        {
            Enum.TryParse(i_StatisticTypeStr, out eStatisticTypesStr statistic);

            switch (statistic)
            {
                case eStatisticTypesStr.tabPageStatistic:
                    m_RealHandler = new PageStatistics();
                    break;
                //case StatisticTypeStr.tabTeamsStatistic:
                // m_RealHandler= new TeamsStatistic();
                default:
                    throw new NotImplementedException();
            }
        }
        public void ProcessStatistic()
        {
            m_RealHandler.ProcessStatistic();
        }
        public void AddDataToPieChart(Series i_Series)
        {
            m_RealHandler.AddDataToPieChart(i_Series);
        }
        public void AddTextToFirstTextBox(RichTextBox i_TextBox)
        {
            m_RealHandler.AddTextToFirstTextBox(i_TextBox);
        }
        public void AddTextToSecondTextBox(RichTextBox i_TextBox)
        {
            m_RealHandler.AddTextToSecondTextBox(i_TextBox);
        }
        public void AddDataToSecondListView(ListView i_ListView)
        {
            m_RealHandler.AddDataToSecondListView(i_ListView);
        }
        public void AddDataToFirstListView(ListView i_ListView)
        {
            m_RealHandler.AddDataToFirstListView(i_ListView);
        }
    }
}
