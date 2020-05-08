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
            if(!int.TryParse(inProviderNumber.Text, out int _))
            {
                lblInputError.Content = "Provider Number must be numerical!";
                return;
            }

            var provider = new Provider(inProviderName.Text, inProviderNumber.Text, inProviderAddress.Text, inProviderCity.Text, inProviderState.Text, inProviderZip.Text, true);
            DataCenter.WriteProviderInfo(provider);
        }

        private void btnNewMember_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(inMemberNumber.Text, out int _))
            {
                lblInputError.Content = "Member Number must be numerical!";
                return;
            }
            var member = new Member(inMemberName.Text, inMemberNumber.Text, inMemberAddress.Text, inMemberCity.Text, inMemberState.Text, inMemberZip.Text, true);
            DataCenter.WriteMemberInfo(member);
        }

        private void btnDeleteProvider_Click(object sender, RoutedEventArgs e)
        {
            ProviderDeleteInfo providerDeleteInfoWindow = new ProviderDeleteInfo();
            providerDeleteInfoWindow.Show();
            this.Close();
        }

        private void btnDeleteMember_Click(object sender, RoutedEventArgs e)
        {
            MemberDeleteInfo memberDeleteInfoWindow = new MemberDeleteInfo();
            memberDeleteInfoWindow.Show();
            this.Close();
        }
    }
}
