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
        int n; //объявление глобальных переменных
        string[] a = new string[100]; //объявление глоб. массивов

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            n = Convert.ToInt32(comboBox1.Text);//ввод длины списка городов
            listBox1.Text = ""; //очистка списка
            label2.Text = " Количество городов, названия которых заканчиваются на букву А = ";//очистка метки
            for (i = 1; i <= n; i++)
            {
                a[i] = Interaction.InputBox("Введите название города", "Название :", "Москва");
                listBox1.Items.Add(a[i]); //добавление в listbox1
            }
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            int i;
            for (i = 1; i <= 7; i++)
            { //задание списков ComboBox1
                comboBox1.Items.Add(Convert.ToString(i + 1));
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            int i, m;
            m = 0;
            for (i = 1; i <= n; i++)
            {
                if (a[i].EndsWith("а"))
                { //если найдена буква «а» в последней позиции слова
                    MessageBox.Show(a[i], "Результат:", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    m = m + 1;
                }
            }
            label2.Text = label2.Text + Convert.ToString(m);//обновл. метки – вывод результата

        }
    }
}
