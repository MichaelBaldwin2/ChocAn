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
    /// Interaction logic for MemberDeleteInfo.xaml
    /// </summary>
    public partial class MemberDeleteInfo : Window
    {
        private Regex numOnlyRegex = new Regex("[^0-9.-]+");
        public MemberDeleteInfo()
        {
            InitializeComponent();
        }
        
        private void btnBackToMain_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private async void btnMemberDelete_Click(object sender, RoutedEventArgs e)
        {
            var memberID = inMemberID.Password;
            var isMemberID = !numOnlyRegex.IsMatch(memberID);

            if (!isMemberID)
            {
                lblMemberIDInputError.Content = "Member ID must be numerical!";
                return;
            }

            DataCenter.DeleteMemberAccount(memberID);
            lblMemberIDInputError.Content = "Member successfully deleted";

            await Task.Delay(2000);

            btnBackToMain_Click(sender, e);

        }
    }
}
