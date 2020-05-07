using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChocAn
{
    public partial class ManagerTerminalForm : Form
    {
        public ManagerTerminalForm()
        {
            InitializeComponent();
        }

        private void generateSummaryReportButton_Click(object sender, EventArgs e)
        {
            EnterFileNameWindow enterFileNameWindow = new EnterFileNameWindow();
            enterFileNameWindow.ShowDialog();
        }

        private void generateMemberReportButton_Click(object sender, EventArgs e)
        {
            EnterMemberNumberWindow enterMemberNumberWindow = new EnterMemberNumberWindow();
            enterMemberNumberWindow.ShowDialog();
        }

        private void generateProviderReportButton_Click(object sender, EventArgs e)
        {
            EnterProviderNumberWindow enterProviderNumberWindow = new EnterProviderNumberWindow();
            enterProviderNumberWindow.ShowDialog();
        }

        private void generateAllMemberReportsButton_Click(object sender, EventArgs e)
        {
            GenerateReport.generateAllMemberReports();
        }

        private void generateAllProviderReportsButton_Click(object sender, EventArgs e)
        {
            GenerateReport.generateAllProviderReports();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void ManagerTerminalForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
