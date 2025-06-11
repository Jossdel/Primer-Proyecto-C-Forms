using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = fecha.Text;
        }

        private void fecha_ValueChanged(object sender, EventArgs e)
        {
            DateTime.Parse(fecha.Value.ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
