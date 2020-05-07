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
    public partial class AddMemberForm : Form
    {
        public AddMemberForm()
        {
            InitializeComponent();
        }

        private void nametextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = nametextBox.Text;
            int number = Int32.Parse(numbertextBox.Text);
            string address = addresstextBox.Text;
            string city = citytextBox.Text;
            string state = statetextBox.Text;
            int zip = Int32.Parse(ziptextBox.Text);
            ManageAccounts.addMember(name, number, address, city, state, zip);
            this.Hide();
            nametextBox.Clear();
            numbertextBox.Clear();
            addresstextBox.Clear();
            citytextBox.Clear();
            statetextBox.Clear();
            ziptextBox.Clear();

        }
    }
}
