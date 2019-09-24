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
        
        Rational rat = new Rational(0,0);
        public Form1()
        {
            InitializeComponent();
            button7.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                label3.Text = "enter all values";
                flag = false;
            }            

            if (textBox2.Text == "0" || textBox4.Text == "0")
            {
                label3.Text = "DIV BY 0";
                flag = false;
            }            

            if(flag)
            {
                button7.Enabled = true;
                label3.Text = "";
                Rational rat1 = new Rational(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                Rational rat2 = new Rational(Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));

                if (label1.Text == "+")
                {
                    Rational resalt = rat1.Sum(rat2);
                    rat = resalt;
                    textBox5.Text = resalt.chis.ToString() + "/" + resalt.znam.ToString() ;
                }

                if (label1.Text == "-")
                {
                    Rational resalt = rat1.Minus(rat2);
                    rat = resalt;
                    textBox5.Text = resalt.chis.ToString() + "/" + resalt.znam.ToString();
                }

                if (label1.Text == "*")
                {
                    Rational resalt = rat1.Pel(rat2);
                    rat = resalt;
                    textBox5.Text = resalt.chis.ToString() + "/" + resalt.znam.ToString();
                }

                if (label1.Text == "/")
                {
                    Rational resalt = rat1.Del(rat2);
                    rat = resalt;
                    textBox5.Text = resalt.chis.ToString() + "/" + resalt.znam.ToString();
                }

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "+";
            textBox5.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "/";
            textBox5.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "-";
            textBox5.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "*";
            textBox5.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {            
            Rational rat1 = rat.NOD(rat.chis, rat.znam);
            textBox5.Text = rat1.chis.ToString() + "/" + rat1.znam.ToString();
        }
    }
}
