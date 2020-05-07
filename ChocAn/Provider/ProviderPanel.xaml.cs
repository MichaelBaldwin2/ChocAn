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
    /// Interaction logic for ProviderPanel.xaml
    /// </summary>
    public partial class ProviderPanel : Window
    {
        public ProviderPanel()
        {
            InitializeComponent();
        }

        private void btnValidateMember_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnBillChocAn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Your bill has been sent. Thank you!");
        }

        private void btnProviderDirectory_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnBackToMain_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void btnAddService_Click(object sender, RoutedEventArgs e)
        {
            AddService addServiceWindow = new AddService();
            addServiceWindow.Show();
            this.Close();
        }
    }
}
