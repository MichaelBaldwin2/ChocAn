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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void managerTerminalButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerTerminalForm managerTerminalForm = new ManagerTerminalForm();
            managerTerminalForm.Show();

        }

        private void MainWindow_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void providerTerminalButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProviderTerminalForm providerTerminalForm = new ProviderTerminalForm();
            providerTerminalForm.Show();
        }

        private void operatorTerminalButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OperaterTerminalForm operaterTerminalForm = new OperaterTerminalForm();
            operaterTerminalForm.Show();
        }
    }
}
