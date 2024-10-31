namespace TrabajoFinalNomina
{
    partial class Nominas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            nominasEmpleadosToolStripMenuItem = new ToolStripMenuItem();
            empleadosRegistradosToolStripMenuItem = new ToolStripMenuItem();
            mostrarToolStripMenuItem = new ToolStripMenuItem();
            editasrToolStripMenuItem = new ToolStripMenuItem();
            borrarToolStripMenuItem = new ToolStripMenuItem();
            agregarToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { nominasEmpleadosToolStripMenuItem, empleadosRegistradosToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(853, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // nominasEmpleadosToolStripMenuItem
            // 
            nominasEmpleadosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarToolStripMenuItem });
            nominasEmpleadosToolStripMenuItem.Name = "nominasEmpleadosToolStripMenuItem";
            nominasEmpleadosToolStripMenuItem.Size = new Size(160, 24);
            nominasEmpleadosToolStripMenuItem.Text = "Nominas empleados";
            // 
            // empleadosRegistradosToolStripMenuItem
            // 
            empleadosRegistradosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mostrarToolStripMenuItem, editasrToolStripMenuItem, borrarToolStripMenuItem });
            empleadosRegistradosToolStripMenuItem.Name = "empleadosRegistradosToolStripMenuItem";
            empleadosRegistradosToolStripMenuItem.Size = new Size(175, 24);
            empleadosRegistradosToolStripMenuItem.Text = "Empleados registrados";
            // 
            // mostrarToolStripMenuItem
            // 
            mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            mostrarToolStripMenuItem.Size = new Size(224, 26);
            mostrarToolStripMenuItem.Text = "Mostrar";
            // 
            // editasrToolStripMenuItem
            // 
            editasrToolStripMenuItem.Name = "editasrToolStripMenuItem";
            editasrToolStripMenuItem.Size = new Size(143, 26);
            editasrToolStripMenuItem.Text = "Editar";
            editasrToolStripMenuItem.Click += editasrToolStripMenuItem_Click;
            // 
            // borrarToolStripMenuItem
            // 
            borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            borrarToolStripMenuItem.Size = new Size(224, 26);
            borrarToolStripMenuItem.Text = "Borrar";
            // 
            // agregarToolStripMenuItem
            // 
            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            agregarToolStripMenuItem.Size = new Size(224, 26);
            agregarToolStripMenuItem.Text = "Agregar";
            agregarToolStripMenuItem.Click += AgregarNomina;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(52, 24);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // Nominas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 470);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Nominas";
            Text = "Nominas";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem nominasEmpleadosToolStripMenuItem;
        private ToolStripMenuItem empleadosRegistradosToolStripMenuItem;
        private ToolStripMenuItem mostrarToolStripMenuItem;
        private ToolStripMenuItem editasrToolStripMenuItem;
        private ToolStripMenuItem borrarToolStripMenuItem;
        private ToolStripMenuItem agregarToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}