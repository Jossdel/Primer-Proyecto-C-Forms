using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabPage1.Controls.Add(new Label { Text = "Esta es la Pestaña 1", Dock = DockStyle.Fill, TextAlign = System.Drawing.ContentAlignment.MiddleCenter });
            tabPage2.Controls.Add(new Label { Text = "Esta es la pestaña Pestaña 2", Dock = DockStyle.Fill, TextAlign = System.Drawing.ContentAlignment.MiddleCenter });

        }
    }
}
