using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        int[] a = new int[1000]; //объявление глобального целочисл. массива а из 1000 элементов

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, n;

            string spisok;
            spisok = "";
            n = Convert.ToInt32(textBox1.Text);
            listBox1.Text = ""; //очистка списка
            label3.Text = ""; //очистка метки
            label4.Text = ""; //очистка метки
            for (i = 1; i <= n; i++)
            {
                a[i] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ai=", "Enter array", ""));
                listBox1.Items.Add(a[i]); //добавление в listbox1
                spisok = spisok + Convert.ToString(i) + ")  " + Convert.ToString(a[i]) + "      " + Environment.NewLine; //для Label7
               /* Environment.NewLine - команда перевода строки*/
            }
            label7.Text = spisok;

        }

        private void label2_Click(object sender, EventArgs e)
        {
            int i, n;
            double s, sr;
            n = Convert.ToInt32(textBox1.Text);
            s = 0;
            for (i = 1; i <= n; i++) { s = s + a[i]; }
            sr = s / n;
            label3.Text = "Сумма элементов массива = " + Convert.ToString(s); //вывод суммы элементов массива
            label4.Text = "Ср.ар. значение = " + Convert.ToString(sr);//вывод ср.ар. значения

        }
    }
}
