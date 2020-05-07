using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    /// Interaction logic for OperatorPanel.xaml
    /// </summary>
    public partial class OperatorPanel : Window
    {
        public OperatorPanel()
        {
            InitializeComponent();
        }

        private void btnBackToMain_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void btnOperatorEditMembers_Click(object sender, RoutedEventArgs e)
        {
            OperatorPanelManageUsers operatorPanelManageUsersWindow = new OperatorPanelManageUsers();
            operatorPanelManageUsersWindow.Show();
            this.Close();
        }

        private void btnOperatorRunAccountingProcedure_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnGenerateSummaryReport_Click(object sender, RoutedEventArgs e)
        {
            GenerateReport.GenerateSummaryReport("SummaryReport");
        }

        private void btnGenerateProviderReport_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnGenerateMemberReport_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnGenerateAllProviderReports_Click(object sender, RoutedEventArgs e)
        {
            GenerateReport.GenerateAllProviderReports();
        }

        private void btnGenerateAllMemberReports_Click(object sender, RoutedEventArgs e)
        {
            GenerateReport.GenerateAllMemberReports();
        }
    }
}
