﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ejercicio13
{
    public partial class Form1 : Form
    {
        private Timer timer1;
        public Form1()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Interval = 1000; // es igual a 1 segundo
            timer1.Tick += Timer_Tick;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            timer1.Start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
                progressBar1.Value += 1; 
            else
                timer1.Stop();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}