using System;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Navigation;
using System.Collections.Generic;
using System.Windows.Media.Imaging;

using MicroMVVM.Expence.Daily;
using System.Xml.Linq;
using System.IO;

namespace ExpenceBook
{
    /// <summary>
    /// Interaction logic for GraphView.xaml
    /// </summary>
    public partial class GraphView : UserControl
    {
        public GraphView()
        {
            InitializeComponent();
        }

        private void showColumnChart()
        {
            string transactionType = ComboBox1.Text;

            List<DailyExpence> lstdailyExpence = new List<DailyExpence>();

            lstdailyExpence = DailyExpence.showColumnChart(transactionType);

            list.DataContext = lstdailyExpence;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            showColumnChart();
        }
    }
}
