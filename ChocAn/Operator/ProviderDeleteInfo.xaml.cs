using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ChocAn
{
    /// <summary>
    /// Interaction logic for ProviderDeleteInfo.xaml
    /// </summary>
    public partial class ProviderDeleteInfo : Window
    {
        private Regex numOnlyRegex = new Regex("[^0-9.-]+");
        public ProviderDeleteInfo()
        {
            InitializeComponent();
        }

        private void btnBackToMain_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private async void btnProviderDelete_Click(object sender, RoutedEventArgs e)
        {
            var providerID = inProviderID.Password;
            var isProviderID = !numOnlyRegex.IsMatch(providerID);

            if (!isProviderID)
            {
                lblProviderIDInputError.Content = "Provider ID must be numerical!";
                return;
            }

            DataCenter.DeleteProviderAccount(providerID);
            lblProviderIDInputError.Content = "Provider successfully deleted";

            await Task.Delay(2000);

            btnBackToMain_Click(sender, e);
        }
    }
}
