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
            label3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int n = Convert.ToInt32(comboBox1.Text);
            int[] array = InitializeInitialArray(n);
            
            int m = Convert.ToInt32(comboBox2.Text);
            double a = Convert.ToInt32(comboBox3.Text);
            double b = Convert.ToInt32(comboBox4.Text);

            double step = (b - a) / m;

            int[] counterArray = CountPeriodItems(m, array, Convert.ToInt32(a), Convert.ToInt32(b), step, n);
            ShowResultArray(counterArray);
        }

        private int[] CountPeriodItems(int m, int[] initialArray, int a, int b, double step, int n)
        {
            int[] counterArray = new int[m];

            for (int i = 1; i <= n; i++)
            {
                if (initialArray[i] >= a && initialArray[i] <= b)
                {
                    int index = Convert.ToInt32(Math.Floor((initialArray[i] - a) / step));
                    counterArray[index] = counterArray[index] + 1;
                }
            }

            return counterArray; 
        }

        private void ShowResultArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                String item = Convert.ToString(i) + ") " + Convert.ToString(array[i]);
                listBox1.Items.Add(item);
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
