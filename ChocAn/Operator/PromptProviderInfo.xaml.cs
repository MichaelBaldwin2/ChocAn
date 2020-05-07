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
    /// Interaction logic for PromptProviderInfo.xaml
    /// </summary>
    public partial class PromptProviderInfo : Window
    {
        private Regex numOnlyRegex = new Regex("[^0-9.-]+");
        public PromptProviderInfo()
        {
            InitializeComponent();
        }

        private void btnBackToMain_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void btnProviderReportGenerate_Click(object sender, RoutedEventArgs e)
        {
            var providerNumber = inProviderID.Password;
            var isProviderID = !numOnlyRegex.IsMatch(providerNumber);

            if (!isProviderID)
            {
                lblProviderIDInputError.Content = "Provider ID must be numerical!";
                return;
            }

            if (providerNumber != "0000")
            {
                lblProviderIDInputError.Content = "Incorrect Provider ID (Hint: It's '0000')";
                return;
            }

            GenerateReport.GenerateProviderReport(providerNumber);
            btnBackToMain_Click(sender, e);
            
        }
    }
}
