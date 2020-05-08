﻿using System;
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
    /// Interaction logic for ManagerLogin.xaml
    /// </summary>
    public partial class ManagerLogin : Window
    {
		private Regex numOnlyRegex = new Regex("[^0-9.-]+");
		public ManagerLogin()
        {
            InitializeComponent();
        }

        private void btnBackToMain_Click(object sender, RoutedEventArgs e)
        {
			MainWindow mainWindow = new MainWindow();
			mainWindow.Show();
			this.Close();
        }

        private void btnManagerLogin_Click(object sender, RoutedEventArgs e)
        {
			var managerID = inManagerID.Password;
			var isManagerID = !numOnlyRegex.IsMatch(managerID);

			if (!isManagerID)
			{
				lblManagerIDInputError.Content = "Manager ID must be numerical!";
				return;
            }

            if (managerID == "0000")
            {
                ManagerPanel managerPanelWindow = new ManagerPanel();
                managerPanelWindow.Show();
                this.Close();
            }
            else
            {
                lblManagerIDInputError.Content = "Manager ID does not exist in the database! Hint: It's '0000'";
            }
		}
	}
}
