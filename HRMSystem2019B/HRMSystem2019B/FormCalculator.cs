using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMSystem2019B
{
    public partial class FormCalculator : Form
    {
        double a = 0;
        double b = 0;
        bool c = false;
        string d;

        public FormCalculator()
        {
            InitializeComponent();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += "9";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            c = true;
            b = double.Parse(textBox1.Text);
            d = "+";
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            c = true;
            b = double.Parse(textBox1.Text);
            d = "x2";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += "6";
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            c = true;
            b = double.Parse(textBox1.Text);
            d = "-";
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            c = true;
            b = double.Parse(textBox1.Text);
            d = "sqrt";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += "3";
        }

        private void btnMutiplication_Click(object sender, EventArgs e)
        {
            c = true;
            b = double.Parse(textBox1.Text);
            d = "*";
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            c = true;
            b = double.Parse(textBox1.Text);
            d = "log";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += "0";
            if (d == "/")
            {
                textBox1.Clear();
                MessageBox.Show("除数不能为零", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch (d)
            {
                case "+": a = b + double.Parse(textBox1.Text); break;
                case "-": a = b - double.Parse(textBox1.Text); break;
                case "*": a = b * double.Parse(textBox1.Text); break;
                case "/": a = b / double.Parse(textBox1.Text); break;
                case "x2": a = b * double.Parse(textBox1.Text); break;
                case "sqrt": a = Math.Sqrt(b); break;
                case "log": a = Math.Log(double.Parse(textBox1.Text), b); break;
                case "ln": a = Math.Log(b, Math.E); break;
            }
            textBox1.Text = a + "";
            c = true;
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            c = true;
            b = double.Parse(textBox1.Text);
            d = "/";
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            c = true;
            b = double.Parse(textBox1.Text);
            d = "ln";
        }
    }
}
