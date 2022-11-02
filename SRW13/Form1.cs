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

namespace SRW13
{
    public partial class Form1 : Form
    {
        int n;  
        string[] a = new string[100];
        public Form1()
        {
            InitializeComponent();
            listBox1.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            int m = 0;
            bool flag = true;
            for (int i = 1; i <= n; i++)
            {
                if (flag && a[i].Length > 7)
                {
                    a[i] = a[1];
                    flag = false;
                }
                listBox2.Items.Add(a[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            n = Convert.ToInt32(comboBox1.Text);
            
            for (i = 1; i <= n; i++)
            {
                a[i] = Interaction.InputBox("Введите название города", "Название :", "Москва");
                listBox1.Items.Add(a[i]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i;
            for (i = 1; i <= 7; i++)
            {                 
                comboBox1.Items.Add(Convert.ToString(i + 1));
            }
        }
    }
}
