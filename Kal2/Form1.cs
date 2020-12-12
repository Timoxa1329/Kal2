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
            double y = y = x(x * x - 2) / (Math.Sqrt(x + 2) - 1);

        }
    }
}
