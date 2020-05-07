﻿using System;
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
    /// Interaction logic for MemberInfoPrompt.xaml
    /// </summary>
    public partial class MemberInfoPrompt : Window
    {
        public MemberInfoPrompt()
        {
            InitializeComponent();
        }

        private void btnBackToMain_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void btnMemberValidate_Click(object sender, RoutedEventArgs e)
        {
            var memberID = inMemberID.Password;
            
            if (!DataCenter.ValidateMember(memberID))
            {
                lblMemberIDInputError.Content = "Member not found";
                return;
            }

            MessageBox.Show("Member " + DataCenter.RequestMemberInfo(memberID).Name + " (" + memberID + ") is valid.");
            btnBackToMain_Click(sender, e);           

        }
    }
}
