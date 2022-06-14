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

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            string number1 = textBox1.Text;
            string number2 = textBox2.Text;
            double Number1 = double.Parse(number1);
            double Number2 = double.Parse(number2);
            double result;

            result = Number1 - Number2;
            textBox3.Text = result.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string number1 = textBox1.Text;
            string number2 = textBox2.Text;
            double Number1 = double.Parse(number1);
            double Number2 = double.Parse(number2);
            double result;

            result = Number1 + Number2;
            textBox3.Text = result.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string number1 = textBox1.Text;
            string number2 = textBox2.Text;
            double Number1 = double.Parse(number1);
            double Number2 = double.Parse(number2);
            double result;

            if(Number2>0)
            {
            result = Number1 / Number2;       
            textBox3.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Divisor Must be greater than zero");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string number1 = textBox1.Text;
            string number2 = textBox2.Text;
            double Number1 = double.Parse(number1);
            double Number2 = double.Parse(number2);
            double result;

            result = Number1 * Number2;
            textBox3.Text = result.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if(!Char.IsDigit(chr)&& (chr!= 8)&&(chr !=46))
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Number");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && (chr != 8) && (chr != 46))
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Number");
            }
        }
    }
}
