using System;
using System.Drawing;
using System.Windows.Forms;

using static System.Math;

namespace SRW4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var y = CalculateResult();
            ShowResult(y);
        }

        private double CalculateResult()
        {
            var a = Convert.ToInt32(textBox1.Text);
            var b = Convert.ToInt32(textBox2.Text);
            var c = Convert.ToInt32(textBox4.Text);
            var x = Convert.ToInt32(textBox3.Text);
            return Sqrt(a + Sqrt(b + Sqrt(c + x)));
        }

        private void ShowResult(double y)
        {
            DialogResult result = MessageBox.Show("Y=" + Convert.ToString(y),
                "Результат:", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            switch (result)
            {
                case DialogResult.Yes:
                    textBox1.BackColor = Color.Green;
                    break;
                case DialogResult.No:
                    label2.BackColor = Color.Red;
                    break;
                case DialogResult.Cancel:
                    button1.BackColor = Color.Yellow; 
                    break;
                default:
                    throw new InvalidOperationException("Недопустимая операция");
            }
        }
    }
}