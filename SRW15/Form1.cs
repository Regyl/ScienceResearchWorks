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

namespace SRW15
{
    public partial class Form1 : Form
    {
        private const int capacity = 20;
        private List<double> items = new List<double>(capacity);
        public Form1() 
        {           
            InitializeComponent();
            for (int i = 0; i < capacity; i++)
            {
                string text;
                if (i % 2 == 0)
                {
                    text = "Введите основание";
                }
                else
                {
                    text = "Введите высоту";
                }
                items.Add(Convert.ToDouble(Interaction.InputBox(text, "Input", "4")));
            }

            double minSquare = ClassLibrary15.Class1.Square(items[0], items[0 + 1]);
           
            for (int i = 0; i < capacity; i = i + 2)
            {
                double square = ClassLibrary15.Class1.Square(items[i], items[i+1]);
                if (minSquare > square)
                {
                    minSquare = square;
                }
                listBox1.Items.Add("Ai=" + Convert.ToString(items[i]) + 
                                   ", hi=" + Convert.ToString(items[i + 1]) + 
                                   ", square=" + Convert.ToString(square));
            }

            textBox1.Text = Convert.ToString(minSquare);
        }
    }
}