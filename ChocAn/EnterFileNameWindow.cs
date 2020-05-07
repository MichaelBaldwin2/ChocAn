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
    public partial class EnterFileNameWindow : Form
    {
        public EnterFileNameWindow()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            fileNameTextBox.Clear();

        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            string filename = fileNameTextBox.Text;
            GenerateReport.generateSummaryReport(filename);
            this.Hide();
            fileNameTextBox.Clear();
        }

        private void fileNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
