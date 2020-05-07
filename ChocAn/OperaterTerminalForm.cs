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
    public partial class OperaterTerminalForm : Form
    {
        public OperaterTerminalForm()
        {
            InitializeComponent();
        }

        private void manageMemberButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageMemberForm manageMemberForm = new ManageMemberForm();
            manageMemberForm.Show();

        }

        private void manageProviderButton_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void OperaterTerminalForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
