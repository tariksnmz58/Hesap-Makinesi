using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hesap_makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.KeyPress += new KeyPressEventHandler(textBox1_KeyPress);
            textBox1.KeyDown += new KeyEventHandler(textBox1_KeyDown);

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button9.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '+' && e.KeyChar != '-' && e.KeyChar != '*' && e.KeyChar != '/')
            {
                e.Handled = true;
            }
            else
            {
                switch (e.KeyChar)
                {
                    case '+':
                        button7.PerformClick();
                        break;
                    case '-':
                        button8.PerformClick();
                        break;
                    case '*':
                        button16.PerformClick();
                        break;
                    case '/':
                        button17.PerformClick();
                        break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button6.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button11.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button12.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button13.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                return;
            }
            carpma = true;
            toplama = false;
            bolme = false;
            sayi1 = int.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                return;
            }
            bolme = true;
            toplama = false;
            carpma = false;
            sayi1 = int.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

            int sayi1;
        int sayi2;
        bool toplama = true;
        bool carpma = false;
        bool bolme = false;

        private void button7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                return;
            }
            toplama = true;
            carpma = false;
            bolme = false;
            sayi1 = int.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                return;
            }
            toplama = false;
            carpma = false;
            bolme = false;
            sayi1 = int.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                return;
            }

            sayi2 = int.Parse(textBox1.Text);
            if (toplama)
            {
                textBox1.Text = (sayi1 + sayi2).ToString();
            }
            else if (carpma)
            {
                textBox1.Text = (sayi1 * sayi2).ToString();
            }
            else if (bolme)
            {
                if (sayi2 != 0)
                {
                    textBox1.Text = (sayi1 / sayi2).ToString();
                }
                else
                {
                    textBox1.Text = "Hata! Sıfıra bölme.";
                }
            }
            else
            {
                textBox1.Text = (sayi1 - sayi2).ToString();
            }
        }
    }
}

