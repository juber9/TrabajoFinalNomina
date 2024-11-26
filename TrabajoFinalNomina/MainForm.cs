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
    public partial class MainForm : Form
    {
        private FormNomina frmGenericNominaMensual;//acceder a metodos
        private FormNomina frmGenericNominaQuincenal;
        private FormNomina frmGenericNominaSemanal;
        private bool _isPanelVisibleTipoNomina = false;
        private bool _isPanelExpand = false;
        public MainForm()
        {
            InitializeComponent();
        }

        private void editasrToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnExpandir_Click(object sender, EventArgs e)
        {
            //expandir o contraer el panel izquierdo
            if (_isPanelExpand)
            {
                panelLeft.Width = 250;//Tamaño expandido
                _isPanelExpand = false;
                //restaura el texto de los botones
                foreach (Button button in panelLeft.Controls.OfType<Button>())
                {
                    btnTipoNomina.Text = "Tipo de Nómina";
                    btnSalir.Text = "Salir";
                    btnMensual.Text = "Mensual";
                    btnSemanal.Text = "Quincenal";
                    btnQuincenal.Text = "Semanal";
                }
            }
            else
            {
                panelLeft.Width = 75;//tamaño contraido
                _isPanelExpand = true;
                //eliminar el texto de los botones
                foreach (Button button in panelLeft.Controls.OfType<Button>())
                {
                    btnTipoNomina.Text = "";
                    btnSalir.Text = "";
                    btnMensual.Text = "";
                    btnSemanal.Text = "";
                    btnQuincenal.Text = "";
                }
                //cierra el panel TipoNomina si el panelLeft esta cotraido
                if (_isPanelExpand)
                {
                    _isPanelVisibleTipoNomina = false;
                    panelTipoNomina.Visible = false;
                }
            }
        }
        private void MostrarFormularioEnPanel(Form formulario, Panel panel)
        {
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panel.Controls.Clear();
            panel.Controls.Add(formulario);
            formulario.Show();
        }
        private void DesplegarTipoNomina(object sender, EventArgs e)
        {
            //solo se despliega si el panelLeft esta expandido
            if (panelLeft.Width > 75)
            {
                _isPanelVisibleTipoNomina = !_isPanelVisibleTipoNomina;
                panelTipoNomina.Visible = _isPanelVisibleTipoNomina;
            }
            else
            {
                panelTipoNomina.Visible = false;
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea salir?",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnMensual_Click(object sender, EventArgs e)
        {
            if (frmGenericNominaMensual == null)
            {
                frmGenericNominaMensual = new FormNomina("Mensual");
            }
            else
            {
                if (frmGenericNominaMensual.HayDatosEnNomina())
                {
                    var resultado = MessageBox.Show("¿Desea reemplaar la nomina existente?", "Confirmacion",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        frmGenericNominaMensual.LimpiarDataGridview();
                    }
                    else
                    {
                        return;
                    }
                }
            }
            tabPrincipal.SelectedTab = tabMensual;// Cambia a la pestaña Mensual
            frmGenericNominaMensual.AjustarColumnas("Mensual");
            MostrarFormularioEnPanel(frmGenericNominaMensual, panelMensual);
        }

        private void btnQuincenal_Click(object sender, EventArgs e)
        {
            if (frmGenericNominaQuincenal == null)
            {
                frmGenericNominaQuincenal = new FormNomina("Quincenal");
            }
            else
            {
                if (frmGenericNominaQuincenal.HayDatosEnNomina())
                {
                    var resultado = MessageBox.Show("¿Desea reemplaar la nomina existente?", "Confirmacion",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        frmGenericNominaQuincenal.LimpiarDataGridview();
                    }
                    else
                    {
                        return;
                    }
                }
            }
            tabPrincipal.SelectedTab = tabQuincenal;
            frmGenericNominaQuincenal.AjustarColumnas("Quincenal");
            MostrarFormularioEnPanel(frmGenericNominaQuincenal, panelQuincenal);
        }

        private void btnSemanal_Click(object sender, EventArgs e)
        {
            if (frmGenericNominaSemanal == null)
            {
                frmGenericNominaSemanal = new FormNomina("Semanal");
            }
            else
            {
                if (frmGenericNominaSemanal.HayDatosEnNomina())
                {
                    var resultado = MessageBox.Show("¿Desea reemplaar la nomina existente?", "Confirmacion",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        frmGenericNominaSemanal.LimpiarDataGridview();
                    }
                    else
                    {
                        return;
                    }
                }
            }
            tabPrincipal.SelectedTab = tabSemanal;
            frmGenericNominaSemanal.AjustarColumnas("Semanal");
            MostrarFormularioEnPanel(frmGenericNominaSemanal, panelSemanal);
        }
    }
}
