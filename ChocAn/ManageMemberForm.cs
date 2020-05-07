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
    public partial class ManageMemberForm : Form
    {
        public ManageMemberForm()
        {
            InitializeComponent();
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            AddMemberForm addMemberForm = new AddMemberForm();
            addMemberForm.ShowDialog();
        }

        private void updateMemberButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteMemberButton_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OperaterTerminalForm operaterTerminalForm = new OperaterTerminalForm();
            operaterTerminalForm.Show();
        }

        private void ManageMemberForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            OperaterTerminalForm operaterTerminalForm = new OperaterTerminalForm();
            operaterTerminalForm.Show();
        }
    }
}
