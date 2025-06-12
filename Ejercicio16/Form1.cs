using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string operador = "";
        double num1 = 0;
        double num2 = 0;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Numero 1
            {
                if (textBox1.Text == "0") textBox1.Text = "";
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Numero 2
            {
                if (textBox1.Text == "0") textBox1.Text = "";
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Numero 3
            {
                if (textBox1.Text == "0") textBox1.Text = "";
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //Numero 4
            {
                if (textBox1.Text == "0") textBox1.Text = "";
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Numero 5
            {
                if (textBox1.Text == "0") textBox1.Text = "";
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Numero 6
            {
                if (textBox1.Text == "0") textBox1.Text = "";
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Numero 7
            {
                if (textBox1.Text == "0") textBox1.Text = "";
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Numero 8

                textBox1.Text = textBox1.Text + "8";
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Numero 9

                textBox1.Text = textBox1.Text + "9";
            
        }

        private void button0_Click(object sender, EventArgs e)
        {
            //Numero 0

                textBox1.Text = textBox1.Text + "";
            
        }

        private void buttonPunto_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void buttonRestar_Click(object sender, EventArgs e)
        {
            operador = "-";
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
        }

        private void buttonMultiplicar_Click(object sender, EventArgs e)
        {
            operador = "*";
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
        }

        private void buttonDividir_Click(object sender, EventArgs e)
        {
            operador = "/";
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(textBox1.Text);

            switch (operador)
            {
                case "+":
                    textBox1.Text = $"{num1 + num2}";
                    break;

                case "-":
                    textBox1.Text = $"{num1 - num2}";
                    break;

                case "*":
                    textBox1.Text = $"{num1 * num2}";
                    break;

                case "/":
                    textBox1.Text = $"{num1 / num2}";
                    break;
            }
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            {
                textBox1.Text = "0";
                num1 = 0;
                num2 = 0;
                operador = "";
            }

        }

        private void buttonSumar_Click(object sender, EventArgs e)
        {
            operador = "+";
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
        }

        private void buttonBorrarPoco_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 1) textBox1.Text = "0";
            else textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }
    }
}

