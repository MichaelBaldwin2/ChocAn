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
    public partial class EnterMemberNumberWindow : Form
    {
        public EnterMemberNumberWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = Int32.Parse(memberNumberTextBox.Text);
            GenerateReport.generateMemberReport(number);
            this.Hide();
            memberNumberTextBox.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            memberNumberTextBox.Clear();
        }
    }
}
