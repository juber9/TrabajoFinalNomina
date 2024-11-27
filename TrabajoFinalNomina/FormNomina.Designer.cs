namespace TrabajoFinalNomina
{
    partial class FormNomina
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
            mtbAntigüedad = new MaskedTextBox();
            mtbHorasExtra = new MaskedTextBox();
            txtSalario = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            cmbDepartamento = new ComboBox();
            mtbNoINNS = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            dvgNomina = new DataGridView();
            clmNoINNS = new DataGridViewTextBoxColumn();
            clmNombre = new DataGridViewTextBoxColumn();
            clmDepartamento = new DataGridViewTextBoxColumn();
            clmSalarioMensual = new DataGridViewTextBoxColumn();
            clmSalarioQuincenal = new DataGridViewTextBoxColumn();
            clmSalarioSemanal = new DataGridViewTextBoxColumn();
            clmHorasExtras = new DataGridViewTextBoxColumn();
            clmIngresoPorHora = new DataGridViewTextBoxColumn();
            clmAntigüedad = new DataGridViewTextBoxColumn();
            clmTotalIngresos = new DataGridViewTextBoxColumn();
            clmINNSLaboral = new DataGridViewTextBoxColumn();
            clmIR = new DataGridViewTextBoxColumn();
            clmTotalDeducciones = new DataGridViewTextBoxColumn();
            clmSalarioNeto = new DataGridViewTextBoxColumn();
            clmINATEC = new DataGridViewTextBoxColumn();
            clmINNSPatronal = new DataGridViewTextBoxColumn();
            clmVacaciones = new DataGridViewTextBoxColumn();
            clmTreceavoMes = new DataGridViewTextBoxColumn();
            btnCalcular = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnCargar = new Button();
            panel1 = new Panel();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dvgNomina).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // mtbAntigüedad
            // 
            mtbAntigüedad.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mtbAntigüedad.Location = new Point(1069, 162);
            mtbAntigüedad.Mask = "99";
            mtbAntigüedad.Name = "mtbAntigüedad";
            mtbAntigüedad.Size = new Size(225, 34);
            mtbAntigüedad.TabIndex = 27;
            mtbAntigüedad.ValidatingType = typeof(int);
            // 
            // mtbHorasExtra
            // 
            mtbHorasExtra.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mtbHorasExtra.Location = new Point(1069, 109);
            mtbHorasExtra.Mask = "99";
            mtbHorasExtra.Name = "mtbHorasExtra";
            mtbHorasExtra.Size = new Size(225, 34);
            mtbHorasExtra.TabIndex = 26;
            mtbHorasExtra.ValidatingType = typeof(int);
            // 
            // txtSalario
            // 
            txtSalario.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSalario.Location = new Point(1069, 57);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(225, 34);
            txtSalario.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            label6.Location = new Point(807, 158);
            label6.Name = "label6";
            label6.Size = new Size(186, 40);
            label6.TabIndex = 24;
            label6.Text = "Antigüedad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            label5.Location = new Point(807, 108);
            label5.Name = "label5";
            label5.Size = new Size(197, 40);
            label5.TabIndex = 23;
            label5.Text = "Horas Extras:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            label4.Location = new Point(807, 58);
            label4.Name = "label4";
            label4.Size = new Size(119, 40);
            label4.TabIndex = 22;
            label4.Text = "Salario:";
            // 
            // cmbDepartamento
            // 
            cmbDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartamento.Font = new Font("Cambria", 13.8F, FontStyle.Bold);
            cmbDepartamento.FormattingEnabled = true;
            cmbDepartamento.Items.AddRange(new object[] { "Direccion", "Recursos Humanos", "Produccion", "Marketing", "Compras", "Logística" });
            cmbDepartamento.Location = new Point(412, 156);
            cmbDepartamento.Name = "cmbDepartamento";
            cmbDepartamento.Size = new Size(225, 35);
            cmbDepartamento.TabIndex = 21;
            // 
            // mtbNoINNS
            // 
            mtbNoINNS.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mtbNoINNS.Location = new Point(412, 109);
            mtbNoINNS.Mask = "999999999";
            mtbNoINNS.Name = "mtbNoINNS";
            mtbNoINNS.Size = new Size(225, 34);
            mtbNoINNS.TabIndex = 20;
            mtbNoINNS.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            label3.Location = new Point(124, 158);
            label3.Name = "label3";
            label3.Size = new Size(226, 40);
            label3.TabIndex = 19;
            label3.Text = "Departamento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            label2.Location = new Point(124, 108);
            label2.Name = "label2";
            label2.Size = new Size(145, 40);
            label2.TabIndex = 18;
            label2.Text = "No. INNS";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(412, 58);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(225, 34);
            txtNombre.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            label1.Location = new Point(124, 58);
            label1.Name = "label1";
            label1.Size = new Size(139, 40);
            label1.TabIndex = 14;
            label1.Text = "Nombre:";
            // 
            // dvgNomina
            // 
            dvgNomina.Anchor = AnchorStyles.None;
            dvgNomina.BackgroundColor = SystemColors.ControlLight;
            dvgNomina.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgNomina.Columns.AddRange(new DataGridViewColumn[] { clmNoINNS, clmNombre, clmDepartamento, clmSalarioMensual, clmSalarioQuincenal, clmSalarioSemanal, clmHorasExtras, clmIngresoPorHora, clmAntigüedad, clmTotalIngresos, clmINNSLaboral, clmIR, clmTotalDeducciones, clmSalarioNeto, clmINATEC, clmINNSPatronal, clmVacaciones, clmTreceavoMes });
            dvgNomina.Location = new Point(12, 251);
            dvgNomina.Name = "dvgNomina";
            dvgNomina.ReadOnly = true;
            dvgNomina.RowHeadersWidth = 51;
            dvgNomina.Size = new Size(1426, 337);
            dvgNomina.TabIndex = 2;
            // 
            // clmNoINNS
            // 
            clmNoINNS.HeaderText = "No. INNS";
            clmNoINNS.MinimumWidth = 6;
            clmNoINNS.Name = "clmNoINNS";
            clmNoINNS.ReadOnly = true;
            clmNoINNS.Width = 125;
            // 
            // clmNombre
            // 
            clmNombre.HeaderText = "Nombre";
            clmNombre.MinimumWidth = 6;
            clmNombre.Name = "clmNombre";
            clmNombre.ReadOnly = true;
            clmNombre.Width = 125;
            // 
            // clmDepartamento
            // 
            clmDepartamento.HeaderText = "Departamento";
            clmDepartamento.MinimumWidth = 6;
            clmDepartamento.Name = "clmDepartamento";
            clmDepartamento.ReadOnly = true;
            clmDepartamento.Width = 125;
            // 
            // clmSalarioMensual
            // 
            clmSalarioMensual.HeaderText = "Salario Mensual";
            clmSalarioMensual.MinimumWidth = 6;
            clmSalarioMensual.Name = "clmSalarioMensual";
            clmSalarioMensual.ReadOnly = true;
            clmSalarioMensual.Width = 125;
            // 
            // clmSalarioQuincenal
            // 
            clmSalarioQuincenal.HeaderText = "Salario Quincenal";
            clmSalarioQuincenal.MinimumWidth = 6;
            clmSalarioQuincenal.Name = "clmSalarioQuincenal";
            clmSalarioQuincenal.ReadOnly = true;
            clmSalarioQuincenal.Width = 125;
            // 
            // clmSalarioSemanal
            // 
            clmSalarioSemanal.HeaderText = "Salario Semanal";
            clmSalarioSemanal.MinimumWidth = 6;
            clmSalarioSemanal.Name = "clmSalarioSemanal";
            clmSalarioSemanal.ReadOnly = true;
            clmSalarioSemanal.Width = 125;
            // 
            // clmHorasExtras
            // 
            clmHorasExtras.HeaderText = "Horas Extras";
            clmHorasExtras.MinimumWidth = 6;
            clmHorasExtras.Name = "clmHorasExtras";
            clmHorasExtras.ReadOnly = true;
            clmHorasExtras.Width = 125;
            // 
            // clmIngresoPorHora
            // 
            clmIngresoPorHora.HeaderText = "Ingreso por hora";
            clmIngresoPorHora.MinimumWidth = 6;
            clmIngresoPorHora.Name = "clmIngresoPorHora";
            clmIngresoPorHora.ReadOnly = true;
            clmIngresoPorHora.Width = 125;
            // 
            // clmAntigüedad
            // 
            clmAntigüedad.HeaderText = "Antigüedad";
            clmAntigüedad.MinimumWidth = 6;
            clmAntigüedad.Name = "clmAntigüedad";
            clmAntigüedad.ReadOnly = true;
            clmAntigüedad.Width = 125;
            // 
            // clmTotalIngresos
            // 
            clmTotalIngresos.HeaderText = "Total de Ingresos";
            clmTotalIngresos.MinimumWidth = 6;
            clmTotalIngresos.Name = "clmTotalIngresos";
            clmTotalIngresos.ReadOnly = true;
            clmTotalIngresos.Width = 125;
            // 
            // clmINNSLaboral
            // 
            clmINNSLaboral.HeaderText = "INNS Laboral";
            clmINNSLaboral.MinimumWidth = 6;
            clmINNSLaboral.Name = "clmINNSLaboral";
            clmINNSLaboral.ReadOnly = true;
            clmINNSLaboral.Width = 125;
            // 
            // clmIR
            // 
            clmIR.HeaderText = "IR";
            clmIR.MinimumWidth = 6;
            clmIR.Name = "clmIR";
            clmIR.ReadOnly = true;
            clmIR.Width = 125;
            // 
            // clmTotalDeducciones
            // 
            clmTotalDeducciones.HeaderText = "Total Deducciones";
            clmTotalDeducciones.MinimumWidth = 6;
            clmTotalDeducciones.Name = "clmTotalDeducciones";
            clmTotalDeducciones.ReadOnly = true;
            clmTotalDeducciones.Width = 125;
            // 
            // clmSalarioNeto
            // 
            clmSalarioNeto.HeaderText = "Salario Neto";
            clmSalarioNeto.MinimumWidth = 6;
            clmSalarioNeto.Name = "clmSalarioNeto";
            clmSalarioNeto.ReadOnly = true;
            clmSalarioNeto.Width = 125;
            // 
            // clmINATEC
            // 
            clmINATEC.HeaderText = "INATEC";
            clmINATEC.MinimumWidth = 6;
            clmINATEC.Name = "clmINATEC";
            clmINATEC.ReadOnly = true;
            clmINATEC.Width = 125;
            // 
            // clmINNSPatronal
            // 
            clmINNSPatronal.HeaderText = "INNS Patronal";
            clmINNSPatronal.MinimumWidth = 6;
            clmINNSPatronal.Name = "clmINNSPatronal";
            clmINNSPatronal.ReadOnly = true;
            clmINNSPatronal.Width = 125;
            // 
            // clmVacaciones
            // 
            clmVacaciones.HeaderText = "Vacaciones";
            clmVacaciones.MinimumWidth = 6;
            clmVacaciones.Name = "clmVacaciones";
            clmVacaciones.ReadOnly = true;
            clmVacaciones.Width = 125;
            // 
            // clmTreceavoMes
            // 
            clmTreceavoMes.HeaderText = "Treceavo mes";
            clmTreceavoMes.MinimumWidth = 6;
            clmTreceavoMes.Name = "clmTreceavoMes";
            clmTreceavoMes.ReadOnly = true;
            clmTreceavoMes.Width = 125;
            // 
            // btnCalcular
            // 
            btnCalcular.Anchor = AnchorStyles.None;
            btnCalcular.BackColor = Color.FromArgb(116, 86, 171);
            btnCalcular.FlatAppearance.BorderSize = 0;
            btnCalcular.Font = new Font("Segoe UI", 24F);
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Location = new Point(73, 606);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(225, 90);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.None;
            btnEliminar.BackColor = Color.FromArgb(116, 86, 171);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.Font = new Font("Segoe UI", 24F);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(423, 606);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(225, 90);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.BackColor = Color.FromArgb(116, 86, 171);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.Font = new Font("Segoe UI", 24F);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(780, 606);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(225, 90);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCargar
            // 
            btnCargar.Anchor = AnchorStyles.None;
            btnCargar.BackColor = Color.FromArgb(116, 86, 171);
            btnCargar.FlatAppearance.BorderSize = 0;
            btnCargar.Font = new Font("Segoe UI", 24F);
            btnCargar.ForeColor = Color.White;
            btnCargar.Location = new Point(1144, 606);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(225, 90);
            btnCargar.TabIndex = 7;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = false;
            btnCargar.Click += btnCargar_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(48, 56, 90);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtSalario);
            panel1.Controls.Add(mtbNoINNS);
            panel1.Controls.Add(cmbDepartamento);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(mtbAntigüedad);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(mtbHorasExtra);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1426, 222);
            panel1.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(104, 40);
            label7.TabIndex = 28;
            label7.Text = "Datos:";
            // 
            // FormNomina
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 56, 79);
            ClientSize = new Size(1450, 725);
            Controls.Add(panel1);
            Controls.Add(btnCargar);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(btnCalcular);
            Controls.Add(dvgNomina);
            Name = "FormNomina";
            Text = "FormNomina";
            ((System.ComponentModel.ISupportInitialize)dvgNomina).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private MaskedTextBox mtbAntigüedad;
        private MaskedTextBox mtbHorasExtra;
        private TextBox txtSalario;
        private Label label6;
        private Label label5;
        private Label label4;
        private ComboBox cmbDepartamento;
        private MaskedTextBox mtbNoINNS;
        private Label label3;
        private Label label2;
        private TextBox txtNombre;
        private DataGridView dvgNomina;
        private DataGridViewTextBoxColumn clmNoINNS;
        private DataGridViewTextBoxColumn clmNombre;
        private DataGridViewTextBoxColumn clmDepartamento;
        private DataGridViewTextBoxColumn clmSalarioMensual;
        private DataGridViewTextBoxColumn clmSalarioQuincenal;
        private DataGridViewTextBoxColumn clmSalarioSemanal;
        private DataGridViewTextBoxColumn clmHorasExtras;
        private DataGridViewTextBoxColumn clmIngresoPorHora;
        private DataGridViewTextBoxColumn clmAntigüedad;
        private DataGridViewTextBoxColumn clmTotalIngresos;
        private DataGridViewTextBoxColumn clmINNSLaboral;
        private DataGridViewTextBoxColumn clmIR;
        private DataGridViewTextBoxColumn clmTotalDeducciones;
        private DataGridViewTextBoxColumn clmSalarioNeto;
        private DataGridViewTextBoxColumn clmINATEC;
        private DataGridViewTextBoxColumn clmINNSPatronal;
        private DataGridViewTextBoxColumn clmVacaciones;
        private DataGridViewTextBoxColumn clmTreceavoMes;
        private Button btnCalcular;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnCargar;
        private Panel panel1;
        private Label label7;
    }
}