using System;
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
    public partial class FormCerrarSesion : Form
    {
        public FormCerrarSesion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRegistro fm2 = new FormRegistro();
            fm2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 fm4 = new Form4();
            fm4.Show();
            this.Hide();
        }
    }
}
