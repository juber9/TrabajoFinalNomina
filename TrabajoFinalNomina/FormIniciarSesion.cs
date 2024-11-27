using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoFinalNomina;

namespace Canal10
{
    public partial class FormIniciarSesion : Form
    {
        public FormIniciarSesion()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormRegistro fm2 = new FormRegistro();
            fm2.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LogIn(object sender, EventArgs e)
        {
            FormOpciones mainForm = new FormOpciones();
            mainForm.Show();
        }
    }
}
