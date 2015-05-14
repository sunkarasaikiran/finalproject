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
using MicroMVVM.Expence.Daily;
using System.Configuration;

namespace ExpenceBook
{
    /// <summary>
    /// Interaction logic for account.xaml
    /// </summary>
    public partial class account : UserControl
    {
        public account()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string transactionType = dropdown.Text;

            List<DailyExpence> AccountTypeDailyExpence = new List<DailyExpence>();

            string loginId = ConfigurationManager.AppSettings["loginUserId"];

            AccountTypeDailyExpence = DailyExpence.FillAccountTypeExpenceList(loginId, transactionType);

            AccountTypeExpence.DataContext = AccountTypeDailyExpence;
        }
    }
}
