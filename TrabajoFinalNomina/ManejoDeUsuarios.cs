using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinalNomina
{
    public static class ManejoDeUsuarios
    {
        // Lista estática para almacenar los usuarios registrados
        public static List<Usuario> Usuarios { get; private set; } = new List<Usuario>();

        // Método agrega usuarii
        public static void AgregarUsuario(Usuario usuario)
        {
            Usuarios.Add(usuario);
        }

        // Método verifica si existe usuario
        public static Usuario ObtenerUsuario(string nombreUsuario, string contraseña)
        {
            return Usuarios.FirstOrDefault(u => u.NombreUsuario == nombreUsuario && u.Contraseña == contraseña);
        }

        // Método verifica si ya hay udusrii
        public static bool ExisteUsuario(string nombreUsuario)
        {
            return Usuarios.Any(u => u.NombreUsuario == nombreUsuario);
        }
    }

    // Clase para representar un usuario
    public class Usuario
    {
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
    }
}
