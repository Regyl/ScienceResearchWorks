using System;
using System.Windows.Forms;

namespace SRW11
{
    public partial class Form1 : Form
    {
        
        private static Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            int m, n, minZn, maxZn;
            int[,] a = new int[100, 100];
            
            //
            for (int i= 1;i<=7; i++)   
            {                 
                comboBox1.Items.Add(Convert.ToString(i + 1));
                comboBox2.Items.Add(Convert.ToString(i + 1));
                comboBox3.Items.Add(Convert.ToString(i-10));
                comboBox4.Items.Add(Convert.ToString(i + 10));
            }
            
            //Установка числа строк и столбцов (+1 т.к. по вертикали и горизонтиали)
            m = Convert.ToInt32(comboBox1.Text); 
            n = Convert.ToInt32(comboBox2.Text);
            dataGridView1.RowCount = m+1; 
            dataGridView1.ColumnCount = n+1;

            //Установка ширины и высоты. Методом проб и ошибок
            minZn= Convert.ToInt32(comboBox3.Text);
            maxZn= Convert.ToInt32(comboBox4.Text);
            dataGridView1.Width = 110 * (n + 1); 
            dataGridView1.Height= 27 * (m + 1);

            //Заполнение таблицы
            for (int i = 1; i <= m; i++) 
            {                   
                for (int j= 1;j <= n; j++)       
                {
                    a[i, j]= rnd.Next(minZn, maxZn);
                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(a[i, j]);
                }
            }

            //Нумерация строк/столбцов
            for (int i = 1; i <= m; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value= Convert.ToString(i);
            }
            for (int j = 1; j <= n; j++)
            {
                dataGridView1.Rows[0].Cells[j].Value= Convert.ToString(j);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 7; i++)
            {                 
                comboBox1.Items.Add(Convert.ToString(i + 1));
                comboBox2.Items.Add(Convert.ToString(i + 1));
                comboBox3.Items.Add(Convert.ToString(i - 10));
                comboBox4.Items.Add(Convert.ToString(i + 10));
            }
        }
    }
}
