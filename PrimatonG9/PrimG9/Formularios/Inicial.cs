﻿using PrimG9.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimG9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void LblInicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            Introduccion intr = new Introduccion();
            intr.Show();
        }

        private void LbsSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
