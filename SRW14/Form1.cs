using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRW14
{
    public partial class Form1 : Form
    {
       int  y, max, xn, xk, xmax, dx; //задание глобальных переменных

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Y = " + Convert.ToString(y) + "   при  х = "+ Convert.ToString(xmax), "Результат:", 
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);          
        }

        private void label4_Click(object sender, EventArgs e)
        {
        int i;
        xn = Convert.ToInt32(comboBox1.Text);
        xk= Convert.ToInt32(comboBox2.Text);
        dx= Convert.ToInt32(comboBox3.Text);
        listBox1.Text ="";//очистка списка
        max = 4 * xn;
        i = xn;
        while (i <= xk) {
                y = 4 * i;
                if ((i >= 3) && (i <= 6)) { y = Factorial(i - 3); }
                      else if (i > 8 && i <= 13) { y = Factorial(i - 7); }
                if (y > max) { max = y; xmax = i; }
                listBox1.Items.Add(Convert.ToString(i) + ")    " + Convert.ToString(y));
                i = i + dx;
                         }
        }

        public Form1()
        {           
            InitializeComponent();
        }       

        private void Form1_Load(object sender, EventArgs e)
        {
            int i;
            for (i = 1; i <= 7; i++)
            { //задание списков ComboBox1-4
                comboBox1.Items.Add(Convert.ToString(i - 10));
                comboBox2.Items.Add(Convert.ToString(i + 10));
                comboBox3.Items.Add(Convert.ToString(i +1));               
            }
        }
        static int Factorial(int x)
        { if (x == 0) {  return 1; }
                   else  { return x * Factorial(x - 1);  }
        }
    }
}
