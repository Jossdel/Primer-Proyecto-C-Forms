using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] { "Rojo", "Verde", "Azul" });
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Rojo":
                    this.BackColor = Color.Red;
                    label1.Text = "El color seleccionado es Rojo";
                    break;

                case "Verde":
                    this.BackColor = Color.Green;
                    label1.Text = "El color seleccionado es Verde";
                    break;

                case "Azul":
                    this.BackColor = Color.Blue;
                    label1.Text = "El color seleccionado es Azul";
                    break;

                default:
                    this.BackColor = SystemColors.Control;
                    break;
            }
        }
    }
}