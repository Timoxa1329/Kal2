using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kal2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "y = (x2-2) / (sqrt(x2-2)-1)";
            label2.Text = "Введите X0";
            label3.Text = "Введите Xmax";
            label4.Text = "Введите шаг dx";
            label5.Text = "";
            button1.Text = "Решить задачу";
            textBox1.Text = "0";
            textBox2.Text = "10";
            textBox3.Text = "1";
            groupBox1.Text = "Найти:";
            radioButton1.Text = "min y(x)";
            radioButton2.Text = "max y(x)";
            radioButton3.Text = "Sr y(x)";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double xmax = Convert.ToDouble(textBox2.Text);
            double dx = Convert.ToDouble(textBox3.Text);
            double y = y = (x * x - 2) / (Math.Sqrt(x + 2) - 1);
            double min = y;
            double max = y;
            double n = 1;
            double Sr = 0;

            this.chart1.Series[0].Points.Clear();

            while (x <= xmax)
            {
                y = (x * x - 2) / (Math.Sqrt(x + 2) - 1);

                if (y >= max)
                {
                    max = y;
                }
                if (y <= min)
                {
                    min = y;
                }

                this.chart1.Series[0].Points.AddXY(x, y);

                x = x + dx;
                n = n + 1;
                Sr = Sr + y;
            }

            Sr = Sr / n;

            if (radioButton1.Checked)
            {
                label5.Text = "min y(x) = " + Convert.ToDouble(min);
            }
            if (radioButton2.Checked)
            {
                label5.Text = "max y(x) = " + Convert.ToDouble(max);
            }
            if (radioButton3.Checked)
            {
                label5.Text = "Sr y(x) = " + Convert.ToDouble(Sr);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 44)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 44)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 44)
            {
                e.Handled = true;
            }
        }
    }
}
