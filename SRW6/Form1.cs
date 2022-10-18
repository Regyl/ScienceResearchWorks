using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SRW6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = Interaction.InputBox("Input n", "n = ", "1"); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var n = Convert.ToInt32(textBox1.Text);
            double s = 0;

            for (int i = 1; i < n; i++)
            {
                s += 1 / Math.Pow(2 * i - 1, 4);
            }
            MessageBox.Show("S = " + Convert.ToString(s),
                "Результат:", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1); 
        }

        private void label1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Interaction.InputBox("Input n", "n = ", "1");
        }
    }
}