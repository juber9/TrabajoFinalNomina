namespace TrabajoFinalNomina
{
    partial class MostrarNomina
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
            cboEmpleados = new ComboBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnMostrarNomina = new Button();
            btnAgregarEmpleado = new Button();
            lvMostrarNominas = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            columnHeader16 = new ColumnHeader();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // cboEmpleados
            // 
            cboEmpleados.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEmpleados.FormattingEnabled = true;
            cboEmpleados.Location = new Point(266, 63);
            cboEmpleados.Name = "cboEmpleados";
            cboEmpleados.Size = new Size(497, 30);
            cboEmpleados.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 66);
            label1.Name = "label1";
            label1.Size = new Size(197, 22);
            label1.TabIndex = 1;
            label1.Text = "Nombre del empleado: ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnMostrarNomina);
            groupBox1.Controls.Add(btnAgregarEmpleado);
            groupBox1.Controls.Add(lvMostrarNominas);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cboEmpleados);
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(42, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1127, 404);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sistema de nóminas";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnMostrarNomina
            // 
            btnMostrarNomina.Location = new Point(132, 333);
            btnMostrarNomina.Name = "btnMostrarNomina";
            btnMostrarNomina.Size = new Size(171, 29);
            btnMostrarNomina.TabIndex = 4;
            btnMostrarNomina.Text = "Mostrar nómina";
            btnMostrarNomina.UseVisualStyleBackColor = true;
            // 
            // btnAgregarEmpleado
            // 
            btnAgregarEmpleado.Location = new Point(808, 333);
            btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            btnAgregarEmpleado.Size = new Size(166, 29);
            btnAgregarEmpleado.TabIndex = 3;
            btnAgregarEmpleado.Text = "Agregar empleado";
            btnAgregarEmpleado.UseVisualStyleBackColor = true;
            btnAgregarEmpleado.Click += btnAgregarEmpleado_Click;
            // 
            // lvMostrarNominas
            // 
            lvMostrarNominas.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12, columnHeader13, columnHeader14, columnHeader15, columnHeader16 });
            lvMostrarNominas.Location = new Point(39, 149);
            lvMostrarNominas.Name = "lvMostrarNominas";
            lvMostrarNominas.Size = new Size(1050, 156);
            lvMostrarNominas.TabIndex = 2;
            lvMostrarNominas.UseCompatibleStateImageBehavior = false;
            lvMostrarNominas.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "No. INSS";
            columnHeader1.Width = 88;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Depto.";
            columnHeader2.Width = 65;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Salario Mensual";
            columnHeader3.Width = 142;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Salario quincenal";
            columnHeader4.Width = 151;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Horas extras";
            columnHeader5.Width = 112;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Antiguedad";
            columnHeader6.Width = 102;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Total de ingresos";
            columnHeader7.Width = 149;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "INSS laboral";
            columnHeader8.Width = 116;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "IR";
            columnHeader9.Width = 31;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Total deducciones";
            columnHeader10.Width = 157;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Salario neto";
            columnHeader11.Width = 108;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "INATEC";
            columnHeader12.Width = 83;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "INSS patronal";
            columnHeader13.Width = 124;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Vacaciones ";
            columnHeader14.Width = 108;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "Treceavo mes";
            columnHeader15.Width = 123;
            // 
            // columnHeader16
            // 
            columnHeader16.Tag = "";
            columnHeader16.Text = "Indemnización ";
            columnHeader16.Width = 131;
            // 
            // MostrarNomina
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1207, 484);
            Controls.Add(groupBox1);
            Name = "MostrarNomina";
            Text = "MostrarNomina";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cboEmpleados;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnAgregarEmpleado;
        private ListView lvMostrarNominas;
        private Button btnMostrarNomina;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader16;
    }
}