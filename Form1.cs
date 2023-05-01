using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int num1;
        int num2;
        string option;
        int result;
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TotalText.Text = TotalText.Text + "1";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TotalText.Text = TotalText.Text + "2";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(TotalText.Text);
            TotalText.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            TotalText.Clear();
            result = 0;
            num1 = 0;
            num2 = 0;
            
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            TotalText.Text = TotalText.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            TotalText.Text = TotalText.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            TotalText.Text = TotalText.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            TotalText.Text = TotalText.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            TotalText.Text = TotalText.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            TotalText.Text = TotalText.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            TotalText.Text = TotalText.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            TotalText.Text = TotalText.Text + "0";
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(TotalText.Text);
            TotalText.Clear();
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            option = "×";
            num1 = int.Parse(TotalText.Text);
            TotalText.Clear();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            option = "÷";
            num1 = int.Parse(TotalText.Text);
            TotalText.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(TotalText.Text);

            if (option.Equals("+"))
                result = num1 + num2;

            if (option.Equals("-"))
                result = num1 - num2;

            if (option.Equals("×"))
                result = num1 * num2;

            if (option.Equals("÷"))
                result = num1 / num2;

            TotalText.Text = result + "";
        }
    }
}


