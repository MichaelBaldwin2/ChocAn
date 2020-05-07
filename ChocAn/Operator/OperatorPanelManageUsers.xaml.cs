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
    /// Interaction logic for OperatorPanelManageUsers.xaml
    /// </summary>
    public partial class OperatorPanelManageUsers : Window
    {
        public OperatorPanelManageUsers()
        {
            InitializeComponent();
        }

        private void btnBackToMain_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }


        private void btnNewProvider_Click(object sender, RoutedEventArgs e)
        {
            // Check all the inputs
            var provider = new Provider(inProviderName.Text, inProviderNumber.Text, inProviderAddress.Text, inProviderCity.Text, inProviderState.Text, inProviderZip.Text, true);
            DataCenter.WriteProviderInfo(provider);
        }

        private void btnNewMember_Click(object sender, RoutedEventArgs e)
        {
            // Check all the inputs
            var member = new Member(inMemberName.Text, inMemberNumber.Text, inMemberAddress.Text, inMemberCity.Text, inMemberState.Text, inMemberZip.Text, true);
            DataCenter.WriteMemberInfo(member);
        }
    }
}
