using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canal10
{
    public partial class FormRegistro : Form
    {
        // Lista estática para almacenar usuarios registrados
        private static List<Usuario> usuarios = new List<Usuario>();

        public FormRegistro()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Volver al formulario de inicio de sesión
            FormIniciarSesion fm3 = new FormIniciarSesion();
            fm3.Show();
            this.Hide();
        }

        private void Registrar(object sender, EventArgs e)
        {
            // Verificar si el campo de usuario está vacío
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Por favor, ingrese un nombre de usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar si el campo de contraseña está vacío
            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("Por favor, ingrese una contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar que la contraseña tenga al menos 6 caracteres
            if (txtContraseña.Text.Length < 6)
            {
                MessageBox.Show("La contraseña debe tener al menos 6 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar si las contraseñas coinciden
            if (txtContraseña.Text != txtConfirmarContraseña.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, verifique.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar si el usuario ya existe
            if (usuarios.Any(u => u.NombreUsuario == txtUsuario.Text))
            {
                MessageBox.Show("El nombre de usuario ya está registrado. Por favor, elija otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Agregar el nuevo usuario a la lista de usuarios
            usuarios.Add(new Usuario
            {
                NombreUsuario = txtUsuario.Text,
                Contraseña = txtContraseña.Text
            });

            MessageBox.Show("Usuario registrado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar los campos de texto
            txtUsuario.Clear();
            txtContraseña.Clear();
            txtConfirmarContraseña.Clear();

            // Volver al formulario de inicio de sesión
            FormIniciarSesion fm3 = new FormIniciarSesion();
            fm3.Show();
            this.Hide();
        }
    }

    // Clase para representar un usuario
    public class Usuario
    {
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
    }
}
