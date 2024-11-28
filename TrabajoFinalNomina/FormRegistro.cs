using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoFinalNomina;

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
            // Volver al formulario de inicio de sesión
            FormIniciarSesion fm2 = new FormIniciarSesion();
            fm2.Show();
            this.Hide();
        }

        private void Registrar(object sender, EventArgs e)
        { 
            // Validaciones para el registro
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Por favor, ingrese un nombre de usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("Por favor, ingrese una contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtContraseña.Text.Length < 6)
            {
                MessageBox.Show("La contraseña debe tener al menos 6 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtContraseña.Text != txtConfirmarContraseña.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, verifique.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ManejoDeUsuarios.ExisteUsuario(txtUsuario.Text))
            {
                MessageBox.Show("El nombre de usuario ya está registrado. Por favor, elija otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear y agregar el nuevo usuario
            ManejoDeUsuarios.AgregarUsuario(new Usuario
            {
                NombreUsuario = txtUsuario.Text,
                Contraseña = txtContraseña.Text
            });

            MessageBox.Show("Usuario registrado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar campos
            txtUsuario.Clear();
            txtContraseña.Clear();
            txtConfirmarContraseña.Clear();

            // Volver al formulario de inicio de sesión
            FormIniciarSesion fm2 = new FormIniciarSesion();
            fm2.Show();
            this.Hide();
        }
    }
}