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
    /// Interaction logic for OperatorLogin.xaml
    /// </summary>
    public partial class OperatorLogin : Window
    {
        private Regex numOnlyRegex = new Regex("[^0-9.-]+");
        public OperatorLogin()
        {
            InitializeComponent();
        }

        private void btnBackToMain_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void btnOperatorLogin_Click(object sender, RoutedEventArgs e)
        {
            var operatorID = inOperatorID.Password;
            var isOperatorID = !numOnlyRegex.IsMatch(operatorID);

            if (!isOperatorID)
            {
                lblOperatorIDInputError.Content = "Operator ID must be numerical!";
                return;
            }

            if (operatorID != "0000")
            {
                lblOperatorIDInputError.Content = "Incorrect Operator ID (Hint: It's '0000')";
                return;
            }

            OperatorPanel operatorPanelWindow = new OperatorPanel();
            operatorPanelWindow.Show();
            this.Close();
        }
    }
}
