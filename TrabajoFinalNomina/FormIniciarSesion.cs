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
            // Ir al formulario de registro
            FormRegistro fm2 = new FormRegistro();
            fm2.Show();
            this.Hide();
        }

        private void LogIn(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            // Verificar si las credenciales son correctas
            Usuario usuario = ManejoDeUsuarios.ObtenerUsuario(nombreUsuario, contraseña);

            if (usuario != null)
            {
                MessageBox.Show("Inicio de sesión exitoso.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormOpciones mainForm = new FormOpciones();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}