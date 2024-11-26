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
    public partial class FormNomina : Form
    {
        private string tipoNomina;
        public FormNomina(string tipoNomina)
        {
            InitializeComponent();
            this.tipoNomina = tipoNomina;
            if (dvgNomina != null)//verifica que dvgNomina este inicializado antes de ajustar las columnas
            {
                AjustarColumnas(tipoNomina);
            }
            else
            {
                MessageBox.Show("El DataGridView no está inicializado.");
            }
        }
        public void AjustarColumnas(string tipoNomina)
        {
            //Cambia la visibilidad de las columnas segun el tipo de Nomina
            foreach (DataGridViewColumn columna in dvgNomina.Columns)
            {
                columna.Visible = true;
            }
            if (tipoNomina == "Mensual")
            {
                dvgNomina.Columns["clmSalarioQuincenal"].Visible = false;
                dvgNomina.Columns["clmSalarioSemanal"].Visible = false;
            }
            else if (tipoNomina == "Quincenal")
            {
                dvgNomina.Columns["clmSalarioMensual"].Visible = false;
                dvgNomina.Columns["clmSalarioSemanal"].Visible = false;
            }
            else if (tipoNomina == "Semanal")
            {
                dvgNomina.Columns["clmSalarioMensual"].Visible = false;
                dvgNomina.Columns["clmSalarioQuincenal"].Visible = false;
            }
        }
        private void ValidarCampos()
        {
            //verifica que todos los campos hallan sido llenados
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                !mtbNoINNS.MaskCompleted ||
                cmbDepartamento.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtSalario.Text) ||
                !mtbHorasExtra.MaskCompleted ||
                !mtbAntigüedad.MaskCompleted)
            {
                MessageBox.Show("Complete todos los campos para poder calcular", "Campo incompleto.",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //ubica la informacion de los campos en su respectiva columna
            int NuevaFila = dvgNomina.Rows.Add();
            dvgNomina.Rows[NuevaFila].Cells["clmNombre"].Value = txtNombre.Text;
            dvgNomina.Rows[NuevaFila].Cells["clmNoINNS"].Value = mtbNoINNS.Text;
            dvgNomina.Rows[NuevaFila].Cells["clmDepartamento"].Value = cmbDepartamento.SelectedItem.ToString();
            dvgNomina.Rows[NuevaFila].Cells["clmSalarioMensual"].Value = txtSalario.Text;
            dvgNomina.Rows[NuevaFila].Cells["clmSalarioQuincenal"].Value = txtSalario.Text;
            dvgNomina.Rows[NuevaFila].Cells["clmSalarioSemanal"].Value = txtSalario.Text;
            dvgNomina.Rows[NuevaFila].Cells["clmHorasExtras"].Value = mtbHorasExtra.Text;
            dvgNomina.Rows[NuevaFila].Cells["clmAntigüedad"].Value = mtbAntigüedad.Text;

            txtNombre.Clear();
            mtbNoINNS.Clear();
            cmbDepartamento.SelectedIndex = -1;
            txtSalario.Clear();
            mtbHorasExtra.Clear();
            mtbAntigüedad.Clear();

        }
        public void LimpiarDataGridview()
        {
            dvgNomina.Rows.Clear();
        }
        public bool HayDatosEnNomina()
        {
            // Verifica si hay filas en el DataGridView que no sean la fila nueva predeterminada.
            return dvgNomina.Rows.Count > 0 && !dvgNomina.Rows[0].IsNewRow;
        }
        private string GenerarResumenNomina(string tipoNomina)
        {
            string resumen = "Tipo de Nomina: " + tipoNomina + "\n";
            resumen += "Resumen de la Nómina:\n";

            // Recorre todas las filas del DataGridView (excepto la fila nueva predeterminada)
            foreach (DataGridViewRow fila in dvgNomina.Rows)
            {
                if (!fila.IsNewRow)
                {
                    // Construye el resumen de cada fila, uniendo los valores de las celdas por tabulaciones
                    var filaResumen = string.Join("\t", fila.Cells.Cast<DataGridViewCell>()
                        .Select(cell => cell.Value?.ToString() ?? string.Empty));
                    resumen += filaResumen + "\n"; // Agrega la fila al resumen
                }
            }

            return resumen;
        }
        private void CargarDatosNomina(string rutaArchivo)
        {
            try
            {
                // Lee todas las líneas del archivo
                string[] lineas = File.ReadAllLines(rutaArchivo);
                //obtener el tipo de nomina del archivo
                string tipoNominaEnArchivo = lineas.FirstOrDefault()?.Split(':')[1]?.Trim();
                if (tipoNominaEnArchivo != tipoNomina) // Compara el tipo de nómina con el actual
                {
                    MessageBox.Show("El tipo de nómina en el archivo no coincide con el tipo de nómina seleccionado.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Si no coinciden, no cargues los datos
                }
                // Limpia el DataGridView antes de cargar los datos
                dvgNomina.Rows.Clear();
                foreach (string linea in lineas.Skip(1)) // Saltamos la primera línea (encabezado)
                {
                    var valores = linea.Split('\t'); // Separa los valores por tabulaciones

                    // Verifica que la cantidad de valores coincida con el número de columnas
                    if (valores.Length == dvgNomina.Columns.Count)
                    {
                        // Agrega una nueva fila y asigna los valores a las celdas
                        int index = dvgNomina.Rows.Add();
                        for (int i = 0; i < valores.Length; i++)
                        {
                            dvgNomina.Rows[index].Cells[i].Value = valores[i]; // Asigna el valor a cada celda
                        }
                    }
                }

                MessageBox.Show("Datos cargados exitosamente.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dvgNomina.SelectedRows.Count > 0)
            {
                bool filaNuevaSeleccionada = false;
                foreach (DataGridViewRow fila in dvgNomina.SelectedRows)//verifica que la fila seleccionada es la por defecto
                {
                    if (fila.IsNewRow)
                    {
                        filaNuevaSeleccionada = true;//indica que la fila por defecto se selecciono
                    }
                    else
                    {
                        //si no es la fila por defeccto se procede con la eliminacion
                        DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar la fila seleccionada?",
                            "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resultado == DialogResult.Yes)
                        {
                            dvgNomina.Rows.Remove(fila);
                        }
                    }
                }
                if (filaNuevaSeleccionada)
                {
                    return;//si la fila por defecto fue seleccionada, no sucede nada
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Abrir el cuadro de diálogo para guardar archivo
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string resumen = GenerarResumenNomina(tipoNomina);
                File.WriteAllText(saveFileDialog.FileName, resumen);
                MessageBox.Show("La nómina se ha guardado exitosamente.",
                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                CargarDatosNomina(openFileDialog.FileName);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Si tiene problemas par llenar los campos que muestran una linea, " +
                "coloque el cursor al principio del campo y asegurese de ingresar la cantidad, " +
                "de carcteres requeridas.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
