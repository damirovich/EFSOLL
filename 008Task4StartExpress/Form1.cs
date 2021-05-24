using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _008Task4StartExpress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Calcu()
        {
            double res = 0;
            double txt1 = Convert.ToDouble(textBox1.Text);
            double txt2 = Convert.ToDouble(textBox2.Text);
            if (radioButton1.Checked)
            {
                res = txt1 % txt2;
                textBox3.Text = res.ToString();
            }
            else if (radioButton2.Checked)
            {
                res = Math.Pow(txt1, txt2);
                textBox3.Text = res.ToString();
            }
            else if (radioButton3.Checked)
            {
                textBox3.Text = String.Concat(txt1, txt2);
            }
            else if (radioButton4.Checked)
            {
                if (txt1 <= 0)
                {
                    MessageBox.Show("Делимое число не может быть меньше или равно 0");
                }
                else
                {
                    res = txt1 / txt2;
                    textBox3.Text = res.ToString();
                }
            }
            else {
                MessageBox.Show("Выберите вид операции");
            }
        }
        public void Cleaar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Calcu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cleaar();
        }
    }
}
