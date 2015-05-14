using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPF.MDI;

namespace ExpenceBook
{
    /// <summary>
    /// Interaction logic for mdiWindow.xaml
    /// </summary>
    public partial class mdiWindow : Window
    {
        public mdiWindow()
        {
            InitializeComponent();

            if (!System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
            {
                return;
            }
        }

        private void dailyExpence_Click(object sender, RoutedEventArgs e)
        {
            MainMdiContainer.Children.Add(new MdiChild()
            {
                Title = "Daily Spending",
                Height = 600,
                Width = 600,

                Content = new DailySpending()
            });
        }

        private void expenceList_Click(object sender, RoutedEventArgs e)
        {
            MainMdiContainer.Children.Add(new MdiChild()
            {
                Title = "Daily Expence List ",
                Height = 600,
                Width = 600,

                Content = new DailyExpenceList()
            });
        }

        private void graphicalReport_Click(object sender, RoutedEventArgs e)
        {
            MainMdiContainer.Children.Add(new MdiChild()
            {
                Title = "Daily Spending Graph",
                Height = 600,
                Width = 600,

                Content = new GraphView()
            });
        }

        private void account_Click(object sender, RoutedEventArgs e)
        {
            MainMdiContainer.Children.Add(new MdiChild()
            {
                Title = "AccountView",
                Height = 600,
                Width = 600,

                Content = new account()
            });
        }

        private void exitApp_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();

            Close();

            login.Show();
        }
    }
}
