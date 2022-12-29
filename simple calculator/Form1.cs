using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textBox1.Text);
            double number2 = Convert.ToDouble(textBox2.Text);

            double addresult = number1 + number2;

            MessageBox.Show(number1 + " + " + number2 + "=" + addresult);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textBox1.Text);
            double number2 = Convert.ToDouble(textBox2.Text);

            double addresult = number1 - number2;

            MessageBox.Show(number1 + " - " + number2 + "=" + addresult);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textBox1.Text);
            double number2 = Convert.ToDouble(textBox2.Text);

            double addresult = number1 * number2;

            MessageBox.Show(number1 + " * " + number2 + "=" + addresult);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textBox1.Text);
            double number2 = Convert.ToDouble(textBox2.Text);

            double addresult = number1 / number2;

            MessageBox.Show(number1 + " / " + number2 + "=" + addresult);
        }
    }
}
