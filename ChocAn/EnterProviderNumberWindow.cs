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
    public partial class EnterProviderNumberWindow : Form
    {
        public EnterProviderNumberWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = Int32.Parse(textBox1.Text);
            GenerateReport.generateProviderReport(number);
            this.Hide();
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            textBox1.Clear();
        }
    }
}
