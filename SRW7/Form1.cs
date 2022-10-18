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

namespace SRW7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = Interaction.InputBox("Введите точность", "Точность = ", "0,001");
            label3.Text= "";//стирание предыдущего результата
            label5.Text = "";//стирание предыдущего результата
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            int n = 2;
            double crunch = 1;
            double precision, s = 0, item; //присвоение счётчику шагов, сумме и //слагаемому начальных значений
            precision = Convert.ToDouble(textBox1.Text);

            do
            {
                n++;
                item = crunch / ((n - 1) * (n + 1));
                s = s + item;
            } while (item > precision);
            label3.Text = Convert.ToString(s);
            label5.Text = Convert.ToString(n);
        }
    }
}