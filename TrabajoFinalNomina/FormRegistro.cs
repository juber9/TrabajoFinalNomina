﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canal10
{
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormIniciarSesion fm3 = new FormIniciarSesion();
            fm3.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormIniciarSesion fm3 = new FormIniciarSesion();
            fm3.Show();
            this.Hide();
        }
    }
}