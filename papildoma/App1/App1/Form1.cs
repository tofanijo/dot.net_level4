using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVardas_Click(object sender, EventArgs e)
        {
            if (tbVardas.Text == "")
            {
                MessageBox.Show("Vardas negali buti tuscias");
                return;
            }
            tbOutput.Text = $"Sveikas {tbVardas.Text}";
            tbOutput.AppendText("\r\nMalonu tave matyti");

        }
    }
}
