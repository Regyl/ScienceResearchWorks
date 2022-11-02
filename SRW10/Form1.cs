using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRW10
{
    public partial class Form1 : Form
    {
        private static Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            listBox1.Text = "";
            label3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(comboBox1.Text);
            int[] a = InitializeInitialArray(n);
            PrintResultArray(a, n);
        }

        private void PrintResultArray(int[] a, int n)
        {
            for (int i = 1; i <= n - 1; i++) 
            {                 
                int min= a[i];
                for (int j = i + 1; j <= n; j++ )     
                {
                    if (a[i] > a[j])
                    {
                        min = a[j]; 
                        a[j] = a[i]; 
                        a[i] = min;
                    }                                                  
                }
                
            }
            
            for (int i = 1; i <= n; i++)
            {
                listBox1.Items.Add(Convert.ToString(i) + ")    " + Convert.ToString(a[i]));
            }
        }

        private int[] InitializeInitialArray(int n)
        {
            int[] a = new int[1000];
            string spisok = "";
            for (int i = 1; i <= n; i++)
            {
                a[i] = rnd.Next(-100, 101);                
                spisok = spisok + Convert.ToString(i) + ")  " + Convert.ToString(a[i]) + "      \n";             
            }
            label3.Text = spisok;

            return a;
        }
    }
}
