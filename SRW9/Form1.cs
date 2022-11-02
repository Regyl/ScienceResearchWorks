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

namespace SRW9
{
    public partial class Form1 : Form
    {
        int n;
        int[] a = new int[1000];
        int[] b = new int[1000];


        public Form1()
        {
            InitializeComponent();
            listBox1.Text = "";
            label4.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = Interaction.InputBox("Введите размерность массива А(n)", "n  = ", "3");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;  string spisok;
            n = Convert.ToInt32(textBox1.Text);
            spisok = "";
            
            Random rnd = new Random();
            for (i = 1; i <= n; i++) 
            {
                a[i]= rnd.Next(-100, 101);
                spisok = spisok + Convert.ToString(i) + ")  " + Convert.ToString(a[i]) + "      \n";
            }
            label4.Text = spisok;
            b[1]= a[1]; listBox1.Items.Add("1)    " + b[1]);
            for (i = 2; i <= n; i++) 
            {
                b[i] = a[i - 1] + a[i];
                listBox1.Items.Add(Convert.ToString(i) + ")    " + Convert.ToString(b[i]));
            }

        }
    }
}
