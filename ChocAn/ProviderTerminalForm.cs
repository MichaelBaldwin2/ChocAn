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
    public partial class ProviderTerminalForm : Form
    {
        public ProviderTerminalForm()
        {
            InitializeComponent();
        }

        private void validateMemberButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ValidateMemberForm validateMemberForm = new ValidateMemberForm();
            validateMemberForm.Show();
        }

        private void billChocAnButton_Click(object sender, EventArgs e)
        {

        }

        private void RequestButton_Click(object sender, EventArgs e)
        {
            DirectoryDB.rewriteDirectory();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void ProviderTerminalForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
