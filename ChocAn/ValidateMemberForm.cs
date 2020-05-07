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
    public partial class ValidateMemberForm : Form
    {
        public ValidateMemberForm()
        {
            InitializeComponent();
        }

        private void validateButton_Click(object sender, EventArgs e)
        {
            int memNum = Int32.Parse(textBox1.Text);
            ValidateMember.validateMember(memNum);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProviderTerminalForm providerTerminalForm = new ProviderTerminalForm();
            providerTerminalForm.Show();
        }

        private void ValidateMemberForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            ProviderTerminalForm providerTerminalForm = new ProviderTerminalForm();
            providerTerminalForm.Show();
        }
    }
}
