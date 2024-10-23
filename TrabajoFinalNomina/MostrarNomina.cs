using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoFinalNomina
{
    public partial class MostrarNomina : Form
    {
        public MostrarNomina()
        {
            InitializeComponent();
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            AgregarNomina mostrarNomina = new AgregarNomina();
            mostrarNomina.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
