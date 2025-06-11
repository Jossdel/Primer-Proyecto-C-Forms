using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            if (int.TryParse(label1.Text as string , out _) || double.TryParse(label1.Text as string, out _))
            {
                label1.Text = " El digito que ingreso es un numero";
            }
             else if (String.IsNullOrEmpty(textBox1.Text)){
                label1.Text = " No se permite este campo vacio";
            }
            else
            {
                label1.Text = " lo siento lo que ingreso no es un numero";
                

            }

        }
    }
}
