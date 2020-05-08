using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for ProviderLogin.xaml
    /// </summary>
    public partial class ProviderLogin : Window
    {
        private Regex numOnlyRegex = new Regex("[^0-9.-]+");

        public ProviderLogin()
        {
            InitializeComponent();
        }

        private void btnBackToMain_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void btnProviderLogin_Click(object sender, RoutedEventArgs e)
        {
            var providerNumber = inProviderID.Password;
            var isProviderID = !numOnlyRegex.IsMatch(providerNumber);

            if (!isProviderID)
            {
                lblProviderIDInputError.Content = "Provider ID must be numerical!";
                return;
            }
            
            var provider = DataCenter.RequestProviderInfo(providerNumber);
            if(provider != null)
            {
                ProviderPanel providerPanelWindow = new ProviderPanel(providerNumber);
                providerPanelWindow.Show();
                this.Close();
            }
            else
            {
                lblProviderIDInputError.Content = "Provider ID does not exist in the database!";
            }
        }
    }
}
