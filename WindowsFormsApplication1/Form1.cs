using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox1.GotFocus += TextBox1_GotFocus;
            textBox2.GotFocus += TextBox1_GotFocus;
            tb = textBox1;
        }

        private void TextBox1_GotFocus(object sender, EventArgs e)
        {
            tb = textBox1.Focused ? textBox1 : textBox2;
        }

        TextBox tb;// = textBox1.Focused ? textBox1 : textBox2;
        string String;
        public int FirstNumber;
        public int SecondNumber;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + "X";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox3.Text = "/";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox3.Text = "-";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox3.Text = "+";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (tb.Text.Length != 0)
            {
                tb.Text = tb.Text.Remove(tb.Text.Length - 1);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToInt32(textBox1.Text);
            SecondNumber = Convert.ToInt32(textBox2.Text);

            if(textBox3.Text == "X")
            {
                label2.Text = Convert.ToString(FirstNumber * SecondNumber);
            }

            if(textBox3.Text == "/")
            {
                label2.Text = Convert.ToString(FirstNumber / SecondNumber);
            }

            if(textBox3.Text == "-")
            {
                label2.Text = Convert.ToString(FirstNumber - SecondNumber);
            }

            if(textBox3.Text == "+")
            {
                label2.Text = Convert.ToString(FirstNumber + SecondNumber);
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "1";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "2";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "3";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "4";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "5";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "6";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "7";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "8";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "9";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "0";
        }
    }
}
