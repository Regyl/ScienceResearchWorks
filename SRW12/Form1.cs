using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRW12
{
    public partial class Form1 : Form
    {
        private string DiagonalText = "Сумма элементов побочной диагонали = ";
        private static Random rnd = new Random();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int minZn, maxZn;
            int[,] a = new int[100, 100];
            
            int n= Convert.ToInt32(comboBox2.Text);
            //задание количества столбцов и строк таблицы
            dataGridView1.RowCount = n+1; 
            dataGridView1.ColumnCount = n+1;
            minZn= Convert.ToInt32(comboBox3.Text);
            maxZn= Convert.ToInt32(comboBox4.Text);
            dataGridView1.Width = 120 * (n + 1); 
            dataGridView1.Height = 30 * (n + 1);

            for (int i = 1; i <= n; i++) 
            {
                for (int j= 1;j <= n; j++)       
                {
                    a[i, j]= rnd.Next(minZn, maxZn);
                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(a[i, j]);
                }
            }

            
            for (int i = 1; i <= n; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value= Convert.ToString(i); 
                
            }
            for (int j = 1; j <= n; j++)
            {
                dataGridView1.Rows[0].Cells[j].Value= Convert.ToString(j);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            int s = 0;
            int n = Convert.ToInt32(comboBox2.Text);
            for (int i=1; i<=n; i++)
            {               
                s = s + Convert.ToInt32(dataGridView1.Rows[i].Cells[n-i+1].Value);                     
            }
            label1.Text = DiagonalText + Convert.ToString(s);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i;
            for (i = 1; i <= 7; i++)
            { //задание списков ComboBox1-4
                comboBox2.Items.Add(Convert.ToString(i + 1));
                comboBox3.Items.Add(Convert.ToString(i - 10));
                comboBox4.Items.Add(Convert.ToString(i + 10));
            }
            label1.Text = DiagonalText;
        }
    }
}
