using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        int[] a = new int[1000];

        public Form1()
        {
            InitializeComponent();
            listBox1.Text = "";
            label3.Text = "";
            label4.Text = "";
            label7.Text = "";
            label8.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, n;

            string spisok;
            spisok = "";
            n = Convert.ToInt32(textBox1.Text);
            for (i = 1; i <= n; i++)
            {
                a[i] = Convert.ToInt32(Interaction.InputBox("Ai=", "Enter array", ""));
                listBox1.Items.Add(a[i]); //добавление в listbox1
                spisok = spisok + Convert.ToString(i) + ")  " + Convert.ToString(a[i]) + "      " + Environment.NewLine; //для Label7
               /* Environment.NewLine - команда перевода строки*/
            }
            label7.Text = spisok;

        }

        private void label2_Click(object sender, EventArgs e)
        {
            int i, n, min = Int32.MaxValue;
            double s, sr;
            n = Convert.ToInt32(textBox1.Text);
            s = 0;
            for (i = 1; i <= n; i++)
            {
                s = s + a[i];
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            sr = s / n;
            label3.Text = "Сумма элементов массива = " + Convert.ToString(s);
            label4.Text = "Ср.ар. значение = " + Convert.ToString(sr);
            label8.Text = "Минимальный элемент = " + Convert.ToString(min);
        }
    }
}
