using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SRW5
{
    public partial class Form1 : Form
    {
        private const string ErrorResponse = "неопред.знач.";
        public Form1()
        {
            InitializeComponent();
            InitializeVariables();
        }

        private void InitializeVariables()
        {
            textBox1.Text = Interaction.InputBox("Input y", "Data Input", "0");
            textBox3.Text = Interaction.InputBox("Input b1", "Data Input", "0");
            textBox4.Text = Interaction.InputBox("Input b2", "Data Input", "0");
            textBox5.Text = Interaction.InputBox("Input b3", "Data Input", "0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double r = Calculate();
                ShowResult(r, false);
            }
            catch (ArgumentException)
            {
                ShowResult(0, true);
            }
        }

        private double Calculate()
        {
            double r;
            var y = Convert.ToInt32(textBox1.Text);
            var b1 = Convert.ToInt32(textBox3.Text);
            var b2 = Convert.ToInt32(textBox4.Text);
            var b3 = Convert.ToInt32(textBox5.Text);

            if ((y - 0.5 * b1) > 0 && y > 25)
            {
                r = Math.Pow(y, 3) - 0.5 * b1;
            } else if (y <= 25)
            {
                r = Math.Pow(Math.Sin(b2), 2) + Math.Abs(b3);
            }
            else
            {
                throw new ArgumentException();
            }
            return r;
        }

        private void ShowResult(double r, bool error)
        {
            Color color;
            if (error)
            {
                textBox2.Text = ErrorResponse;
                color = Color.Red;
            }
            else
            {
                if (r < 0)
                {
                    color = Color.Red;
                }
                else
                {
                    color = Color.Blue;
                }
                textBox2.Text = Convert.ToString(r); 
            }

            textBox2.BackColor = color;
        }
    }
}