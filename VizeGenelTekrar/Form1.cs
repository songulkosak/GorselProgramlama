﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VizeGenelTekrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kelime;
            kelime = textBox1.Text;
            for (int i = 0; i < kelime.Length; i++)
            {
                label2.Text=("Sonuç:"+kelime);
            }

        }
    }
}
