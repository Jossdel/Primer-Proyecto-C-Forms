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

namespace Ejercicio12
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
            if (double.TryParse(TexBox1.Text, out double celsius))
            {
                double fahrenheit = (celsius * 9 / 5) + 32;
                label2.Text = "Fahrenheit: " + fahrenheit;
                ;
               
            }
            else
            {
                label2.Text = " Ingrese un numero que sea valido ";
               
            }
        }
    }
}
