using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BasicFacebookFeatures.PageStatisticsGenerator
{
    public interface IStatisticHandler
    {
        void ProcessStatistic();
        void AddDataToPieChart(Series i_Series);
        void AddTextToFirstTextBox(RichTextBox i_TextBox);
        void AddTextToSecondTextBox(RichTextBox i_TextBox);
        void AddDataToSecondListView(ListView i_ListView);
        void AddDataToFirstListView(ListView i_ListView);
    }
}
