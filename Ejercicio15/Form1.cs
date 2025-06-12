using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ejercicio15
{
    public partial class Form1 : Form
    {
        private string rutaArchivoActual = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Solo esta definición debe existir
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(ofd.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rutaArchivoActual))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    rutaArchivoActual = saveFileDialog.FileName;
                }
                else
                {
                    return; // Cancelado
                }
            }

            File.WriteAllText(rutaArchivoActual, textBox1.Text);
            MessageBox.Show("Archivo guardado correctamente.");
        }


    }
}