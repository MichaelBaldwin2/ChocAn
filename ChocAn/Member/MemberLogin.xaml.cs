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
    /// Interaction logic for MemberLogin.xaml
    /// </summary>
    public partial class MemberLogin : Window
    {
        private Regex numOnlyRegex = new Regex("[^0-9.-]+");
        public MemberLogin()
        {
            InitializeComponent();
        }

        private void btnBackToMain_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void btnMemberLogin_Click(object sender, RoutedEventArgs e)
        {
            var memberID = inMemberID.Password;
            var isMemberID = !numOnlyRegex.IsMatch(memberID);

            if (!isMemberID)
            {
                lblMemberIDInputError.Content = "Member ID must be numerical!";
                return;
            }

            if (memberID != "0000")
            {
                lblMemberIDInputError.Content = "Incorrect Member ID (Hint: It's '0000')";
                return;
            }

            MemberPanel memberPanelWindow = new MemberPanel();
            memberPanelWindow.Show();
            this.Close();
        }
    }
}
